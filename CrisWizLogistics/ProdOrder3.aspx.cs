using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrisWizLogistics.WizLogisticsDataSetTableAdapters;

namespace CrisWizLogistics
{
    public partial class ProdOrder3 : System.Web.UI.Page
    {
        protected void Next_Click(object sender, EventArgs e)
        {
            this.Session["RejectedView"] = (object)null;
            this.Response.Redirect("ProdOrder4");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            if (this.Session["ProductionOrderId"] != null && this.Session["ItemCode"] != null && (this.Session["ActionName"] != null && this.Session["WorkCenterName"] != null) && this.Session["ProcessQty"] != null)
            {
                ProceduresAdapter proceduresAdapter = new ProceduresAdapter();
                long num = (long)this.Session["ProductionOrderId"];
                string str1 = "";
                string str2 = "";
                DateTime? nullable = new DateTime?(DateTime.Now);
                long? ProductionOrderID = new long?(num);
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string ShiftName = @str1;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                string WorkerName = @str2;
                // ISSUE: explicit reference operation
                // ISSUE: variable of a reference type
                DateTime ?  CreatedDate = @nullable;
                int productionOrderStartInfo = (int)proceduresAdapter.GetProductionOrderStartInfo(ProductionOrderID,ref ShiftName,ref WorkerName,ref CreatedDate);
                this.ItemCode.Text = (string)this.Session["ItemCode"];
                this.ActionName.Text = (string)this.Session["ActionName"];
                this.WorkCenterName.Text = (string)this.Session["WorkCenterName"];
                this.ProcessQty.Text = this.Session["ProcessQty"].ToString();
                this.WorkerName.Text = WorkerName;
                this.ShiftName.Text = ShiftName;
                this.CreatedDate.Text = nullable.Value.ToString("dd/MM/yyyy hh:mm");
            }
            else
                this.Response.Redirect("ProdOrder1");
        }

        protected void Prev_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("ProdOrder1");
        }



    }
}