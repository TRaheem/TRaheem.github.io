using Marina.Ass1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.Ass1.App.Account
{
    public partial class LeasedSlips : System.Web.UI.Page
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
                        var db = new MarinaEntities();
                        //var customerId = Convert.ToInt32();
                        var leases = (from p in db.Leases

                                      where p.CustomerID == id

                                      select p).ToList();
                        uxLeasedSlips.DataSource = leases;
                        uxLeasedSlips.DataBind();
                    }
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Lease");
        }
    }
}