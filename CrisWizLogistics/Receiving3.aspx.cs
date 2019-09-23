using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Receiving3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["SupplyOrderId"] != null)
            {
                this.SupplyOrderLinesView.DataSource = (object)new SupplyOrderLinesTableAdapter().GetData(new long?((long)this.Session["SupplyOrderId"]));
                this.SupplyOrderLinesView.DataBind();
            }
            else
                this.Response.Redirect("Receiving1");
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Receiving2");
        }

        protected void SupplyOrderLinesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Session["SupplyOrderLineId"] = this.SupplyOrderLinesView.SelectedValue;
            this.Session["ItemName"] = (object)this.SupplyOrderLinesView.SelectedRow.Cells[1].Text;
            this.Session["Quantity"] = (object)this.SupplyOrderLinesView.SelectedRow.Cells[2].Text;
            this.Session["MeasureUnit"] = (object)this.SupplyOrderLinesView.SelectedRow.Cells[3].Text;
            this.Response.Redirect("Receiving4");
        }
    }
}