using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CrisWizLogistics
{
    public partial class LivBrut3 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["docnoAE"] == null)
                this.Response.Redirect("LivBrut1");
            this.Literal1.Text = this.Session["PartDesDetails"].ToString();
            this.Literal2.Text = this.Session["docnoAE"].ToString();
            this.Literal3.Text = this.Session["custAE"].ToString();
            this.bindGridProd();
        }

        private void bindGridProd()
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            sqlCommand.CommandText = "Select LINE AS ln,SERIALNAME as SerialName, partdes as PartDes, QUANT as QUANT FROM AEBRUT WHERE DOC = " + this.Session["docAE"].ToString() + " and partdes = '" + this.Session["PartDesDetails"].ToString() + "'";
            sqlCommand.CommandType = CommandType.Text;
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                sqlCommand.Connection.Open();
            try
            {
                this.GridProd.DataSource = (object)sqlCommand.ExecuteReader();
                this.GridProd.DataBind();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    sqlCommand.Connection.Close();
            }
        }

        protected void GridProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            sqlCommand.CommandText = "dbo.DeleteAERow";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@line", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters[0].Value = (object)DBNull.Value;
            sqlCommand.Parameters[1].Value = (object)this.GridProd.SelectedRow.Cells[0].Text.ToString();
            ConnectionState state = sqlCommand.Connection.State;
            if ((sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                sqlCommand.Connection.Open();
            try
            {
                sqlCommand.ExecuteScalar();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    sqlCommand.Connection.Close();
            }
            if (Convert.ToInt32(sqlCommand.Parameters[0].Value.ToString()) > 0)
            {
                this.SuccessText.Text = "Au fost sterse " + sqlCommand.Parameters[0].Value.ToString() + " randuri";
                this.FailureText.Text = " ";
                this.bindGridProd();
            }
            else
            {
                this.SuccessText.Text = " ";
                this.FailureText.Text = "Au fost sterse " + sqlCommand.Parameters[0].Value.ToString() + " randuri";
                this.bindGridProd();
            }
        }

        protected void intoarcere_Click(object sender, EventArgs e)
        {
            this.Response.Redirect("LivBrut2");
        }
    }
}