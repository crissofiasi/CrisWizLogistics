using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;
using System.Data;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;

namespace CrisWizLogistics
{
    public partial class ProdOrder4 : System.Web.UI.Page
    {

        public ProdOrder4()
        {
        }

        protected void AddRejected_Click(object sender, EventArgs e)
        {
            if (base.IsValid)
            {
                WizLogisticsDataSet.RejectedLinesDataTable rejectedLinesDataTable = (this.Session["RejectedView"] == null ? new WizLogisticsDataSet.RejectedLinesDataTable() : (WizLogisticsDataSet.RejectedLinesDataTable)this.Session["RejectedView"]);
                rejectedLinesDataTable.AddRejectedLinesRow(Convert.ToInt16(this.RejectedReasonName.SelectedValue), this.RejectedReasonName.SelectedItem.Text, Convert.ToDouble(this.RejectedQty.Text));
                this.Session["RejectedView"] = rejectedLinesDataTable;
                this.RejectedView.DataSource = rejectedLinesDataTable;
                this.RejectedView.DataBind();
                if (rejectedLinesDataTable.Count > 0 && Settings.GetValue("MRQ", "1") == "0")
                {
                    this.Add.Visible = false;
                }
            }
        }

        protected void DelRejected_Click(object sender, EventArgs e)
        {
            if (this.Session["RejectedView"] != null)
            {
                (this.Session["RejectedView"] as DataTable).Clear();
            }
            else
            {
                this.Session["RejectedView"] = new WizLogisticsDataSet.RejectedLinesDataTable();
            }
            this.RejectedView.DataSource = this.Session["RejectedView"];
            this.RejectedView.DataBind();
            if (!this.Add.Visible)
            {
                this.Add.Visible = true;
            }
        }

        protected void MeasureUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.Session["ProcessQty"] == null || this.Session["ConvertedProcessQty"] == null)
            {
                base.Response.Redirect("ProdOrder1");
                return;
            }
            if (this.MeasureUnit.SelectedValue == "1")
            {
                this.ProcessQty.Text = this.Session["ProcessQty"].ToString();
                this.FinishedQtyValidator.ValidationExpression = "\\d*\\.?\\d+";
                this.StoppedQtyValidator.ValidationExpression = "\\d*\\.?\\d+";
                this.RejectedQtyValidator.ValidationExpression = "\\d*\\.?\\d+";
                return;
            }
            this.ProcessQty.Text = this.Session["ConvertedProcessQty"].ToString();
            this.FinishedQtyValidator.ValidationExpression = "\\d+";
            this.StoppedQtyValidator.ValidationExpression = "\\d+";
            this.RejectedQtyValidator.ValidationExpression = "\\d+";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsPostBack)
            {
                if (this.Session["ConvertedProcessQty"] != null)
                {
                    if (this.Session["UserID"] == null)
                    {
                        base.Response.Redirect("Login");
                        return;
                    }
                    RejectedReasonsTableAdapter rejectedReasonsTableAdapter = new RejectedReasonsTableAdapter();
                    this.ProcessQty.Text = this.Session["ConvertedProcessQty"].ToString();
                    this.MeasureUnitGroup.Visible = Settings.GetValue("MMU", "0") == "1";
                    this.RejectedReasonName.DataSource = rejectedReasonsTableAdapter.GetData(new int?((int)this.Session["UserID"]));
                    this.RejectedReasonName.DataBind();
                    if (this.Session["RejectedView"] != null)
                    {
                        this.RejectedView.DataSource = this.Session["RejectedView"];
                    }
                    else
                    {
                        this.RejectedView.DataSource = new WizLogisticsDataSet.RejectedLinesDataTable();
                        this.Session["RejectedView"] = this.RejectedView.DataSource;
                    }
                    this.RejectedView.DataBind();
                    return;
                }
                base.Response.Redirect("ProdOrder1");
            }
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            base.Response.Redirect("ProdOrder1");
        }

        protected void Stop_Click(object sender, EventArgs e)
        {
            string text;
            double? nullable;
            string str;
            if (!base.IsValid)
            {
                this.FailureText.Text = "";
                return;
            }
            if (this.Session["ProductionOrderId"] == null)
            {
                base.Response.Redirect("ProdOrder1");
                return;
            }
            if (this.Stop.Text != "Stop")
            {
                this.Session["ProductionOrderFinishedQty"] = this.FinishedQty.Text;
                base.Response.Redirect("Consumption");
                return;
            }
            ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
            long item = (long)this.Session["ProductionOrderId"];
            byte num = Convert.ToByte(this.MeasureUnit.SelectedValue);
            double num1 = Convert.ToDouble(this.FinishedQty.Text);
            if (this.Remarks.Text.Length <= 0)
            {
                text = null;
            }
            else
            {
                text = this.Remarks.Text;
            }
            string str1 = text;
            if (this.StoppedQty.Text.Length <= 0)
            {
                nullable = null;
            }
            else
            {
                nullable = new double?(Convert.ToDouble(this.StoppedQty.Text));
            }
            double? nullable1 = nullable;
            if (this.StoppedRemarks.Text.Length <= 0)
            {
                str = null;
            }
            else
            {
                str = this.StoppedRemarks.Text;
            }
            if ((int)proceduresAdapter.StopProductionOrder(new long?(item), new byte?(num), new double?(num1), str1, nullable1, str, this.Session["RejectedView"]) == 1)
            {
                this.FailureText.Text = "Comanda de productie nu a fost oprita!";
                return;
            }
            this.FailureText.Text = "";
            this.SuccessText.Text = "Comanda de productie a fost oprita cu succes";
            if (this.MeasureUnit.SelectedValue != "2")
            {
                return;
            }
            this.Stop.Text = "Raportare consum?";
        }


    }
}