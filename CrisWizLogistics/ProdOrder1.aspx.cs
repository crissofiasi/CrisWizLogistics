using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class ProdOrder1 : System.Web.UI.Page
    {

        protected void Next_Click(object sender, EventArgs e)
        {
            if (!this.IsValid)
                this.FailureText.Text = "";
            else if (this.Session["UserID"] == null)
            {
                this.Response.Redirect("Login");
            }
            else
            {
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                long? nullable1 = new long?(0L);
                string str1 = "";
                string str2 = "";
                string str3 = "";
                double? nullable2 = new double?(0.0);
                double? nullable3 = new double?(0.0);
                bool? nullable4 = new bool?(false);
                string text1 = this.ProdOrderCode.Text;
                string text2 = this.ActionCode.Text;
                string text3 = this.WorkCenterCode.Text;
                int? UserID = new int?((int)this.Session["UserID"]);
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                long? ProductionOrderID = @nullable1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string ItemCode = @str1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string ActionName = @str2;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string WorkCenterName = @str3;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                double? ProcessQty = @nullable2;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                double? ConvertedProcessQty = @nullable3;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                bool? Started = @nullable4;
                if ((int)proceduresAdapter.GetProductionOrder(text1, text2, text3, UserID, ref ProductionOrderID,ref ItemCode,ref ActionName,ref WorkCenterName,ref ProcessQty,ref ConvertedProcessQty,ref Started) == 1)
                {
                    this.FailureText.Text = "Nu s-a gasit o comanda de productie cu acesti parametrii!";
                }
                else
                {
                    this.FailureText.Text = "";
                    this.Session["ProductionOrderId"] = (object)ProductionOrderID;
                    this.Session["ProductionOrderCode"] = (object)this.ProdOrderCode.Text;
                    this.Session["ItemCode"] = (object)ItemCode;
                    this.Session["ActionName"] = (object)ActionName;
                    this.Session["WorkCenterName"] = (object)WorkCenterName;
                    this.Session["ProcessQty"] = (object)ProcessQty;
                    this.Session["ConvertedProcessQty"] = (object)ConvertedProcessQty;
                    if (Started.Value)
                        this.Response.Redirect("ProdOrder3");
                    else
                        this.Response.Redirect("ProdOrder2");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            int num = this.IsPostBack ? 1 : 0;
        }



    }
}