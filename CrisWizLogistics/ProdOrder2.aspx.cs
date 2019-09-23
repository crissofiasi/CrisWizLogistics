using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class ProdOrder2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["ItemCode"] != null && this.Session["ActionName"] != null && (this.Session["WorkCenterName"] != null && this.Session["ProcessQty"] != null))
            {
                if (this.Session["UserID"] == null)
                {
                    this.Response.Redirect("Login");
                }
                else
                {
                    ShiftsTableAdapter shiftsTableAdapter = new ShiftsTableAdapter();
                    this.ItemCode.Text = (string)this.Session["ItemCode"];
                    this.ActionName.Text = (string)this.Session["ActionName"];
                    this.WorkCenterName.Text = (string)this.Session["WorkCenterName"];
                    this.ProcessQty.Text = this.Session["ProcessQty"].ToString();
                    this.ShiftName.DataSource = (object)shiftsTableAdapter.GetData(new int?((int)this.Session["UserID"]));
                    this.ShiftName.DataBind();
                }
            }
            else
                this.Response.Redirect("ProdOrder1");
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("ProdOrder1");
        }

        protected void Start_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                this.FailureText.Text = "";
            else if (this.Session["ProductionOrderId"] == null)
            {
                this.Response.Redirect("ProdOrder1");
            }
            else
            {
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                long num1 = (long)this.Session["ProductionOrderId"];
                int int32 = Convert.ToInt32(this.ShiftName.SelectedValue);
                int? WorkerID = new int?(0);
                string Name = "";
                if ((int)proceduresAdapter.GetWorker(this.WorkerCode.Text, ref WorkerID, ref Name) == 1)
                {
                    this.FailureText.Text = "Nu s-a gasit un operator cu acest cod!";
                }
                else
                {
                    this.FailureText.Text = "";
                    this.WorkerCode.Text = Name;
                    if (this.Session["UserID"] == null)
                    {
                        this.Response.Redirect("Login");
                    }
                    else
                    {
                        int num2 = (int)this.Session["UserID"];
                        if ((int)proceduresAdapter.StartProductionOrder(new long?(num1), new int?(int32), WorkerID, new int?(num2)) == 1)
                        {
                            this.FailureText.Text = "Comanda de productie nu a fost pornita!";
                        }
                        else
                        {
                            this.SuccessText.Text = "Comanda de productie a fost pornita cu succes";
                            this.Start.Visible = false;
                        }
                    }
                }
            }
        }



    }
}