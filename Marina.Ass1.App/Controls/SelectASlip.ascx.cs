using Marina.Ass1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.Ass1.App.Controls
{
    public partial class SelectASlip : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // get customer id out of session
                if (Session["CustomerID"] != null)
                {
                    var id = Convert.ToInt32(Session["CustomerID"]);

                    // get the Authentication object from the manager
                    var auth = AuthenticationManager.Find(id);

                    if (auth != null)
                    {
                        var mgr = new SlipManager();
                        uxDocks.DataSource = mgr.GetAllDocks();
                        uxDocks.DataTextField = "Name";
                        uxDocks.DataValueField = "ID";
                        uxDocks.DataBind();

                        var db = new MarinaEntities();
                        var leases = (from p in db.Leases
                                      where p.CustomerID == id
                                      select p).ToList();
                        uxLeasedSlips.DataSource = leases;
                        uxLeasedSlips.DataBind();
                    }
                }
            }
            // empty dropdownlist on page load
            uxDocks.Items.Insert(0, new ListItem("", ""));
        }

        protected void uxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            var selectedDockID = Convert.ToInt32(uxDocks.SelectedValue);
            var availableSlips = db.Slips.Where(s => s.Leases.Count
            == 0 && s.DockID == selectedDockID).ToList();
            uxAvailableSlips.DataSource = availableSlips;
            uxAvailableSlips.DataBind();
        }

        
        protected void uxAvailableSlips_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void uxSubmit_Click(object sender, EventArgs e)
        {
            var db = new MarinaEntities();
            var id = Convert.ToInt32(Session["CustomerID"]);
            var authlease = new Lease
            {
                SlipID = Convert.ToInt32(uxAvailableSlips.SelectedRow.Cells[1].Text),
                CustomerID = id
            };

            //pass the authlease object to the manager for inserting
            AuthenticationManager.Add(authlease);

            Response.Write("<script>alert('Your lease has been submited successfully')</script>");
            Server.Transfer("~/Account/LeasedSlips.aspx");
        }
    }
}