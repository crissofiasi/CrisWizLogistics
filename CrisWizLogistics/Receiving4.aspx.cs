using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;
namespace CrisWizLogistics
{
    public partial class Receiving4 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["ItemName"] != null && this.Session["Quantity"] != null && this.Session["MeasureUnit"] != null)
            {
                this.ItemName.Text = (string)this.Session["ItemName"];
                this.OrderQty.Text = this.Session["Quantity"].ToString();
                this.MeasureUnit.Text = (string)this.Session["MeasureUnit"];
            }
            else
                this.Response.Redirect("Receiving1");
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Receiving3");
        }

        protected void Receive_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                this.FailureText.Text = "";
            else if (this.Session["SupplyOrderLineId"] == null)
            {
                this.Response.Redirect("Receiving1");
            }
            else
            {
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                long num1 = (long)this.Session["SupplyOrderLineId"];
                double num2 = Convert.ToDouble(this.ReceivedQty.Text);
                string text1 = this.InternalBatchNo.Text;
                string text2 = this.SupplierBatchNo.Text;
                long? SupplyOrderLineID = new long?(num1);
                double? Quantity = new double?(num2);
                string InternalBatchNo = text1;
                string SupplierBatchNo = text2;
                if ((int)proceduresAdapter.ReceiveSupplyOrderLine(SupplyOrderLineID, Quantity, InternalBatchNo, SupplierBatchNo) == 1)
                {
                    this.FailureText.Text = "Receptia nu s-a efectuat!";
                }
                else
                {
                    this.FailureText.Text = "";
                    this.SuccessText.Text = "Receptia s-a efectuat cu succes";
                    this.Receive.Visible = false;
                }
            }
        }
    }
}