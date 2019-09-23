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
    public partial class DeliveryBrut2 : System.Web.UI.Page
    {
        public string db;

        public int QuantMem;

        public int DocMem;

        public string DocNoMem;

        public int SerialMem;

        public string SerialNameMem;

        public bool msg;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.CustomerName.Text = " ";
            this.DocDate.Text = " ";
            this.AECode.Focus();
            if (this.AECode.Text.Length <= 0)
                return;
            this.cautaAE(this.AECode.Text);
            if (this.CustomerName.Text.Length > 0)
            {
                this.Lot.ReadOnly = false;
                this.Lot.Visible = true;
                this.lotetich.Visible = true;
                this.Lot.Focus();
                if (this.Lot.Text.Length > 0)
                {
                    this.cautaLOT(this.Lot.Text);
                    if (this.SerialMem.ToString().Length <= 0)
                        return;
                    this.cantLot.Focus();
                }
                else
                {
                    this.partdes.Visible = false;
                    this.cantetic.Visible = false;
                    this.cantLot.Visible = false;
                }
            }
            else
            {
                this.Lot.Visible = false;
                this.lotetich.Visible = false;
            }
        }

        protected void cautaLOT(string lot)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            command.CommandText = "dbo.GetLot";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@serialname", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@serial", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@partdes", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters[0].Value = (object)DBNull.Value;
            command.Parameters[1].Value = (object)lot;
            command.Parameters[2].Value = (object)this.db;
            command.Parameters[3].Value = (object)DBNull.Value;
            command.Parameters[4].Value = (object)DBNull.Value;
            DeliveryBrut2.runsql(command);
            this.SerialMem = Convert.ToInt32(string.IsNullOrEmpty(command.Parameters[3].Value.ToString()) ? "0" : command.Parameters[3].Value.ToString());
            this.partdes.Text = command.Parameters[4].Value.ToString();
            this.SerialNameMem = lot;
            if (this.SerialMem > 0)
            {
                this.partdes.Visible = true;
                this.cantetic.Visible = true;
                this.cantLot.Visible = true;
                this.savelot.Visible = true;
                this.cantLot.Focus();
                this.FailureText.Text = "";
                this.SuccessText.Text = "";
            }
            else
            {
                this.partdes.Visible = false;
                this.cantetic.Visible = false;
                this.cantLot.Visible = false;
                this.savelot.Visible = false;
                if (lot.Length <= 0)
                    return;
                this.FailureText.Text = "Lotul nu a fost gasit";
            }
        }

        protected void saveclick(object sender, EventArgs e)
        {
            this.QuantMem = Convert.ToInt32(this.cantLot.Text);
            SqlCommand command = new SqlCommand();
            command.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            string str = "dbo.InsertLot";
            command.CommandText = str;
            int num = 4;
            command.CommandType = (CommandType)num;
            command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@doc", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@docno", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@serial", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@serialname", SqlDbType.NVarChar, 22, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@quant", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters[0].Value = (object)DBNull.Value;
            command.Parameters[1].Value = (object)this.DocMem;
            command.Parameters[2].Value = (object)this.DocNoMem;
            command.Parameters[3].Value = (object)this.SerialMem;
            command.Parameters[4].Value = (object)this.SerialNameMem;
            command.Parameters[5].Value = (object)this.QuantMem;
            command.Parameters[6].Value = (object)this.db.ToString();
            DeliveryBrut2.runsql(command);
            if (command.Parameters[0].Value.ToString() == "1")
            {
                this.SuccessText.Text = "Cantitate salvata cu success";
                this.msg = true;
                this.partdes.Visible = false;
                this.cantetic.Visible = false;
                this.cantLot.Visible = false;
                this.savelot.Visible = false;
                this.QuantMem = 0;
                this.SerialMem = 0;
                this.SerialNameMem = "";
                this.Lot.Text = "";
                this.Lot.Focus();
                this.partdes.Text = "";
                this.cantLot.Text = "";
            }
            else
            {
                this.FailureText.Text = "Eroare salvare ";
                this.msg = true;
            }
        }

        private static object runsql(SqlCommand command)
        {
            ConnectionState state = command.Connection.State;
            if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
                command.Connection.Open();
            try
            {
                return command.ExecuteScalar();
            }
            finally
            {
                if (state == ConnectionState.Closed)
                    command.Connection.Close();
            }
        }

        protected void cautaAE(string aecod)
        {
            int length = aecod.IndexOf(".");
            this.db = " ";
            string str = aecod;
            if (length >= 0)
            {
                this.db = aecod.Substring(0, length).ToLower();
                str = aecod.Substring(length + 1);
            }
            this.CustomerName.Text = this.db;
            this.DocDate.Text = str;
            SqlCommand command = new SqlCommand();
            command.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
            command.CommandText = "dbo.GetAE";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte)10, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@docno", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@NameDb", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@doc", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@custdes", SqlDbType.NVarChar, 148, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters.Add(new SqlParameter("@curdate", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte)0, (byte)0, (string)null, DataRowVersion.Current, false, (object)null, "", "", ""));
            command.Parameters[0].Value = (object)DBNull.Value;
            command.Parameters[1].Value = (object)str;
            command.Parameters[2].Value = (object)this.db;
            command.Parameters[3].Value = (object)DBNull.Value;
            command.Parameters[4].Value = (object)DBNull.Value;
            command.Parameters[5].Value = (object)DBNull.Value;
            DeliveryBrut2.runsql(command);
            this.DocMem = Convert.ToInt32(string.IsNullOrEmpty(command.Parameters[3].Value.ToString()) ? "0" : command.Parameters[3].Value.ToString());
            this.DocNoMem = str;
            this.CustomerName.Text = command.Parameters[4].Value.ToString();
            this.DocDate.Text = command.Parameters[5].Value.ToString();
        }



    }
}