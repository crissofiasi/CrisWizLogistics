using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Delivery1 : System.Web.UI.Page
    {

        protected void Find_Click(object sender, EventArgs e)
        {
            DateTime value;
            ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
            long? nullable = new long?((long)0);
            DateTime? nullable1 = new DateTime?(DateTime.MinValue);
            string str = "";
            bool? nullable2 = new bool?(false);
            if ((int)proceduresAdapter.GetSaleOrder(this.SaleOrderCode.Text, new int?((int)this.Session["UserID"]), ref nullable, ref nullable1, ref str, ref nullable2) == 1)
            {
                this.FailureText.Text = "Nu s-a gasit o comanda de vanzare cu acest cod!";
                this.DocDate.Text = "";
                this.CustomerName.Text = "";
                this.SaleOrderLinesView.DataSource = null;
                this.SaleOrderLinesView.DataBind();
                this.Finish.Visible = false;
                this.Session["SaleOrderId"] = null;
                return;
            }
            if (nullable2.Value)
            {
                this.FailureText.Text = "Aceasta comanda este livrata integral!";
                TextBox docDate = this.DocDate;
                value = nullable1.Value;
                docDate.Text = value.ToString("dd/MM/yyyy");
                this.CustomerName.Text = str;
                this.SaleOrderLinesView.DataSource = null;
                this.SaleOrderLinesView.DataBind();
                this.Finish.Visible = false;
                this.Session["SaleOrderId"] = null;
                return;
            }
            TextBox textBox = this.DocDate;
            value = nullable1.Value;
            textBox.Text = value.ToString("dd/MM/yyyy");
            this.CustomerName.Text = str;
            SaleOrderLinesTableAdapter saleOrderLinesTableAdapter = new SaleOrderLinesTableAdapter();
            this.SaleOrderLinesView.Columns[0].Visible = true;
            this.SaleOrderLinesView.DataSource = saleOrderLinesTableAdapter.GetData(nullable);
            this.SaleOrderLinesView.DataBind();
            this.Finish.Visible = true;
            this.Session["SaleOrderId"] = nullable;
        }

        protected void Finish_Click(object sender, EventArgs e)
        {
            if (this.Session["SaleOrderId"] == null)
            {
                base.Response.Redirect("Delivery1");
                return;
            }
            if ((int)(new ProceduresAdapter()).DeliverSaleOrder(new long?((long)this.Session["SaleOrderId"])) == 1)
            {
                this.FailureText.Text = "Livrarea nu s-a finalizat!";
                return;
            }
            this.SuccessText.Text = "Livrare finalizata cu succes";
            this.SaleOrderLinesView.Columns[0].Visible = false;
            this.Finish.Visible = false;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (base.IsPostBack)
            {
                this.FailureText.Text = "";
                this.SuccessText.Text = "";
                return;
            }
            if (base.Request.UrlReferrer != null && base.Request.UrlReferrer.AbsolutePath.ToLower().Contains("delivery2") && this.Session["SaleOrderId"] != null && this.Session["SaleOrderCode"] != null)
            {
                this.SaleOrderCode.Text = this.Session["SaleOrderCode"].ToString();
                this.DocDate.Text = this.Session["DocDate"].ToString();
                this.CustomerName.Text = this.Session["CustomerName"].ToString();
                SaleOrderLinesTableAdapter saleOrderLinesTableAdapter = new SaleOrderLinesTableAdapter();
                long item = (long)this.Session["SaleOrderId"];
                this.SaleOrderLinesView.DataSource = saleOrderLinesTableAdapter.GetData(new long?(item));
                this.Finish.Visible = true;
            }
            this.SaleOrderLinesView.DataBind();
        }

        protected void SaleOrderLinesView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Session["SaleOrderCode"] = this.SaleOrderCode.Text;
            this.Session["DocDate"] = this.DocDate.Text;
            this.Session["CustomerName"] = this.CustomerName.Text;
            this.Session["ItemCode"] = this.SaleOrderLinesView.SelectedValue;
            this.Session["ItemName"] = this.SaleOrderLinesView.SelectedRow.Cells[1].Text;
            this.Session["Quantity"] = this.SaleOrderLinesView.SelectedRow.Cells[2].Text;
            this.Session["DeliverQuantity"] = this.SaleOrderLinesView.SelectedRow.Cells[3].Text.Replace("&nbsp;", "");
            this.Session["BatchView"] = null;
            base.Response.Redirect("Delivery2");
        }


    }
}