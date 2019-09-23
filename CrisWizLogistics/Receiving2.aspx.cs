using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Receiving2 : System.Web.UI.Page
    {


        protected void Finish_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                this.FailureText.Text = "";
            else if (this.Session["SupplyOrderId"] == null)
                this.Response.Redirect("Receiving1");
            else if ((int)new ProceduresAdapter().ReceiveSupplyOrder(new long?((long)this.Session["SupplyOrderId"]), this.SupplierDocNum.Text, new bool?(true)) == 1)
            {
                this.FailureText.Text = "Receptia nu s-a finalizat!";
            }
            else
            {
                this.SuccessText.Text = "Receptia finalizata cu succes";
                this.OrderItems.Visible = false;
                this.Finish.Visible = false;
            }
        }

        protected void OrderItems_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                this.FailureText.Text = "";
            else if (this.Session["SupplyOrderId"] == null)
                this.Response.Redirect("Receiving1");
            else if ((int)new ProceduresAdapter().ReceiveSupplyOrder(new long?((long)this.Session["SupplyOrderId"]), this.SupplierDocNum.Text, new bool?(false)) == 1)
                this.FailureText.Text = "Datele introduse nu s-au salvat!";
            else
                this.Response.Redirect("Receiving3");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["DocDate"] != null && this.Session["SupplierName"] != null && this.Session["SupplyOrderId"] != null)
            {
                this.DocDate.Text = (string)this.Session["DocDate"];
                this.SupplierName.Text = (string)this.Session["SupplierName"];
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                long num = (long)this.Session["SupplyOrderId"];
                string str = "";
                long? SupplyOrderID = new long?(num);
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string SupplierDocNum = @str;
                proceduresAdapter.GetSupplyOrderInfo(SupplyOrderID,ref SupplierDocNum);
                this.SupplierDocNum.Text = str;
            }
            else
                this.Response.Redirect("Receiving1");
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("Receiving1");
        }

    }
}