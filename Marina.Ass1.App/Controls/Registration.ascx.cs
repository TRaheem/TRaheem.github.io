using Marina.Ass1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marina.Ass1.App.Controls
{
    public partial class Registration : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void uxSubmit_Click(object sender, EventArgs e)
        {
            // to insert the record
            var auth = new Customer
            {
                FirstName = uxFirstName.Text,
                LastName = uxLastName.Text,
                City = uxCity.Text,
                Phone = uxPhone.Text,
            };

            //pass the auth object to the manager for inserting
            AuthenticationManager.Add(auth);

            //Redirect
            Response.Redirect("~/Login");
        }
    }
}