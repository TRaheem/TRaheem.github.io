using Marina.Ass1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.Ass1.App.Controls
{
    public partial class SlipSelector : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                uxDocks.SelectedValue = null;
                var mgr = new SlipManager();
                uxDocks.DataSource = mgr.GetAllDocks();
                uxDocks.DataTextField = "Name";
                uxDocks.DataValueField = "ID";

                uxDocks.Items.Insert(0, new ListItem("", ""));
                uxDocks.DataBind();
            }
            uxDocks.Items.Insert(0, new ListItem("", ""));
        }

        protected void uxDocks_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            uxDocks.DataTextField = "Name";
            uxDocks.DataValueField = "ID";
           


            var db = new MarinaEntities ();
            var selectedDockID = Convert.ToInt32(uxDocks.SelectedValue);
            var availableSlips = db.Slips.Where(s => s.Leases.Count
            == 0 && s.DockID == selectedDockID).ToList();
            uxAvailableSlips.DataSource = availableSlips;
            uxAvailableSlips.DataBind();
        }
    }
}