using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using CrisWizLogistics;

namespace CrisWizLogistics.WizLogisticsDataSetTableAdapters
{
    [Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [DesignerCategory("code")]
    [HelpKeyword("vs.data.TableAdapterManager")]
    [ToolboxItem(true)]
    public class TableAdapterManager : Component
    {
        private TableAdapterManager.UpdateOrderOption _updateOrder;

        private bool _backupDataSetBeforeUpdate;

        private IDbConnection _connection;

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public bool BackupDataSetBeforeUpdate
        {
            get
            {
                return this._backupDataSetBeforeUpdate;
            }
            set
            {
                this._backupDataSetBeforeUpdate = value;
            }
        }

        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public IDbConnection Connection
        {
            get
            {
                if (this._connection == null)
                {
                    return null;
                }
                return this._connection;
            }
            set
            {
                this._connection = value;
            }
        }

        [Browsable(false)]
        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public int TableAdapterInstanceCount
        {
            get
            {
                return 0;
            }
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public TableAdapterManager.UpdateOrderOption UpdateOrder
        {
            get
            {
                return this._updateOrder;
            }
            set
            {
                this._updateOrder = value;
            }
        }

        public TableAdapterManager()
        {
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
        {
            if (updatedRows == null || (int)updatedRows.Length < 1)
            {
                return updatedRows;
            }
            if (allAddedRows == null || allAddedRows.Count < 1)
            {
                return updatedRows;
            }
            List<DataRow> dataRows = new List<DataRow>();
            for (int i = 0; i < (int)updatedRows.Length; i++)
            {
                DataRow dataRow = updatedRows[i];
                if (!allAddedRows.Contains(dataRow))
                {
                    dataRows.Add(dataRow);
                }
            }
            return dataRows.ToArray();
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
        {
            if (this._connection != null)
            {
                return true;
            }
            if (this.Connection == null || inputConnection == null)
            {
                return true;
            }
            if (string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
            {
                return true;
            }
            return false;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
        {
            Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public virtual int UpdateAll(WizLogisticsDataSet dataSet)
        {
            if (dataSet == null)
            {
                throw new ArgumentNullException("dataSet");
            }
            if (!dataSet.HasChanges())
            {
                return 0;
            }
            IDbConnection connection = this.Connection;
            if (connection == null)
            {
                throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
            }
            bool flag = false;
            if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
            {
                connection.Close();
            }
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                flag = true;
            }
            IDbTransaction dbTransaction = connection.BeginTransaction();
            if (dbTransaction == null)
            {
                throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
            }
            List<DataRow> dataRows = new List<DataRow>();
            List<DataRow> dataRows1 = new List<DataRow>();
            List<DataAdapter> dataAdapters = new List<DataAdapter>();
            Dictionary<object, IDbConnection> objs = new Dictionary<object, IDbConnection>();
            int num = 0;
            DataSet dataSet1 = null;
            if (this.BackupDataSetBeforeUpdate)
            {
                dataSet1 = new DataSet();
                dataSet1.Merge(dataSet);
            }
            try
            {
                try
                {
                    if (this.UpdateOrder == TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
                    {
                        num = num + this.UpdateUpdatedRows(dataSet, dataRows, dataRows1);
                        num = num + this.UpdateInsertedRows(dataSet, dataRows1);
                    }
                    else
                    {
                        num = num + this.UpdateInsertedRows(dataSet, dataRows1);
                        num = num + this.UpdateUpdatedRows(dataSet, dataRows, dataRows1);
                    }
                    num = num + this.UpdateDeletedRows(dataSet, dataRows);
                    dbTransaction.Commit();
                    if (0 < dataRows1.Count)
                    {
                        DataRow[] dataRowArray = new DataRow[dataRows1.Count];
                        dataRows1.CopyTo(dataRowArray);
                        for (int i = 0; i < (int)dataRowArray.Length; i++)
                        {
                            dataRowArray[i].AcceptChanges();
                        }
                    }
                    if (0 < dataRows.Count)
                    {
                        DataRow[] dataRowArray1 = new DataRow[dataRows.Count];
                        dataRows.CopyTo(dataRowArray1);
                        for (int j = 0; j < (int)dataRowArray1.Length; j++)
                        {
                            dataRowArray1[j].AcceptChanges();
                        }
                    }
                }
                catch (Exception exception1)
                {
                    Exception exception = exception1;
                    dbTransaction.Rollback();
                    if (this.BackupDataSetBeforeUpdate)
                    {
                        dataSet.Clear();
                        dataSet.Merge(dataSet1);
                    }
                    else if (0 < dataRows1.Count)
                    {
                        DataRow[] dataRowArray2 = new DataRow[dataRows1.Count];
                        dataRows1.CopyTo(dataRowArray2);
                        for (int k = 0; k < (int)dataRowArray2.Length; k++)
                        {
                            DataRow dataRow = dataRowArray2[k];
                            dataRow.AcceptChanges();
                            dataRow.SetAdded();
                        }
                    }
                    throw exception;
                }
            }
            finally
            {
                if (flag)
                {
                    connection.Close();
                }
                if (0 < dataAdapters.Count)
                {
                    DataAdapter[] dataAdapterArray = new DataAdapter[dataAdapters.Count];
                    dataAdapters.CopyTo(dataAdapterArray);
                    for (int l = 0; l < (int)dataAdapterArray.Length; l++)
                    {
                        dataAdapterArray[l].AcceptChangesDuringUpdate = true;
                    }
                }
            }
            return num;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateDeletedRows(WizLogisticsDataSet dataSet, List<DataRow> allChangedRows)
        {
            return 0;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateInsertedRows(WizLogisticsDataSet dataSet, List<DataRow> allAddedRows)
        {
            return 0;
        }

        [DebuggerNonUserCode]
        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private int UpdateUpdatedRows(WizLogisticsDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
        {
            return 0;
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        private class SelfReferenceComparer : IComparer<DataRow>
        {
            private DataRelation _relation;

            private int _childFirst;

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            internal SelfReferenceComparer(DataRelation relation, bool childFirst)
            {
                this._relation = relation;
                if (childFirst)
                {
                    this._childFirst = -1;
                    return;
                }
                this._childFirst = 1;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            public int Compare(DataRow row1, DataRow row2)
            {
                if (row1 == row2)
                {
                    return 0;
                }
                if (row1 == null)
                {
                    return -1;
                }
                if (row2 == null)
                {
                    return 1;
                }
                int num = 0;
                DataRow root = this.GetRoot(row1, out num);
                int num1 = 0;
                DataRow dataRow = this.GetRoot(row2, out num1);
                if (root == dataRow)
                {
                    return this._childFirst * num.CompareTo(num1);
                }
                if (root.Table.Rows.IndexOf(root) < dataRow.Table.Rows.IndexOf(dataRow))
                {
                    return -1;
                }
                return 1;
            }

            [DebuggerNonUserCode]
            [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
            private DataRow GetRoot(DataRow row, out int distance)
            {
                DataRow i;
                DataRow dataRow = row;
                distance = 0;
                IDictionary<DataRow, DataRow> dataRows = new Dictionary<DataRow, DataRow>();
                DataRow dataRow1 = row;
                dataRows[dataRow1] = dataRow1;
                for (i = row.GetParentRow(this._relation, DataRowVersion.Default); i != null && !dataRows.ContainsKey(i); i = i.GetParentRow(this._relation, DataRowVersion.Default))
                {
                    distance = distance + 1;
                    dataRow = i;
                    DataRow dataRow2 = i;
                    dataRows[dataRow2] = dataRow2;
                }
                if (distance == 0)
                {
                    dataRows.Clear();
                    DataRow dataRow3 = row;
                    dataRows[dataRow3] = dataRow3;
                    for (i = row.GetParentRow(this._relation, DataRowVersion.Original); i != null && !dataRows.ContainsKey(i); i = i.GetParentRow(this._relation, DataRowVersion.Original))
                    {
                        distance = distance + 1;
                        dataRow = i;
                        DataRow dataRow4 = i;
                        dataRows[dataRow4] = dataRow4;
                    }
                }
                return dataRow;
            }
        }

        [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
        public enum UpdateOrderOption
        {
            InsertUpdateDelete,
            UpdateInsertDelete
        }
    }
}