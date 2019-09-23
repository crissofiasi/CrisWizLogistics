using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Receiving1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["UserID"] != null)
            {
                this.SupplyOrdersView.DataSource = (object)new SupplyOrdersTableAdapter().GetData(new int?((int)this.Session["UserID"]));
                this.SupplyOrdersView.DataBind();
            }
            else
                this.Response.Redirect("Login");
        }

        protected void SupplyOrdersView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strArray = this.SupplyOrdersView.SelectedRow.Cells[1].Text.Split(' ');
            this.Session["SupplyOrderId"] = this.SupplyOrdersView.SelectedValue;
            this.Session["DocDate"] = (object)strArray[1];
            this.Session["SupplierName"] = (object)this.SupplyOrdersView.SelectedRow.Cells[2].Text;
            this.Response.Redirect("Receiving2");
        }


    }
}