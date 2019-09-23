using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.SessionState;

namespace CrisWizLogistics
{
    public partial class LivBrut2 : System.Web.UI.Page
    {

        public int SerialMem;

        public SqlDataReader reader;
        public LivBrut2()
        {
        }

        protected void AddCant_Click(object sender, EventArgs e)
        {
            Convert.ToInt32(this.CantLot.Text);
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString),
                CommandText = "dbo.InsertLot",
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@doc", SqlDbType.BigInt, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@docno", SqlDbType.NVarChar, 10, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@serial", SqlDbType.BigInt, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@serialname", SqlDbType.NVarChar, 22, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@quant", SqlDbType.BigInt, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@partdes", SqlDbType.NVarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters[0].Value = DBNull.Value;
            sqlCommand.Parameters[1].Value = this.Session["docAE"];
            sqlCommand.Parameters[2].Value = this.Session["docnoAE"];
            sqlCommand.Parameters[3].Value = this.SerialMem;
            sqlCommand.Parameters[4].Value = this.Lot.Text;
            sqlCommand.Parameters[5].Value = Convert.ToInt32(this.CantLot.Text);
            sqlCommand.Parameters[6].Value = this.Session["NameDb"];
            sqlCommand.Parameters[7].Value = this.Produs.Text;
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            try
            {
                sqlCommand.ExecuteScalar();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    sqlCommand.Connection.Close();
                }
            }
            if (sqlCommand.Parameters[0].Value.ToString() != "1")
            {
                this.FailureText.Text = "Eroare salvare ";
                return;
            }
            this.SuccessText.Text = "Cantitate salvata cu success";
            this.AddProdus.Visible = false;
            this.Lot.Text = "";
            this.Lot.Focus();
            this.BindReader();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            this.Session["docAE"] = "";
            this.Session["docnoAE"] = "";
            this.Session["custAE"] = "";
            this.Session["docdateAE"] = "";
            base.Response.Redirect("LivBrut1");
        }

        protected void BindReader()
        {
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString),
                CommandText = string.Concat("Select partdes, sum(QUANT) as QUANT FROM AEBRUT WHERE DOC = ", this.Session["docAE"], " GROUP BY partdes"),
                CommandType = CommandType.Text
            };
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            try
            {
                this.reader = sqlCommand.ExecuteReader();
                this.GridAE.DataSource = this.reader;
                this.GridAE.DataBind();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    sqlCommand.Connection.Close();
                }
            }
        }

        protected void CautaLot_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString),
                CommandText = "dbo.GetLot",
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@serialname", SqlDbType.NVarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@serial", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@partdes", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters[0].Value = DBNull.Value;
            sqlCommand.Parameters[1].Value = this.Lot.Text;
            sqlCommand.Parameters[2].Value = this.Session["NameDb"];
            sqlCommand.Parameters[3].Value = DBNull.Value;
            sqlCommand.Parameters[4].Value = DBNull.Value;
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            try
            {
                sqlCommand.ExecuteScalar();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    sqlCommand.Connection.Close();
                }
            }
            this.SerialMem = Convert.ToInt32((string.IsNullOrEmpty(sqlCommand.Parameters[3].Value.ToString()) ? "0" : sqlCommand.Parameters[3].Value.ToString()));
            string str = sqlCommand.Parameters[4].Value.ToString();
            string text = this.Lot.Text;
            if (this.SerialMem <= 0)
            {
                this.FailureText.Text = "Lotul nu a fost gasit";
                this.AddProdus.Visible = false;
                this.CantLot.Text = "";
                return;
            }
            this.FailureText.Text = "";
            this.SuccessText.Text = "";
            this.AddProdus.Visible = true;
            this.Produs.Text = str;
            this.CantLot.Text = "";
        }

        protected void FinalAE_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand()
            {
                Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString),
                CommandText = "dbo.finalAE",
                CommandType = CommandType.StoredProcedure
            };
            sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@DOC", SqlDbType.BigInt, 8, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
            sqlCommand.Parameters[0].Value = DBNull.Value;
            sqlCommand.Parameters[1].Value = this.Session["docAE"];
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
            {
                sqlCommand.Connection.Open();
            }
            try
            {
                sqlCommand.ExecuteScalar();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                {
                    sqlCommand.Connection.Close();
                }
            }
            if (sqlCommand.Parameters[0].Value.ToString() == "1")
            {
                this.SuccessText.Text = "Document Finalizat";
                this.AddProdus.Visible = false;
                this.Lot.Text = "";
                this.Lot.Visible = false;
                this.BindReader();
                this.Back.Focus();
            }
        }

        protected void GridAE_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Session["PartDesDetails"] = this.GridAE.SelectedRow.Cells[0].Text.ToString();
            base.Response.Redirect("LivBrut3");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["docnoAE"] == null)
            {
                this.Back_Click(sender, e);
            }
            if (this.Session["docnoAE"].ToString().Length < 1)
            {
                this.Back_Click(sender, e);
            }
            this.AENo.Text = this.Session["docnoAE"].ToString();
            this.AECust.Text = this.Session["custAE"].ToString();
            this.AEDate.Text = this.Session["docdateAE"].ToString();
            this.BindReader();
        }





    }
}