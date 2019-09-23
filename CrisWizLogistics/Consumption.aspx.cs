using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class Consumption : System.Web.UI.Page
    {


        protected void NewOrder_Click(object sender, EventArgs e)
        {
            this.ProdOrderCode.Text = "";
            this.Warehouse.SelectedValue = "10";
            this.Remarks.Text = "";
            this.InternalBatchNo.Text = "";
            this.MainQty.Text = "";
            this.SecondQty.Text = "";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["UserID"] == null)
            {
                this.Response.Redirect("Login");
            }
            else
            {
                this.Warehouse.DataSource = (object)new WarehousesTableAdapter().GetData(new int?((int)this.Session["UserID"]));
                this.Warehouse.DataBind();
                this.Warehouse.SelectedValue = "10";
                if (this.Session["ProductionOrderCode"] == null || this.Session["ProductionOrderFinishedQty"] == null)
                    return;
                this.ProdOrderCode.Text = this.Session["ProductionOrderCode"].ToString();
                this.SecondQty.Text = this.Session["ProductionOrderFinishedQty"].ToString();
                this.Session["ProductionOrderCode"] = (object)null;
                this.Session["ProductionOrderFinishedQty"] = (object)null;
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                return;
            if (this.Session["UserID"] != null)
            {
                this.Warehouse.SelectedValue = "10";
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                string text1 = this.ProdOrderCode.Text;
                short int16 = Convert.ToInt16(this.Warehouse.SelectedValue);
                string text2 = this.Remarks.Text;
                string text3 = this.InternalBatchNo.Text;
                double num1 = this.MainQty.Text.Length > 0 ? Convert.ToDouble(this.MainQty.Text) : 0.0;
                double num2 = this.SecondQty.Text.Length > 0 ? Convert.ToDouble(this.SecondQty.Text) : 0.0;
                int num3 = (int)this.Session["UserID"];
                this.FailureText.Text = "";
                this.SuccessText.Text = "";
                if (num1 == 0.0 && num2 == 0.0)
                {
                    this.FailureText.Text = "Cel putin o cantitate de consum trebuie specificata!";
                }
                else
                {
                    switch ((int)proceduresAdapter.ReportConsumption(text1, new short?(int16), text2, text3, new double?(num1), new double?(num2), new int?(num3)))
                    {
                        case 3:
                            this.FailureText.Text = "Sunt necesare ambele tipuri de cantitati de consum!";
                            break;
                        case 2:
                            this.FailureText.Text = "Comanda productie sau lot material gresit!";
                            break;
                        case 1:
                            this.FailureText.Text = "Consumul nu a fost raportat!";
                            break;
                        default:
                            this.Warehouse.SelectedValue = "10";
                            this.Remarks.Text = "";
                            this.InternalBatchNo.Text = "";
                            this.MainQty.Text = "";
                            this.SecondQty.Text = "";
                            this.SuccessText.Text = "Cosumul a fost raportat cu succes";
                            break;
                    }
                }
            }
            else
                this.Response.Redirect("Login");
        }




    }
}