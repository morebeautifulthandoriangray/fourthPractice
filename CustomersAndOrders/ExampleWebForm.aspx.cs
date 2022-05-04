using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomersAndOrders
{
    public partial class ExampleWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickButton_Click(object sender, EventArgs e)
        {
            ServiceReference4Practice.Service1Client client = new ServiceReference4Practice.Service1Client();
            Result.Text = client.GetData(Convert.ToInt32(EnterValue.Text));
        }
    }
}