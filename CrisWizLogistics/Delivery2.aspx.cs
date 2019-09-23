using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Runtime.CompilerServices;
using System.Web.SessionState;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Delivery2 : System.Web.UI.Page
    {


        public Delivery2()
        {
        }

        protected void AddBatch_Click(object sender, EventArgs e)
        {
            if (this.Session["ItemCode"] == null)
            {
                base.Response.Redirect("Delivery1");
                return;
            }
            ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
            WizLogisticsDataSet.BatchLinesDataTable batchLinesDataTable = (this.Session["BatchView"] == null ? new WizLogisticsDataSet.BatchLinesDataTable() : (WizLogisticsDataSet.BatchLinesDataTable)this.Session["BatchView"]);
            if (batchLinesDataTable.Any<WizLogisticsDataSet.BatchLinesRow>((WizLogisticsDataSet.BatchLinesRow row) => row.BatchNo == this.BatchNo.Text))
            {
                return;
            }
            string str = this.Session["ItemCode"].ToString();
            long? nullable = new long?((long)0);
            double? nullable1 = new double?(0);
            int saleOrderLine = (int)proceduresAdapter.GetSaleOrderLine(str, this.BatchNo.Text, (long)this.Session["SaleOrderId"], ref nullable, ref nullable1);
            if (saleOrderLine == 1)
            {
                this.FailureText.Text = "Nu exista nici un lot definit cu acest cod! ";
                return;
            }
            if (saleOrderLine == 2)
            {
                this.FailureText.Text = "Acest lot a fost deja livrat/scanat!";
                return;
            }
            batchLinesDataTable.AddBatchLinesRow(nullable.Value, this.BatchNo.Text, (double)nullable1.Value);
            this.Session["BatchView"] = batchLinesDataTable;
            this.BatchView.DataSource = batchLinesDataTable;
            this.BatchView.DataBind();
            this.BatchNo.Text = "";
            this.BatchNo.Focus();
            TextBox docBatchQty = this.DocBatchQty;
            double num = batchLinesDataTable.Sum<WizLogisticsDataSet.BatchLinesRow>((WizLogisticsDataSet.BatchLinesRow row) => row.Quantity);
            docBatchQty.Text = num.ToString();
        }

        protected void DelBatch_Click(object sender, EventArgs e)
        {
            if (this.Session["BatchView"] != null)
            {
                (this.Session["BatchView"] as DataTable).Clear();
            }
            else
            {
                this.Session["BatchView"] = new WizLogisticsDataSet.BatchLinesDataTable();
            }
            this.BatchView.DataSource = this.Session["BatchView"];
            this.BatchView.DataBind();
            this.BatchNo.Text = "";
            this.BatchNo.Focus();
            this.DocBatchQty.Text = "";
            if (!this.Add.Visible)
            {
                this.Add.Visible = true;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (base.IsPostBack)
            {
                this.FailureText.Text = "";
                this.SuccessText.Text = "";
                return;
            }
            if (this.Session["ItemName"] == null || this.Session["Quantity"] == null || this.Session["DeliverQuantity"] == null)
            {
                base.Response.Redirect("Delivery1");
                return;
            }
            this.ItemName.Text = this.Session["ItemName"].ToString();
            this.DocQty.Text = this.Session["Quantity"].ToString();
            this.DeliverQty.Text = this.Session["DeliverQuantity"].ToString();
            if (this.Session["BatchView"] != null)
            {
                this.BatchView.DataSource = this.Session["BatchView"];
            }
            else
            {
                this.BatchView.DataSource = new WizLogisticsDataSet.BatchLinesDataTable();
                this.Session["BatchView"] = this.BatchView.DataSource;
            }
            this.BatchView.DataBind();
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Session["ConfirmOverflowQty"] = null;
            base.Response.Redirect("Delivery1");
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (this.Session["ItemCode"] == null)
            {
                base.Response.Redirect("Delivery1");
                return;
            }
            ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
            string str = this.Session["ItemCode"].ToString();
            double num = Convert.ToDouble(this.DocBatchQty.Text);
            double num1 = Convert.ToDouble(this.WeighedQty.Text);
            if (Math.Abs(100 - num1 / num * 100) <= 5)
            {
                if ((int)proceduresAdapter.DeliverSaleOrderLine(str, new double?(num1), this.Session["BatchView"]) == 1)
                {
                    this.FailureText.Text = "Cantitatea nu a fost adaugata in livrare!";
                    return;
                }
                this.SuccessText.Text = "Cantitate adaugata cu succes";
                this.Save.Visible = false;
                return;
            }
            if (this.Session["ConfirmOverflowQty"] == null)
            {
                this.Session["ConfirmOverflowQty"] = true;
                this.FailureText.Text = "Cantitatea nu se incadreaza in marja de 5% stabilita!";
                return;
            }
            if (this.Session["ConfirmOverflowQty"] == null)
            {
                return;
            }
            if ((int)proceduresAdapter.DeliverSaleOrderLine(str, new double?(num1), this.Session["BatchView"]) == 1)
            {
                this.FailureText.Text = "Cantitatea nu a fost adaugata in livrare!";
                return;
            }
            this.Session["ConfirmOverflowQty"] = null;
            this.SuccessText.Text = "Cantitate adaugata cu succes";
            this.Save.Visible = false;
        }




    }
}