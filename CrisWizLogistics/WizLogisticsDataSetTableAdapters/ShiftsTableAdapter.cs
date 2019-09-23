// Decompiled with JetBrains decompiler
// Type: WizLogistics.WizLogisticsDataSetTableAdapters.ShiftsTableAdapter
// Assembly: WizLogistics2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9944E73C-68D5-4BC1-954E-5CC5CE300CD2
// Assembly location: \\10.10.10.26\wwwroot\cris\bin\WizLogistics2.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CrisWizLogistics.WizLogisticsDataSetTableAdapters
{
  [DataObject(true)]
  [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.TableAdapter")]
  [ToolboxItem(true)]
  public class ShiftsTableAdapter : Component
  {
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;
    private SqlTransaction _transaction;
    private SqlCommand[] _commandCollection;
    private bool _clearBeforeFill;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected internal SqlDataAdapter Adapter
    {
      get
      {
        if (this._adapter == null)
          this.InitAdapter();
        return this._adapter;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public bool ClearBeforeFill
    {
      get
      {
        return this._clearBeforeFill;
      }
      set
      {
        this._clearBeforeFill = value;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected SqlCommand[] CommandCollection
    {
      get
      {
        if (this._commandCollection == null)
          this.InitCommandCollection();
        return this._commandCollection;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SqlConnection Connection
    {
      get
      {
        if (this._connection == null)
          this.InitConnection();
        return this._connection;
      }
      set
      {
        this._connection = value;
        if (this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Connection = value;
        if (this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Connection = value;
        if (this.Adapter.UpdateCommand != null)
          this.Adapter.UpdateCommand.Connection = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
        {
          if (this.CommandCollection[index] != null)
            this.CommandCollection[index].Connection = value;
        }
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal SqlTransaction Transaction
    {
      get
      {
        return this._transaction;
      }
      set
      {
        this._transaction = value;
        for (int index = 0; index < this.CommandCollection.Length; ++index)
          this.CommandCollection[index].Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.DeleteCommand != null)
          this.Adapter.DeleteCommand.Transaction = this._transaction;
        if (this.Adapter != null && this.Adapter.InsertCommand != null)
          this.Adapter.InsertCommand.Transaction = this._transaction;
        if (this.Adapter == null || this.Adapter.UpdateCommand == null)
          return;
        this.Adapter.UpdateCommand.Transaction = this._transaction;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public ShiftsTableAdapter()
    {
      this.ClearBeforeFill = true;
    }

    [DataObjectMethod(DataObjectMethodType.Fill, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual int Fill(WizLogisticsDataSet.ShiftsDataTable dataTable, int? UserID)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (!UserID.HasValue)
        this.Adapter.SelectCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.SelectCommand.Parameters[1].Value = (object) UserID.Value;
      if (this.ClearBeforeFill)
        dataTable.Clear();
      return this.Adapter.Fill((DataTable) dataTable);
    }

    [DataObjectMethod(DataObjectMethodType.Select, true)]
    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual WizLogisticsDataSet.ShiftsDataTable GetData(int? UserID)
    {
      this.Adapter.SelectCommand = this.CommandCollection[0];
      if (!UserID.HasValue)
        this.Adapter.SelectCommand.Parameters[1].Value = (object) DBNull.Value;
      else
        this.Adapter.SelectCommand.Parameters[1].Value = (object) UserID.Value;
      WizLogisticsDataSet.ShiftsDataTable shiftsDataTable = new WizLogisticsDataSet.ShiftsDataTable();
      this.Adapter.Fill((DataTable) shiftsDataTable);
      return shiftsDataTable;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitAdapter()
    {
      this._adapter = new SqlDataAdapter();
      DataTableMapping dataTableMapping = new DataTableMapping()
      {
        SourceTable = "Table",
        DataSetTable = "Shifts"
      };
      dataTableMapping.ColumnMappings.Add("ShiftID", "ShiftID");
      dataTableMapping.ColumnMappings.Add("Code", "Code");
      dataTableMapping.ColumnMappings.Add("Name", "Name");
      this._adapter.TableMappings.Add((object) dataTableMapping);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new SqlCommand[1]
      {
        new SqlCommand()
      };
      this._commandCollection[0].Connection = this.Connection;
      this._commandCollection[0].CommandText = "dbo.GetShifts";
      this._commandCollection[0].CommandType = CommandType.StoredProcedure;
      this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[0].Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitConnection()
    {
      SqlConnection sqlConnection = new SqlConnection();
      string connectionString = ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString;
      sqlConnection.ConnectionString = connectionString;
      this._connection = sqlConnection;
    }
  }
}
