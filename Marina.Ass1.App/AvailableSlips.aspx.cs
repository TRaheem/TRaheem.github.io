using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.Ass1.App
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void uxLeaseASlip_Click(object sender, EventArgs e)
        {
            //redirect
            Response.Redirect("~/Account/Lease");
        }
    }
}