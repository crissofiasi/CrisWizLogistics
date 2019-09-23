

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
  public class ProceduresAdapter : Component
  {
    private IDbCommand[] _commandCollection;

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected IDbCommand[] CommandCollection
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
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object DeliverSaleOrder(long? SaleOrderID)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[11];
      if (!SaleOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) SaleOrderID.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object DeliverSaleOrderLine(string ItemCode, double? DeliverQuantity, object BatchLines)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[13];
      if (ItemCode != null)
        command.Parameters[1].Value = (object) ItemCode;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (!DeliverQuantity.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) DeliverQuantity.Value;
      if (BatchLines != null)
        command.Parameters[3].Value = BatchLines;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetProductionOrder(string Code, string ActionCode, string WorkCenterCode, int? UserID, ref long? ProductionOrderID, ref string ItemCode, ref string ActionName, ref string WorkCenterName, ref double? ProcessQty, ref double? ConvertedProcessQty, ref bool? Started)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[1];
      if (Code != null)
        command.Parameters[1].Value = (object) Code;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (ActionCode != null)
        command.Parameters[2].Value = (object) ActionCode;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      if (WorkCenterCode != null)
        command.Parameters[3].Value = (object) WorkCenterCode;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      if (!UserID.HasValue)
        command.Parameters[4].Value = (object) DBNull.Value;
      else
        command.Parameters[4].Value = (object) UserID.Value;
      if (!ProductionOrderID.HasValue)
        command.Parameters[5].Value = (object) DBNull.Value;
      else
        command.Parameters[5].Value = (object) ProductionOrderID.Value;
      if (ItemCode != null)
        command.Parameters[6].Value = (object) ItemCode;
      else
        command.Parameters[6].Value = (object) DBNull.Value;
      if (ActionName != null)
        command.Parameters[7].Value = (object) ActionName;
      else
        command.Parameters[7].Value = (object) DBNull.Value;
      if (WorkCenterName != null)
        command.Parameters[8].Value = (object) WorkCenterName;
      else
        command.Parameters[8].Value = (object) DBNull.Value;
      if (!ProcessQty.HasValue)
        command.Parameters[9].Value = (object) DBNull.Value;
      else
        command.Parameters[9].Value = (object) ProcessQty.Value;
      if (!ConvertedProcessQty.HasValue)
        command.Parameters[10].Value = (object) DBNull.Value;
      else
        command.Parameters[10].Value = (object) ConvertedProcessQty.Value;
      if (!Started.HasValue)
        command.Parameters[11].Value = (object) DBNull.Value;
      else
        command.Parameters[11].Value = (object) Started.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      ProductionOrderID = command.Parameters[5].Value == null || command.Parameters[5].Value.GetType() == typeof (DBNull) ? new long?() : new long?((long) command.Parameters[5].Value);
      ItemCode = command.Parameters[6].Value == null || command.Parameters[6].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[6].Value;
      ActionName = command.Parameters[7].Value == null || command.Parameters[7].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[7].Value;
      WorkCenterName = command.Parameters[8].Value == null || command.Parameters[8].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[8].Value;
      ProcessQty = command.Parameters[9].Value == null || command.Parameters[9].Value.GetType() == typeof (DBNull) ? new double?() : new double?((double) command.Parameters[9].Value);
      ConvertedProcessQty = command.Parameters[10].Value == null || command.Parameters[10].Value.GetType() == typeof (DBNull) ? new double?() : new double?((double) command.Parameters[10].Value);
      Started = command.Parameters[11].Value == null || command.Parameters[11].Value.GetType() == typeof (DBNull) ? new bool?() : new bool?((bool) command.Parameters[11].Value);
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetProductionOrderStartInfo(long? ProductionOrderID, ref string ShiftName, ref string WorkerName, ref DateTime? CreatedDate)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[4];
      if (!ProductionOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) ProductionOrderID.Value;
      if (ShiftName != null)
        command.Parameters[2].Value = (object) ShiftName;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      if (WorkerName != null)
        command.Parameters[3].Value = (object) WorkerName;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      if (!CreatedDate.HasValue)
        command.Parameters[4].Value = (object) DBNull.Value;
      else
        command.Parameters[4].Value = (object) CreatedDate.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      ShiftName = command.Parameters[2].Value == null || command.Parameters[2].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[2].Value;
      WorkerName = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[3].Value;
      CreatedDate = command.Parameters[4].Value == null || command.Parameters[4].Value.GetType() == typeof (DBNull) ? new DateTime?() : new DateTime?((DateTime) command.Parameters[4].Value);
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetSaleOrder(string Code, int? UserID, ref long? SaleOrderID, ref DateTime? DocDate, ref string CustomerName, ref bool? Delivered)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[10];
      if (Code != null)
        command.Parameters[1].Value = (object) Code;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (!UserID.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) UserID.Value;
      if (!SaleOrderID.HasValue)
        command.Parameters[3].Value = (object) DBNull.Value;
      else
        command.Parameters[3].Value = (object) SaleOrderID.Value;
      if (!DocDate.HasValue)
        command.Parameters[4].Value = (object) DBNull.Value;
      else
        command.Parameters[4].Value = (object) DocDate.Value;
      if (CustomerName != null)
        command.Parameters[5].Value = (object) CustomerName;
      else
        command.Parameters[5].Value = (object) DBNull.Value;
      if (!Delivered.HasValue)
        command.Parameters[6].Value = (object) DBNull.Value;
      else
        command.Parameters[6].Value = (object) Delivered.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      SaleOrderID = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? new long?() : new long?((long) command.Parameters[3].Value);
      DocDate = command.Parameters[4].Value == null || command.Parameters[4].Value.GetType() == typeof (DBNull) ? new DateTime?() : new DateTime?((DateTime) command.Parameters[4].Value);
      CustomerName = command.Parameters[5].Value == null || command.Parameters[5].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[5].Value;
      Delivered = command.Parameters[6].Value == null || command.Parameters[6].Value.GetType() == typeof (DBNull) ? new bool?() : new bool?((bool) command.Parameters[6].Value);
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetSaleOrderLine(string ItemCode, string BatchNo, long SaleOrderLine, ref long? SaleOrderLineID, ref double? Quantity)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[12];
      if (ItemCode != null)
        command.Parameters[1].Value = (object) ItemCode;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (BatchNo != null)
        command.Parameters[2].Value = (object) BatchNo;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      command.Parameters[5].Value = (object) SaleOrderLine;
      if (!SaleOrderLineID.HasValue)
        command.Parameters[3].Value = (object) DBNull.Value;
      else
        command.Parameters[3].Value = (object) SaleOrderLineID.Value;
      if (!Quantity.HasValue)
        command.Parameters[4].Value = (object) DBNull.Value;
      else
        command.Parameters[4].Value = (object) Quantity.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      SaleOrderLineID = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? new long?() : new long?((long) command.Parameters[3].Value);
      Quantity = command.Parameters[4].Value == null || command.Parameters[4].Value.GetType() == typeof (DBNull) ? new double?() : new double?((double) command.Parameters[4].Value);
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetSettingValue(string Code, int? UserID, ref string Value)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[9];
      if (Code != null)
        command.Parameters[1].Value = (object) Code;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (!UserID.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) UserID.Value;
      if (Value != null)
        command.Parameters[3].Value = (object) Value;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      Value = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[3].Value;
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetSupplyOrderInfo(long? SupplyOrderID, ref string SupplierDocNum)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[8];
      if (!SupplyOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) SupplyOrderID.Value;
      if (SupplierDocNum != null)
        command.Parameters[2].Value = (object) SupplierDocNum;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      SupplierDocNum = command.Parameters[2].Value == null || command.Parameters[2].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[2].Value;
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object GetWorker(string Code, ref int? WorkerID, ref string Name)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[3];
      if (Code != null)
        command.Parameters[1].Value = (object) Code;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (!WorkerID.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) WorkerID.Value;
      if (Name != null)
        command.Parameters[3].Value = (object) Name;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      WorkerID = command.Parameters[2].Value == null || command.Parameters[2].Value.GetType() == typeof (DBNull) ? new int?() : new int?((int) command.Parameters[2].Value);
      Name = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[3].Value;
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitCommandCollection()
    {
      this._commandCollection = new IDbCommand[15];
      this._commandCollection[0] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[0]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[0]).CommandText = "dbo.ValidateUser";
      ((DbCommand) this._commandCollection[0]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[0]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[0]).Parameters.Add(new SqlParameter("@UserName", SqlDbType.NVarChar, 30, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[0]).Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[0]).Parameters.Add(new SqlParameter("@DisplayName", SqlDbType.NVarChar, 100, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[1] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[1]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[1]).CommandText = "dbo.GetProductionOrder";
      ((DbCommand) this._commandCollection[1]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 30, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ActionCode", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@WorkCenterCode", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ProductionOrderID", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.NVarChar, 20, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ActionName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@WorkCenterName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ProcessQty", SqlDbType.Float, 8, ParameterDirection.InputOutput, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@ConvertedProcessQty", SqlDbType.Float, 8, ParameterDirection.InputOutput, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[1]).Parameters.Add(new SqlParameter("@Started", SqlDbType.Bit, 1, ParameterDirection.InputOutput, (byte) 1, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[2] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[2]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[2]).CommandText = "dbo.StartProductionOrder";
      ((DbCommand) this._commandCollection[2]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[2]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[2]).Parameters.Add(new SqlParameter("@ProductionOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[2]).Parameters.Add(new SqlParameter("@ShiftID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[2]).Parameters.Add(new SqlParameter("@WorkerID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[2]).Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[3] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[3]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[3]).CommandText = "dbo.GetWorker";
      ((DbCommand) this._commandCollection[3]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[3]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[3]).Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[3]).Parameters.Add(new SqlParameter("@WorkerID", SqlDbType.Int, 4, ParameterDirection.InputOutput, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[3]).Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[4] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[4]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[4]).CommandText = "dbo.GetProductionOrderStartInfo";
      ((DbCommand) this._commandCollection[4]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[4]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[4]).Parameters.Add(new SqlParameter("@ProductionOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[4]).Parameters.Add(new SqlParameter("@ShiftName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[4]).Parameters.Add(new SqlParameter("@WorkerName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[4]).Parameters.Add(new SqlParameter("@CreatedDate", SqlDbType.DateTime, 8, ParameterDirection.InputOutput, (byte) 23, (byte) 3, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[5] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[5]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[5]).CommandText = "dbo.StopProductionOrder";
      ((DbCommand) this._commandCollection[5]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@ProductionOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@MeasureUnit", SqlDbType.TinyInt, 1, ParameterDirection.Input, (byte) 3, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@FinishedQty", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@Remarks", SqlDbType.NVarChar, 250, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@StoppedQty", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@StoppedRemarks", SqlDbType.NVarChar, 250, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[5]).Parameters.Add(new SqlParameter("@RejectedLines", SqlDbType.Structured, int.MaxValue, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[6] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[6]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[6]).CommandText = "dbo.ReceiveSupplyOrderLine";
      ((DbCommand) this._commandCollection[6]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[6]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[6]).Parameters.Add(new SqlParameter("@SupplyOrderLineID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[6]).Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[6]).Parameters.Add(new SqlParameter("@InternalBatchNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[6]).Parameters.Add(new SqlParameter("@SupplierBatchNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[7] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[7]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[7]).CommandText = "dbo.ReceiveSupplyOrder";
      ((DbCommand) this._commandCollection[7]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[7]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[7]).Parameters.Add(new SqlParameter("@SupplyOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[7]).Parameters.Add(new SqlParameter("@SupplierDocNum", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[7]).Parameters.Add(new SqlParameter("@Received", SqlDbType.Bit, 1, ParameterDirection.Input, (byte) 1, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[8] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[8]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[8]).CommandText = "dbo.GetSupplyOrderInfo";
      ((DbCommand) this._commandCollection[8]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[8]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[8]).Parameters.Add(new SqlParameter("@SupplyOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[8]).Parameters.Add(new SqlParameter("@SupplierDocNum", SqlDbType.NVarChar, 20, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[9] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[9]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[9]).CommandText = "dbo.GetSettingValue";
      ((DbCommand) this._commandCollection[9]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[9]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[9]).Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[9]).Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[9]).Parameters.Add(new SqlParameter("@Value", SqlDbType.NVarChar, 100, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[10] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[10]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[10]).CommandText = "dbo.GetSaleOrder";
      ((DbCommand) this._commandCollection[10]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@Code", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@SaleOrderID", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@DocDate", SqlDbType.Date, 3, ParameterDirection.InputOutput, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 50, ParameterDirection.InputOutput, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[10]).Parameters.Add(new SqlParameter("@Delivered", SqlDbType.Bit, 1, ParameterDirection.InputOutput, (byte) 1, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[11] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[11]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[11]).CommandText = "dbo.DeliverSaleOrder";
      ((DbCommand) this._commandCollection[11]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[11]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[11]).Parameters.Add(new SqlParameter("@SaleOrderID", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[12] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[12]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[12]).CommandText = "dbo.GetSaleOrderLineCriss";
      ((DbCommand) this._commandCollection[12]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@SaleOrderLineID", SqlDbType.BigInt, 8, ParameterDirection.InputOutput, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Float, 8, ParameterDirection.InputOutput, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[12]).Parameters.Add(new SqlParameter("@SaleOrderId", SqlDbType.BigInt, 8, ParameterDirection.Input, (byte) 19, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[13] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[13]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[13]).CommandText = "dbo.DeliverSaleOrderLine";
      ((DbCommand) this._commandCollection[13]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[13]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[13]).Parameters.Add(new SqlParameter("@ItemCode", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[13]).Parameters.Add(new SqlParameter("@DeliverQuantity", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[13]).Parameters.Add(new SqlParameter("@BatchLines", SqlDbType.Structured, int.MaxValue, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      this._commandCollection[14] = (IDbCommand) new SqlCommand();
      ((SqlCommand) this._commandCollection[14]).Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["WizLogisticsConnectionString"].ConnectionString);
      ((DbCommand) this._commandCollection[14]).CommandText = "dbo.ReportConsumption";
      ((DbCommand) this._commandCollection[14]).CommandType = CommandType.StoredProcedure;
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@ProductionOrderCode", SqlDbType.NVarChar, 30, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@WarehouseID", SqlDbType.SmallInt, 2, ParameterDirection.Input, (byte) 5, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@Remarks", SqlDbType.NVarChar, 50, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@InternalBatchNo", SqlDbType.NVarChar, 20, ParameterDirection.Input, (byte) 0, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@MainQty", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@SecondQty", SqlDbType.Float, 8, ParameterDirection.Input, (byte) 53, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
      ((SqlCommand) this._commandCollection[14]).Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int, 4, ParameterDirection.Input, (byte) 10, (byte) 0, (string) null, DataRowVersion.Current, false, (object) null, "", "", ""));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object ReceiveSupplyOrder(long? SupplyOrderID, string SupplierDocNum, bool? Received)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[7];
      if (!SupplyOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) SupplyOrderID.Value;
      if (SupplierDocNum != null)
        command.Parameters[2].Value = (object) SupplierDocNum;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      if (!Received.HasValue)
        command.Parameters[3].Value = (object) DBNull.Value;
      else
        command.Parameters[3].Value = (object) Received.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object ReceiveSupplyOrderLine(long? SupplyOrderLineID, double? Quantity, string InternalBatchNo, string SupplierBatchNo)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[6];
      if (!SupplyOrderLineID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) SupplyOrderLineID.Value;
      if (!Quantity.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) Quantity.Value;
      if (InternalBatchNo != null)
        command.Parameters[3].Value = (object) InternalBatchNo;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      if (SupplierBatchNo != null)
        command.Parameters[4].Value = (object) SupplierBatchNo;
      else
        command.Parameters[4].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object ReportConsumption(string ProductionOrderCode, short? WarehouseID, string Remarks, string InternalBatchNo, double? MainQty, double? SecondQty, int? UserID)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[14];
      if (ProductionOrderCode != null)
        command.Parameters[1].Value = (object) ProductionOrderCode;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (!WarehouseID.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) WarehouseID.Value;
      if (Remarks != null)
        command.Parameters[3].Value = (object) Remarks;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      if (InternalBatchNo != null)
        command.Parameters[4].Value = (object) InternalBatchNo;
      else
        command.Parameters[4].Value = (object) DBNull.Value;
      if (!MainQty.HasValue)
        command.Parameters[5].Value = (object) DBNull.Value;
      else
        command.Parameters[5].Value = (object) MainQty.Value;
      if (!SecondQty.HasValue)
        command.Parameters[6].Value = (object) DBNull.Value;
      else
        command.Parameters[6].Value = (object) SecondQty.Value;
      if (!UserID.HasValue)
        command.Parameters[7].Value = (object) DBNull.Value;
      else
        command.Parameters[7].Value = (object) UserID.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object StartProductionOrder(long? ProductionOrderID, int? ShiftID, int? WorkerID, int? UserID)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[2];
      if (!ProductionOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) ProductionOrderID.Value;
      if (!ShiftID.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) ShiftID.Value;
      if (!WorkerID.HasValue)
        command.Parameters[3].Value = (object) DBNull.Value;
      else
        command.Parameters[3].Value = (object) WorkerID.Value;
      if (!UserID.HasValue)
        command.Parameters[4].Value = (object) DBNull.Value;
      else
        command.Parameters[4].Value = (object) UserID.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object StopProductionOrder(long? ProductionOrderID, byte? MeasureUnit, double? FinishedQty, string Remarks, double? StoppedQty, string StoppedRemarks, object RejectedLines)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[5];
      if (!ProductionOrderID.HasValue)
        command.Parameters[1].Value = (object) DBNull.Value;
      else
        command.Parameters[1].Value = (object) ProductionOrderID.Value;
      if (!MeasureUnit.HasValue)
        command.Parameters[2].Value = (object) DBNull.Value;
      else
        command.Parameters[2].Value = (object) MeasureUnit.Value;
      if (!FinishedQty.HasValue)
        command.Parameters[3].Value = (object) DBNull.Value;
      else
        command.Parameters[3].Value = (object) FinishedQty.Value;
      if (Remarks != null)
        command.Parameters[4].Value = (object) Remarks;
      else
        command.Parameters[4].Value = (object) DBNull.Value;
      if (!StoppedQty.HasValue)
        command.Parameters[5].Value = (object) DBNull.Value;
      else
        command.Parameters[5].Value = (object) StoppedQty.Value;
      if (StoppedRemarks != null)
        command.Parameters[6].Value = (object) StoppedRemarks;
      else
        command.Parameters[6].Value = (object) DBNull.Value;
      if (RejectedLines != null)
        command.Parameters[7].Value = RejectedLines;
      else
        command.Parameters[7].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    [HelpKeyword("vs.data.TableAdapter")]
    public virtual object ValidateUser(string UserName, string Password, ref string DisplayName)
    {
      SqlCommand command = (SqlCommand) this.CommandCollection[0];
      if (UserName != null)
        command.Parameters[1].Value = (object) UserName;
      else
        command.Parameters[1].Value = (object) DBNull.Value;
      if (Password != null)
        command.Parameters[2].Value = (object) Password;
      else
        command.Parameters[2].Value = (object) DBNull.Value;
      if (DisplayName != null)
        command.Parameters[3].Value = (object) DisplayName;
      else
        command.Parameters[3].Value = (object) DBNull.Value;
      ConnectionState state = command.Connection.State;
      if ((command.Connection.State & ConnectionState.Open) != ConnectionState.Open)
        command.Connection.Open();
      object obj;
      try
      {
        obj = command.ExecuteScalar();
      }
      finally
      {
        if (state == ConnectionState.Closed)
          command.Connection.Close();
      }
      DisplayName = command.Parameters[3].Value == null || command.Parameters[3].Value.GetType() == typeof (DBNull) ? (string) null : (string) command.Parameters[3].Value;
      if (obj != null && !(obj.GetType() == typeof (DBNull)))
        return obj;
      return (object) null;
    }
  }
}
