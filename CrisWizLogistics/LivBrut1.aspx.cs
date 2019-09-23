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
    public partial class LivBrut1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void CautaAE_Click(object sender, EventArgs e)
        {
            string text = this.AECode.Text;
            int length = text.IndexOf(".");
            string str1 = " ";
            string str2 = text;
            if (length >= 0)
            {
                str1 = text.Substring(0, length).ToLower();
                str2 = text.Substring(length + 1);
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            sqlCommand.CommandText = "dbo.GetAE";
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@docno", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@doc", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@custdes", SqlDbType.NVarChar, 148, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters.Add(new SqlParameter("@curdate", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            sqlCommand.Parameters[0].Value = (object)DBNull.Value;
            sqlCommand.Parameters[1].Value = (object)str2;
            sqlCommand.Parameters[2].Value = (object)str1;
            sqlCommand.Parameters[3].Value = (object)DBNull.Value;
            sqlCommand.Parameters[4].Value = (object)DBNull.Value;
            sqlCommand.Parameters[5].Value = (object)DBNull.Value;
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
            int int32 = Convert.ToInt32(string.IsNullOrEmpty(sqlCommand.Parameters[3].Value.ToString()) ? "0" : sqlCommand.Parameters[3].Value.ToString());
            string str3 = str2;
            string str4 = sqlCommand.Parameters[4].Value.ToString();
            string str5 = sqlCommand.Parameters[5].Value.ToString();
            if (int32 > 0)
            {
                this.Session["docAE"] = (object)int32;
                this.Session["docnoAE"] = (object)str3;
                this.Session["custAE"] = (object)str4;
                this.Session["docdateAE"] = (object)str5;
                this.Session["NameDb"] = (object)str1;
                this.Response.Redirect("LivBrut2");
            }
            else
                this.FailureText.Text = "Avizul nu a fost gasit";
        }



    }
}