using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomersAndOrders
{
    public partial class CustAndOrderWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceReference4Practice.Service1Client client = new ServiceReference4Practice.Service1Client();
            Customers.DataSource = client.GetCustomers();
            Customers.DataBind();
        }

        protected void Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Customers.Rows[Customers.SelectedIndex].Cells[1].Text);

            ServiceReference4Practice.Service1Client order = new ServiceReference4Practice.Service1Client();

            Orders.DataSource = order.GetOrders(id);
            Orders.DataBind();
        }
    }
}