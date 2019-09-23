// Decompiled with JetBrains decompiler
// Type: WizLogistics.WizLogisticsDataSet
// Assembly: WizLogistics2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9944E73C-68D5-4BC1-954E-5CC5CE300CD2
// Assembly location: \\10.10.10.26\wwwroot\cris\bin\WizLogistics2.dll

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CrisWizLogistics
{
  [DesignerCategory("code")]
  [HelpKeyword("vs.data.DataSet")]
  [ToolboxItem(true)]
  [XmlRoot("WizLogisticsDataSet")]
  [XmlSchemaProvider("GetTypedDataSetSchema")]
  [Serializable]
  public class WizLogisticsDataSet : DataSet
  {
    private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    private WizLogisticsDataSet.ShiftsDataTable tableShifts;
    private WizLogisticsDataSet.RejectedReasonsDataTable tableRejectedReasons;
    private WizLogisticsDataSet.SupplyOrderLinesDataTable tableSupplyOrderLines;
    private WizLogisticsDataSet.SupplyOrdersDataTable tableSupplyOrders;
    private WizLogisticsDataSet.SaleOrderLinesDataTable tableSaleOrderLines;
    private WizLogisticsDataSet.WarehousesDataTable tableWarehouses;
    private WizLogisticsDataSet.RejectedLinesDataTable tableRejectedLines;
    private WizLogisticsDataSet.BatchLinesDataTable tableBatchLines;

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.BatchLinesDataTable BatchLines
    {
      get
      {
        return this.tableBatchLines;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.RejectedLinesDataTable RejectedLines
    {
      get
      {
        return this.tableRejectedLines;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.RejectedReasonsDataTable RejectedReasons
    {
      get
      {
        return this.tableRejectedReasons;
      }
    }

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public new DataRelationCollection Relations
    {
      get
      {
        return base.Relations;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.SaleOrderLinesDataTable SaleOrderLines
    {
      get
      {
        return this.tableSaleOrderLines;
      }
    }

    [Browsable(true)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override SchemaSerializationMode SchemaSerializationMode
    {
      get
      {
        return this._schemaSerializationMode;
      }
      set
      {
        this._schemaSerializationMode = value;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.ShiftsDataTable Shifts
    {
      get
      {
        return this.tableShifts;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.SupplyOrderLinesDataTable SupplyOrderLines
    {
      get
      {
        return this.tableSupplyOrderLines;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.SupplyOrdersDataTable SupplyOrders
    {
      get
      {
        return this.tableSupplyOrders;
      }
    }

    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public new DataTableCollection Tables
    {
      get
      {
        return base.Tables;
      }
    }

    [Browsable(false)]
    [DebuggerNonUserCode]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet.WarehousesDataTable Warehouses
    {
      get
      {
        return this.tableWarehouses;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public WizLogisticsDataSet()
    {
      this.BeginInit();
      this.InitClass();
      CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
      base.Tables.CollectionChanged += changeEventHandler;
      base.Relations.CollectionChanged += changeEventHandler;
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected WizLogisticsDataSet(SerializationInfo info, StreamingContext context)
      : base(info, context, false)
    {
      if (this.IsBinarySerialized(info, context))
      {
        this.InitVars(false);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        this.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
      else
      {
        string s = (string) info.GetValue("XmlSchema", typeof (string));
        if (this.DetermineSchemaSerializationMode(info, context) != SchemaSerializationMode.IncludeSchema)
        {
          this.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
        }
        else
        {
          DataSet dataSet = new DataSet();
          dataSet.ReadXmlSchema((XmlReader) new XmlTextReader((TextReader) new StringReader(s)));
          if (dataSet.Tables["Shifts"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.ShiftsDataTable(dataSet.Tables["Shifts"]));
          if (dataSet.Tables["RejectedReasons"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.RejectedReasonsDataTable(dataSet.Tables["RejectedReasons"]));
          if (dataSet.Tables["SupplyOrderLines"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.SupplyOrderLinesDataTable(dataSet.Tables["SupplyOrderLines"]));
          if (dataSet.Tables["SupplyOrders"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.SupplyOrdersDataTable(dataSet.Tables["SupplyOrders"]));
          if (dataSet.Tables["SaleOrderLines"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.SaleOrderLinesDataTable(dataSet.Tables["SaleOrderLines"]));
          if (dataSet.Tables["Warehouses"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.WarehousesDataTable(dataSet.Tables["Warehouses"]));
          if (dataSet.Tables["RejectedLines"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.RejectedLinesDataTable(dataSet.Tables["RejectedLines"]));
          if (dataSet.Tables["BatchLines"] != null)
            base.Tables.Add((DataTable) new WizLogisticsDataSet.BatchLinesDataTable(dataSet.Tables["BatchLines"]));
          this.DataSetName = dataSet.DataSetName;
          this.Prefix = dataSet.Prefix;
          this.Namespace = dataSet.Namespace;
          this.Locale = dataSet.Locale;
          this.CaseSensitive = dataSet.CaseSensitive;
          this.EnforceConstraints = dataSet.EnforceConstraints;
          this.Merge(dataSet, false, MissingSchemaAction.Add);
          this.InitVars();
        }
        this.GetSerializationData(info, context);
        CollectionChangeEventHandler changeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
        base.Tables.CollectionChanged += changeEventHandler;
        this.Relations.CollectionChanged += changeEventHandler;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public override DataSet Clone()
    {
      WizLogisticsDataSet logisticsDataSet = (WizLogisticsDataSet) base.Clone();
      logisticsDataSet.InitVars();
      int serializationMode = (int) this.SchemaSerializationMode;
      logisticsDataSet.SchemaSerializationMode = (SchemaSerializationMode) serializationMode;
      return (DataSet) logisticsDataSet;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override XmlSchema GetSchemaSerializable()
    {
      MemoryStream memoryStream = new MemoryStream();
      this.WriteXmlSchema((XmlWriter) new XmlTextWriter((Stream) memoryStream, (Encoding) null));
      memoryStream.Position = 0L;
      return XmlSchema.Read((XmlReader) new XmlTextReader((Stream) memoryStream), (ValidationEventHandler) null);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
    {
      WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
      XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
      XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
      XmlSchemaAny xmlSchemaAny = new XmlSchemaAny()
      {
        Namespace = logisticsDataSet.Namespace
      };
      xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny);
      schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
      XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
      if (xs.Contains(schemaSerializable.TargetNamespace))
      {
        MemoryStream memoryStream1 = new MemoryStream();
        MemoryStream memoryStream2 = new MemoryStream();
        try
        {
          schemaSerializable.Write((Stream) memoryStream1);
          foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
          {
            memoryStream2.SetLength(0L);
            MemoryStream memoryStream3 = memoryStream2;
            schema.Write((Stream) memoryStream3);
            if (memoryStream1.Length == memoryStream2.Length)
            {
              memoryStream1.Position = 0L;
              memoryStream2.Position = 0L;
              do
                ;
              while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
              if (memoryStream1.Position == memoryStream1.Length)
                return schemaComplexType;
            }
          }
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
        finally
        {
          if (memoryStream1 != null)
            memoryStream1.Close();
          if (memoryStream2 != null)
            memoryStream2.Close();
        }
      }
      else
      {
        xs.Add(schemaSerializable);
        return schemaComplexType;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void InitClass()
    {
      this.DataSetName = "WizLogisticsDataSet";
      this.Prefix = "";
      this.Namespace = "http://tempuri.org/WizLogisticsDataSet.xsd";
      this.EnforceConstraints = true;
      this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
      this.tableShifts = new WizLogisticsDataSet.ShiftsDataTable();
      base.Tables.Add((DataTable) this.tableShifts);
      this.tableRejectedReasons = new WizLogisticsDataSet.RejectedReasonsDataTable();
      base.Tables.Add((DataTable) this.tableRejectedReasons);
      this.tableSupplyOrderLines = new WizLogisticsDataSet.SupplyOrderLinesDataTable();
      base.Tables.Add((DataTable) this.tableSupplyOrderLines);
      this.tableSupplyOrders = new WizLogisticsDataSet.SupplyOrdersDataTable();
      base.Tables.Add((DataTable) this.tableSupplyOrders);
      this.tableSaleOrderLines = new WizLogisticsDataSet.SaleOrderLinesDataTable();
      base.Tables.Add((DataTable) this.tableSaleOrderLines);
      this.tableWarehouses = new WizLogisticsDataSet.WarehousesDataTable();
      base.Tables.Add((DataTable) this.tableWarehouses);
      this.tableRejectedLines = new WizLogisticsDataSet.RejectedLinesDataTable();
      base.Tables.Add((DataTable) this.tableRejectedLines);
      this.tableBatchLines = new WizLogisticsDataSet.BatchLinesDataTable();
      base.Tables.Add((DataTable) this.tableBatchLines);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void InitializeDerivedDataSet()
    {
      this.BeginInit();
      this.InitClass();
      this.EndInit();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars()
    {
      this.InitVars(true);
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    internal void InitVars(bool initTable)
    {
      this.tableShifts = (WizLogisticsDataSet.ShiftsDataTable) base.Tables["Shifts"];
      if (initTable && this.tableShifts != null)
        this.tableShifts.InitVars();
      this.tableRejectedReasons = (WizLogisticsDataSet.RejectedReasonsDataTable) base.Tables["RejectedReasons"];
      if (initTable && this.tableRejectedReasons != null)
        this.tableRejectedReasons.InitVars();
      this.tableSupplyOrderLines = (WizLogisticsDataSet.SupplyOrderLinesDataTable) base.Tables["SupplyOrderLines"];
      if (initTable && this.tableSupplyOrderLines != null)
        this.tableSupplyOrderLines.InitVars();
      this.tableSupplyOrders = (WizLogisticsDataSet.SupplyOrdersDataTable) base.Tables["SupplyOrders"];
      if (initTable && this.tableSupplyOrders != null)
        this.tableSupplyOrders.InitVars();
      this.tableSaleOrderLines = (WizLogisticsDataSet.SaleOrderLinesDataTable) base.Tables["SaleOrderLines"];
      if (initTable && this.tableSaleOrderLines != null)
        this.tableSaleOrderLines.InitVars();
      this.tableWarehouses = (WizLogisticsDataSet.WarehousesDataTable) base.Tables["Warehouses"];
      if (initTable && this.tableWarehouses != null)
        this.tableWarehouses.InitVars();
      this.tableRejectedLines = (WizLogisticsDataSet.RejectedLinesDataTable) base.Tables["RejectedLines"];
      if (initTable && this.tableRejectedLines != null)
        this.tableRejectedLines.InitVars();
      this.tableBatchLines = (WizLogisticsDataSet.BatchLinesDataTable) base.Tables["BatchLines"];
      if (!initTable || this.tableBatchLines == null)
        return;
      this.tableBatchLines.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override void ReadXmlSerializable(XmlReader reader)
    {
      if (this.DetermineSchemaSerializationMode(reader) != SchemaSerializationMode.IncludeSchema)
      {
        int num = (int) this.ReadXml(reader);
        this.InitVars();
      }
      else
      {
        this.Reset();
        DataSet dataSet = new DataSet();
        int num = (int) dataSet.ReadXml(reader);
        if (dataSet.Tables["Shifts"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.ShiftsDataTable(dataSet.Tables["Shifts"]));
        if (dataSet.Tables["RejectedReasons"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.RejectedReasonsDataTable(dataSet.Tables["RejectedReasons"]));
        if (dataSet.Tables["SupplyOrderLines"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.SupplyOrderLinesDataTable(dataSet.Tables["SupplyOrderLines"]));
        if (dataSet.Tables["SupplyOrders"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.SupplyOrdersDataTable(dataSet.Tables["SupplyOrders"]));
        if (dataSet.Tables["SaleOrderLines"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.SaleOrderLinesDataTable(dataSet.Tables["SaleOrderLines"]));
        if (dataSet.Tables["Warehouses"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.WarehousesDataTable(dataSet.Tables["Warehouses"]));
        if (dataSet.Tables["RejectedLines"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.RejectedLinesDataTable(dataSet.Tables["RejectedLines"]));
        if (dataSet.Tables["BatchLines"] != null)
          base.Tables.Add((DataTable) new WizLogisticsDataSet.BatchLinesDataTable(dataSet.Tables["BatchLines"]));
        this.DataSetName = dataSet.DataSetName;
        this.Prefix = dataSet.Prefix;
        this.Namespace = dataSet.Namespace;
        this.Locale = dataSet.Locale;
        this.CaseSensitive = dataSet.CaseSensitive;
        this.EnforceConstraints = dataSet.EnforceConstraints;
        this.Merge(dataSet, false, MissingSchemaAction.Add);
        this.InitVars();
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private void SchemaChanged(object sender, CollectionChangeEventArgs e)
    {
      if (e.Action != CollectionChangeAction.Remove)
        return;
      this.InitVars();
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeBatchLines()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeRejectedLines()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeRejectedReasons()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeRelations()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeSaleOrderLines()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeShifts()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeSupplyOrderLines()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeSupplyOrders()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    protected override bool ShouldSerializeTables()
    {
      return false;
    }

    [DebuggerNonUserCode]
    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    private bool ShouldSerializeWarehouses()
    {
      return false;
    }

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class BatchLinesDataTable : TypedTableBase<WizLogisticsDataSet.BatchLinesRow>
    {
      private DataColumn columnSaleOrderLineID;
      private DataColumn columnBatchNo;
      private DataColumn columnQuantity;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn BatchNoColumn
      {
        get
        {
          return this.columnBatchNo;
        }
      }

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.BatchLinesRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.BatchLinesRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn QuantityColumn
      {
        get
        {
          return this.columnQuantity;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SaleOrderLineIDColumn
      {
        get
        {
          return this.columnSaleOrderLineID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.BatchLinesRowChangeEventHandler BatchLinesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.BatchLinesRowChangeEventHandler BatchLinesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.BatchLinesRowChangeEventHandler BatchLinesRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.BatchLinesRowChangeEventHandler BatchLinesRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public BatchLinesDataTable()
      {
        this.TableName = "BatchLines";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal BatchLinesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected BatchLinesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddBatchLinesRow(WizLogisticsDataSet.BatchLinesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.BatchLinesRow AddBatchLinesRow(long SaleOrderLineID, string BatchNo, double Quantity)
      {
        WizLogisticsDataSet.BatchLinesRow batchLinesRow = (WizLogisticsDataSet.BatchLinesRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) SaleOrderLineID,
          (object) BatchNo,
          (object) Quantity
        };
        batchLinesRow.ItemArray = objArray;
        this.Rows.Add((DataRow) batchLinesRow);
        return batchLinesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.BatchLinesDataTable batchLinesDataTable = (WizLogisticsDataSet.BatchLinesDataTable) base.Clone();
        batchLinesDataTable.InitVars();
        return (DataTable) batchLinesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.BatchLinesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.BatchLinesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "BatchLinesDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnSaleOrderLineID = new DataColumn("SaleOrderLineID", typeof (long), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSaleOrderLineID);
        this.columnBatchNo = new DataColumn("BatchNo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnBatchNo);
        this.columnQuantity = new DataColumn("Quantity", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnQuantity);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnSaleOrderLineID = this.Columns["SaleOrderLineID"];
        this.columnBatchNo = this.Columns["BatchNo"];
        this.columnQuantity = this.Columns["Quantity"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.BatchLinesRow NewBatchLinesRow()
      {
        return (WizLogisticsDataSet.BatchLinesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.BatchLinesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.BatchLinesRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.BatchLinesRowChanged((object) this, new WizLogisticsDataSet.BatchLinesRowChangeEvent((WizLogisticsDataSet.BatchLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.BatchLinesRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.BatchLinesRowChanging((object) this, new WizLogisticsDataSet.BatchLinesRowChangeEvent((WizLogisticsDataSet.BatchLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.BatchLinesRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.BatchLinesRowDeleted((object) this, new WizLogisticsDataSet.BatchLinesRowChangeEvent((WizLogisticsDataSet.BatchLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.BatchLinesRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.BatchLinesRowDeleting((object) this, new WizLogisticsDataSet.BatchLinesRowChangeEvent((WizLogisticsDataSet.BatchLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveBatchLinesRow(WizLogisticsDataSet.BatchLinesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class BatchLinesRow : DataRow
    {
      private WizLogisticsDataSet.BatchLinesDataTable tableBatchLines;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string BatchNo
      {
        get
        {
          try
          {
            return (string) this[this.tableBatchLines.BatchNoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'BatchNo' in table 'BatchLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableBatchLines.BatchNoColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public double Quantity
      {
        get
        {
          try
          {
            return (double) this[this.tableBatchLines.QuantityColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Quantity' in table 'BatchLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableBatchLines.QuantityColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public long SaleOrderLineID
      {
        get
        {
          try
          {
            return (long) this[this.tableBatchLines.SaleOrderLineIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'SaleOrderLineID' in table 'BatchLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableBatchLines.SaleOrderLineIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal BatchLinesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableBatchLines = (WizLogisticsDataSet.BatchLinesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsBatchNoNull()
      {
        return this.IsNull(this.tableBatchLines.BatchNoColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsQuantityNull()
      {
        return this.IsNull(this.tableBatchLines.QuantityColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsSaleOrderLineIDNull()
      {
        return this.IsNull(this.tableBatchLines.SaleOrderLineIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetBatchNoNull()
      {
        this[this.tableBatchLines.BatchNoColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetQuantityNull()
      {
        this[this.tableBatchLines.QuantityColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetSaleOrderLineIDNull()
      {
        this[this.tableBatchLines.SaleOrderLineIDColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class BatchLinesRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.BatchLinesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.BatchLinesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public BatchLinesRowChangeEvent(WizLogisticsDataSet.BatchLinesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void BatchLinesRowChangeEventHandler(object sender, WizLogisticsDataSet.BatchLinesRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class RejectedLinesDataTable : TypedTableBase<WizLogisticsDataSet.RejectedLinesRow>
    {
      private DataColumn columnRejectedReasonID;
      private DataColumn columnReasonName;
      private DataColumn columnQuantity;

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedLinesRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.RejectedLinesRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn QuantityColumn
      {
        get
        {
          return this.columnQuantity;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ReasonNameColumn
      {
        get
        {
          return this.columnReasonName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn RejectedReasonIDColumn
      {
        get
        {
          return this.columnRejectedReasonID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedLinesRowChangeEventHandler RejectedLinesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedLinesRowChangeEventHandler RejectedLinesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedLinesRowChangeEventHandler RejectedLinesRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedLinesRowChangeEventHandler RejectedLinesRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public RejectedLinesDataTable()
      {
        this.TableName = "RejectedLines";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal RejectedLinesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected RejectedLinesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddRejectedLinesRow(WizLogisticsDataSet.RejectedLinesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedLinesRow AddRejectedLinesRow(short RejectedReasonID, string ReasonName, double Quantity)
      {
        WizLogisticsDataSet.RejectedLinesRow rejectedLinesRow = (WizLogisticsDataSet.RejectedLinesRow) this.NewRow();
        object[] objArray = new object[3]
        {
          (object) RejectedReasonID,
          (object) ReasonName,
          (object) Quantity
        };
        rejectedLinesRow.ItemArray = objArray;
        this.Rows.Add((DataRow) rejectedLinesRow);
        return rejectedLinesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.RejectedLinesDataTable rejectedLinesDataTable = (WizLogisticsDataSet.RejectedLinesDataTable) base.Clone();
        rejectedLinesDataTable.InitVars();
        return (DataTable) rejectedLinesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.RejectedLinesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.RejectedLinesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "RejectedLinesDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnRejectedReasonID = new DataColumn("RejectedReasonID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRejectedReasonID);
        this.columnReasonName = new DataColumn("ReasonName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnReasonName);
        this.columnQuantity = new DataColumn("Quantity", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnQuantity);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnRejectedReasonID = this.Columns["RejectedReasonID"];
        this.columnReasonName = this.Columns["ReasonName"];
        this.columnQuantity = this.Columns["Quantity"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedLinesRow NewRejectedLinesRow()
      {
        return (WizLogisticsDataSet.RejectedLinesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.RejectedLinesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedLinesRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedLinesRowChanged((object) this, new WizLogisticsDataSet.RejectedLinesRowChangeEvent((WizLogisticsDataSet.RejectedLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedLinesRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedLinesRowChanging((object) this, new WizLogisticsDataSet.RejectedLinesRowChangeEvent((WizLogisticsDataSet.RejectedLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedLinesRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedLinesRowDeleted((object) this, new WizLogisticsDataSet.RejectedLinesRowChangeEvent((WizLogisticsDataSet.RejectedLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedLinesRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedLinesRowDeleting((object) this, new WizLogisticsDataSet.RejectedLinesRowChangeEvent((WizLogisticsDataSet.RejectedLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveRejectedLinesRow(WizLogisticsDataSet.RejectedLinesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class RejectedLinesRow : DataRow
    {
      private WizLogisticsDataSet.RejectedLinesDataTable tableRejectedLines;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public double Quantity
      {
        get
        {
          try
          {
            return (double) this[this.tableRejectedLines.QuantityColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Quantity' in table 'RejectedLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableRejectedLines.QuantityColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ReasonName
      {
        get
        {
          try
          {
            return (string) this[this.tableRejectedLines.ReasonNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ReasonName' in table 'RejectedLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableRejectedLines.ReasonNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public short RejectedReasonID
      {
        get
        {
          try
          {
            return (short) this[this.tableRejectedLines.RejectedReasonIDColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'RejectedReasonID' in table 'RejectedLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableRejectedLines.RejectedReasonIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal RejectedLinesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRejectedLines = (WizLogisticsDataSet.RejectedLinesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsQuantityNull()
      {
        return this.IsNull(this.tableRejectedLines.QuantityColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsReasonNameNull()
      {
        return this.IsNull(this.tableRejectedLines.ReasonNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsRejectedReasonIDNull()
      {
        return this.IsNull(this.tableRejectedLines.RejectedReasonIDColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetQuantityNull()
      {
        this[this.tableRejectedLines.QuantityColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetReasonNameNull()
      {
        this[this.tableRejectedLines.ReasonNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetRejectedReasonIDNull()
      {
        this[this.tableRejectedLines.RejectedReasonIDColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class RejectedLinesRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.RejectedLinesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedLinesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public RejectedLinesRowChangeEvent(WizLogisticsDataSet.RejectedLinesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void RejectedLinesRowChangeEventHandler(object sender, WizLogisticsDataSet.RejectedLinesRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class RejectedReasonsDataTable : TypedTableBase<WizLogisticsDataSet.RejectedReasonsRow>
    {
      private DataColumn columnRejectedReasonID;
      private DataColumn columnCode;
      private DataColumn columnName;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedReasonsRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.RejectedReasonsRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NameColumn
      {
        get
        {
          return this.columnName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn RejectedReasonIDColumn
      {
        get
        {
          return this.columnRejectedReasonID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedReasonsRowChangeEventHandler RejectedReasonsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedReasonsRowChangeEventHandler RejectedReasonsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedReasonsRowChangeEventHandler RejectedReasonsRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.RejectedReasonsRowChangeEventHandler RejectedReasonsRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public RejectedReasonsDataTable()
      {
        this.TableName = "RejectedReasons";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal RejectedReasonsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected RejectedReasonsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddRejectedReasonsRow(WizLogisticsDataSet.RejectedReasonsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedReasonsRow AddRejectedReasonsRow(string Code, string Name)
      {
        WizLogisticsDataSet.RejectedReasonsRow rejectedReasonsRow = (WizLogisticsDataSet.RejectedReasonsRow) this.NewRow();
        rejectedReasonsRow.ItemArray = new object[3]
        {
          null,
          (object) Code,
          (object) Name
        };
        this.Rows.Add((DataRow) rejectedReasonsRow);
        return rejectedReasonsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.RejectedReasonsDataTable reasonsDataTable = (WizLogisticsDataSet.RejectedReasonsDataTable) base.Clone();
        reasonsDataTable.InitVars();
        return (DataTable) reasonsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.RejectedReasonsDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedReasonsRow FindByRejectedReasonID(short RejectedReasonID)
      {
        return (WizLogisticsDataSet.RejectedReasonsRow) this.Rows.Find(new object[1]
        {
          (object) RejectedReasonID
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.RejectedReasonsRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "RejectedReasonsDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnRejectedReasonID = new DataColumn("RejectedReasonID", typeof (short), (string) null, MappingType.Element);
        this.Columns.Add(this.columnRejectedReasonID);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnRejectedReasonID
        }, true));
        this.columnRejectedReasonID.AutoIncrement = true;
        this.columnRejectedReasonID.AutoIncrementSeed = -1L;
        this.columnRejectedReasonID.AutoIncrementStep = -1L;
        this.columnRejectedReasonID.AllowDBNull = false;
        this.columnRejectedReasonID.ReadOnly = true;
        this.columnRejectedReasonID.Unique = true;
        this.columnCode.AllowDBNull = false;
        this.columnCode.MaxLength = 10;
        this.columnName.AllowDBNull = false;
        this.columnName.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnRejectedReasonID = this.Columns["RejectedReasonID"];
        this.columnCode = this.Columns["Code"];
        this.columnName = this.Columns["Name"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedReasonsRow NewRejectedReasonsRow()
      {
        return (WizLogisticsDataSet.RejectedReasonsRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.RejectedReasonsRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedReasonsRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedReasonsRowChanged((object) this, new WizLogisticsDataSet.RejectedReasonsRowChangeEvent((WizLogisticsDataSet.RejectedReasonsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedReasonsRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedReasonsRowChanging((object) this, new WizLogisticsDataSet.RejectedReasonsRowChangeEvent((WizLogisticsDataSet.RejectedReasonsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedReasonsRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedReasonsRowDeleted((object) this, new WizLogisticsDataSet.RejectedReasonsRowChangeEvent((WizLogisticsDataSet.RejectedReasonsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.RejectedReasonsRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.RejectedReasonsRowDeleting((object) this, new WizLogisticsDataSet.RejectedReasonsRowChangeEvent((WizLogisticsDataSet.RejectedReasonsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveRejectedReasonsRow(WizLogisticsDataSet.RejectedReasonsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class RejectedReasonsRow : DataRow
    {
      private WizLogisticsDataSet.RejectedReasonsDataTable tableRejectedReasons;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Code
      {
        get
        {
          return (string) this[this.tableRejectedReasons.CodeColumn];
        }
        set
        {
          this[this.tableRejectedReasons.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Name
      {
        get
        {
          return (string) this[this.tableRejectedReasons.NameColumn];
        }
        set
        {
          this[this.tableRejectedReasons.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public short RejectedReasonID
      {
        get
        {
          return (short) this[this.tableRejectedReasons.RejectedReasonIDColumn];
        }
        set
        {
          this[this.tableRejectedReasons.RejectedReasonIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal RejectedReasonsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableRejectedReasons = (WizLogisticsDataSet.RejectedReasonsDataTable) this.Table;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class RejectedReasonsRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.RejectedReasonsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.RejectedReasonsRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public RejectedReasonsRowChangeEvent(WizLogisticsDataSet.RejectedReasonsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void RejectedReasonsRowChangeEventHandler(object sender, WizLogisticsDataSet.RejectedReasonsRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SaleOrderLinesDataTable : TypedTableBase<WizLogisticsDataSet.SaleOrderLinesRow>
    {
      private DataColumn columnItemCode;
      private DataColumn columnItemName;
      private DataColumn columnQuantity;
      private DataColumn columnDeliverQuantity;

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DeliverQuantityColumn
      {
        get
        {
          return this.columnDeliverQuantity;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SaleOrderLinesRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.SaleOrderLinesRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ItemCodeColumn
      {
        get
        {
          return this.columnItemCode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ItemNameColumn
      {
        get
        {
          return this.columnItemName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn QuantityColumn
      {
        get
        {
          return this.columnQuantity;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SaleOrderLinesRowChangeEventHandler SaleOrderLinesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SaleOrderLinesRowChangeEventHandler SaleOrderLinesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SaleOrderLinesRowChangeEventHandler SaleOrderLinesRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SaleOrderLinesRowChangeEventHandler SaleOrderLinesRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SaleOrderLinesDataTable()
      {
        this.TableName = "SaleOrderLines";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SaleOrderLinesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected SaleOrderLinesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddSaleOrderLinesRow(WizLogisticsDataSet.SaleOrderLinesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SaleOrderLinesRow AddSaleOrderLinesRow(string ItemCode, string ItemName, double Quantity, double DeliverQuantity)
      {
        WizLogisticsDataSet.SaleOrderLinesRow saleOrderLinesRow = (WizLogisticsDataSet.SaleOrderLinesRow) this.NewRow();
        object[] objArray = new object[4]
        {
          (object) ItemCode,
          (object) ItemName,
          (object) Quantity,
          (object) DeliverQuantity
        };
        saleOrderLinesRow.ItemArray = objArray;
        this.Rows.Add((DataRow) saleOrderLinesRow);
        return saleOrderLinesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.SaleOrderLinesDataTable orderLinesDataTable = (WizLogisticsDataSet.SaleOrderLinesDataTable) base.Clone();
        orderLinesDataTable.InitVars();
        return (DataTable) orderLinesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.SaleOrderLinesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.SaleOrderLinesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SaleOrderLinesDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnItemCode = new DataColumn("ItemCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnItemCode);
        this.columnItemName = new DataColumn("ItemName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnItemName);
        this.columnQuantity = new DataColumn("Quantity", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnQuantity);
        this.columnDeliverQuantity = new DataColumn("DeliverQuantity", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDeliverQuantity);
        this.columnItemCode.AllowDBNull = false;
        this.columnItemCode.MaxLength = 20;
        this.columnItemName.ReadOnly = true;
        this.columnItemName.MaxLength = 50;
        this.columnQuantity.ReadOnly = true;
        this.columnDeliverQuantity.ReadOnly = true;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnItemCode = this.Columns["ItemCode"];
        this.columnItemName = this.Columns["ItemName"];
        this.columnQuantity = this.Columns["Quantity"];
        this.columnDeliverQuantity = this.Columns["DeliverQuantity"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.SaleOrderLinesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SaleOrderLinesRow NewSaleOrderLinesRow()
      {
        return (WizLogisticsDataSet.SaleOrderLinesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SaleOrderLinesRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SaleOrderLinesRowChanged((object) this, new WizLogisticsDataSet.SaleOrderLinesRowChangeEvent((WizLogisticsDataSet.SaleOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SaleOrderLinesRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SaleOrderLinesRowChanging((object) this, new WizLogisticsDataSet.SaleOrderLinesRowChangeEvent((WizLogisticsDataSet.SaleOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SaleOrderLinesRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SaleOrderLinesRowDeleted((object) this, new WizLogisticsDataSet.SaleOrderLinesRowChangeEvent((WizLogisticsDataSet.SaleOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SaleOrderLinesRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SaleOrderLinesRowDeleting((object) this, new WizLogisticsDataSet.SaleOrderLinesRowChangeEvent((WizLogisticsDataSet.SaleOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveSaleOrderLinesRow(WizLogisticsDataSet.SaleOrderLinesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class SaleOrderLinesRow : DataRow
    {
      private WizLogisticsDataSet.SaleOrderLinesDataTable tableSaleOrderLines;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public double DeliverQuantity
      {
        get
        {
          try
          {
            return (double) this[this.tableSaleOrderLines.DeliverQuantityColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DeliverQuantity' in table 'SaleOrderLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSaleOrderLines.DeliverQuantityColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ItemCode
      {
        get
        {
          return (string) this[this.tableSaleOrderLines.ItemCodeColumn];
        }
        set
        {
          this[this.tableSaleOrderLines.ItemCodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ItemName
      {
        get
        {
          try
          {
            return (string) this[this.tableSaleOrderLines.ItemNameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'ItemName' in table 'SaleOrderLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSaleOrderLines.ItemNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public double Quantity
      {
        get
        {
          try
          {
            return (double) this[this.tableSaleOrderLines.QuantityColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Quantity' in table 'SaleOrderLines' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSaleOrderLines.QuantityColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SaleOrderLinesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSaleOrderLines = (WizLogisticsDataSet.SaleOrderLinesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDeliverQuantityNull()
      {
        return this.IsNull(this.tableSaleOrderLines.DeliverQuantityColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsItemNameNull()
      {
        return this.IsNull(this.tableSaleOrderLines.ItemNameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsQuantityNull()
      {
        return this.IsNull(this.tableSaleOrderLines.QuantityColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDeliverQuantityNull()
      {
        this[this.tableSaleOrderLines.DeliverQuantityColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetItemNameNull()
      {
        this[this.tableSaleOrderLines.ItemNameColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetQuantityNull()
      {
        this[this.tableSaleOrderLines.QuantityColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class SaleOrderLinesRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.SaleOrderLinesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SaleOrderLinesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SaleOrderLinesRowChangeEvent(WizLogisticsDataSet.SaleOrderLinesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void SaleOrderLinesRowChangeEventHandler(object sender, WizLogisticsDataSet.SaleOrderLinesRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class ShiftsDataTable : TypedTableBase<WizLogisticsDataSet.ShiftsRow>
    {
      private DataColumn columnShiftID;
      private DataColumn columnCode;
      private DataColumn columnName;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.ShiftsRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.ShiftsRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NameColumn
      {
        get
        {
          return this.columnName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ShiftIDColumn
      {
        get
        {
          return this.columnShiftID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.ShiftsRowChangeEventHandler ShiftsRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.ShiftsRowChangeEventHandler ShiftsRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.ShiftsRowChangeEventHandler ShiftsRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.ShiftsRowChangeEventHandler ShiftsRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ShiftsDataTable()
      {
        this.TableName = "Shifts";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal ShiftsDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected ShiftsDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddShiftsRow(WizLogisticsDataSet.ShiftsRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.ShiftsRow AddShiftsRow(string Code, string Name)
      {
        WizLogisticsDataSet.ShiftsRow shiftsRow = (WizLogisticsDataSet.ShiftsRow) this.NewRow();
        shiftsRow.ItemArray = new object[3]
        {
          null,
          (object) Code,
          (object) Name
        };
        this.Rows.Add((DataRow) shiftsRow);
        return shiftsRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.ShiftsDataTable shiftsDataTable = (WizLogisticsDataSet.ShiftsDataTable) base.Clone();
        shiftsDataTable.InitVars();
        return (DataTable) shiftsDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.ShiftsDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.ShiftsRow FindByShiftID(int ShiftID)
      {
        return (WizLogisticsDataSet.ShiftsRow) this.Rows.Find(new object[1]
        {
          (object) ShiftID
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.ShiftsRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "ShiftsDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnShiftID = new DataColumn("ShiftID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnShiftID);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnShiftID
        }, true));
        this.columnShiftID.AutoIncrement = true;
        this.columnShiftID.AutoIncrementSeed = -1L;
        this.columnShiftID.AutoIncrementStep = -1L;
        this.columnShiftID.AllowDBNull = false;
        this.columnShiftID.ReadOnly = true;
        this.columnShiftID.Unique = true;
        this.columnCode.AllowDBNull = false;
        this.columnCode.MaxLength = 10;
        this.columnName.AllowDBNull = false;
        this.columnName.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnShiftID = this.Columns["ShiftID"];
        this.columnCode = this.Columns["Code"];
        this.columnName = this.Columns["Name"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.ShiftsRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.ShiftsRow NewShiftsRow()
      {
        return (WizLogisticsDataSet.ShiftsRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.ShiftsRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.ShiftsRowChanged((object) this, new WizLogisticsDataSet.ShiftsRowChangeEvent((WizLogisticsDataSet.ShiftsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.ShiftsRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.ShiftsRowChanging((object) this, new WizLogisticsDataSet.ShiftsRowChangeEvent((WizLogisticsDataSet.ShiftsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.ShiftsRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.ShiftsRowDeleted((object) this, new WizLogisticsDataSet.ShiftsRowChangeEvent((WizLogisticsDataSet.ShiftsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.ShiftsRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.ShiftsRowDeleting((object) this, new WizLogisticsDataSet.ShiftsRowChangeEvent((WizLogisticsDataSet.ShiftsRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveShiftsRow(WizLogisticsDataSet.ShiftsRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class ShiftsRow : DataRow
    {
      private WizLogisticsDataSet.ShiftsDataTable tableShifts;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Code
      {
        get
        {
          return (string) this[this.tableShifts.CodeColumn];
        }
        set
        {
          this[this.tableShifts.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Name
      {
        get
        {
          return (string) this[this.tableShifts.NameColumn];
        }
        set
        {
          this[this.tableShifts.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int ShiftID
      {
        get
        {
          return (int) this[this.tableShifts.ShiftIDColumn];
        }
        set
        {
          this[this.tableShifts.ShiftIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal ShiftsRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableShifts = (WizLogisticsDataSet.ShiftsDataTable) this.Table;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class ShiftsRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.ShiftsRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.ShiftsRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public ShiftsRowChangeEvent(WizLogisticsDataSet.ShiftsRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void ShiftsRowChangeEventHandler(object sender, WizLogisticsDataSet.ShiftsRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SupplyOrderLinesDataTable : TypedTableBase<WizLogisticsDataSet.SupplyOrderLinesRow>
    {
      private DataColumn columnSupplyOrderLineID;
      private DataColumn columnItemCode;
      private DataColumn columnItemName;
      private DataColumn columnQuantity;
      private DataColumn columnMeasureUnit;

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrderLinesRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.SupplyOrderLinesRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ItemCodeColumn
      {
        get
        {
          return this.columnItemCode;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn ItemNameColumn
      {
        get
        {
          return this.columnItemName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn MeasureUnitColumn
      {
        get
        {
          return this.columnMeasureUnit;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn QuantityColumn
      {
        get
        {
          return this.columnQuantity;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SupplyOrderLineIDColumn
      {
        get
        {
          return this.columnSupplyOrderLineID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrderLinesRowChangeEventHandler SupplyOrderLinesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrderLinesRowChangeEventHandler SupplyOrderLinesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrderLinesRowChangeEventHandler SupplyOrderLinesRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrderLinesRowChangeEventHandler SupplyOrderLinesRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SupplyOrderLinesDataTable()
      {
        this.TableName = "SupplyOrderLines";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SupplyOrderLinesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected SupplyOrderLinesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddSupplyOrderLinesRow(WizLogisticsDataSet.SupplyOrderLinesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrderLinesRow AddSupplyOrderLinesRow(string ItemCode, string ItemName, double Quantity, string MeasureUnit)
      {
        WizLogisticsDataSet.SupplyOrderLinesRow supplyOrderLinesRow = (WizLogisticsDataSet.SupplyOrderLinesRow) this.NewRow();
        object[] objArray = new object[5]
        {
          null,
          (object) ItemCode,
          (object) ItemName,
          (object) Quantity,
          (object) MeasureUnit
        };
        supplyOrderLinesRow.ItemArray = objArray;
        this.Rows.Add((DataRow) supplyOrderLinesRow);
        return supplyOrderLinesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.SupplyOrderLinesDataTable orderLinesDataTable = (WizLogisticsDataSet.SupplyOrderLinesDataTable) base.Clone();
        orderLinesDataTable.InitVars();
        return (DataTable) orderLinesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.SupplyOrderLinesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrderLinesRow FindBySupplyOrderLineID(long SupplyOrderLineID)
      {
        return (WizLogisticsDataSet.SupplyOrderLinesRow) this.Rows.Find(new object[1]
        {
          (object) SupplyOrderLineID
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.SupplyOrderLinesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SupplyOrderLinesDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnSupplyOrderLineID = new DataColumn("SupplyOrderLineID", typeof (long), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSupplyOrderLineID);
        this.columnItemCode = new DataColumn("ItemCode", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnItemCode);
        this.columnItemName = new DataColumn("ItemName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnItemName);
        this.columnQuantity = new DataColumn("Quantity", typeof (double), (string) null, MappingType.Element);
        this.Columns.Add(this.columnQuantity);
        this.columnMeasureUnit = new DataColumn("MeasureUnit", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnMeasureUnit);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnSupplyOrderLineID
        }, true));
        this.columnSupplyOrderLineID.AutoIncrement = true;
        this.columnSupplyOrderLineID.AutoIncrementSeed = -1L;
        this.columnSupplyOrderLineID.AutoIncrementStep = -1L;
        this.columnSupplyOrderLineID.AllowDBNull = false;
        this.columnSupplyOrderLineID.ReadOnly = true;
        this.columnSupplyOrderLineID.Unique = true;
        this.columnItemCode.AllowDBNull = false;
        this.columnItemCode.MaxLength = 20;
        this.columnItemName.AllowDBNull = false;
        this.columnItemName.MaxLength = 50;
        this.columnQuantity.AllowDBNull = false;
        this.columnMeasureUnit.AllowDBNull = false;
        this.columnMeasureUnit.MaxLength = 5;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnSupplyOrderLineID = this.Columns["SupplyOrderLineID"];
        this.columnItemCode = this.Columns["ItemCode"];
        this.columnItemName = this.Columns["ItemName"];
        this.columnQuantity = this.Columns["Quantity"];
        this.columnMeasureUnit = this.Columns["MeasureUnit"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.SupplyOrderLinesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrderLinesRow NewSupplyOrderLinesRow()
      {
        return (WizLogisticsDataSet.SupplyOrderLinesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrderLinesRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrderLinesRowChanged((object) this, new WizLogisticsDataSet.SupplyOrderLinesRowChangeEvent((WizLogisticsDataSet.SupplyOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrderLinesRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrderLinesRowChanging((object) this, new WizLogisticsDataSet.SupplyOrderLinesRowChangeEvent((WizLogisticsDataSet.SupplyOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrderLinesRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrderLinesRowDeleted((object) this, new WizLogisticsDataSet.SupplyOrderLinesRowChangeEvent((WizLogisticsDataSet.SupplyOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrderLinesRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrderLinesRowDeleting((object) this, new WizLogisticsDataSet.SupplyOrderLinesRowChangeEvent((WizLogisticsDataSet.SupplyOrderLinesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveSupplyOrderLinesRow(WizLogisticsDataSet.SupplyOrderLinesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class SupplyOrderLinesRow : DataRow
    {
      private WizLogisticsDataSet.SupplyOrderLinesDataTable tableSupplyOrderLines;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ItemCode
      {
        get
        {
          return (string) this[this.tableSupplyOrderLines.ItemCodeColumn];
        }
        set
        {
          this[this.tableSupplyOrderLines.ItemCodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string ItemName
      {
        get
        {
          return (string) this[this.tableSupplyOrderLines.ItemNameColumn];
        }
        set
        {
          this[this.tableSupplyOrderLines.ItemNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string MeasureUnit
      {
        get
        {
          return (string) this[this.tableSupplyOrderLines.MeasureUnitColumn];
        }
        set
        {
          this[this.tableSupplyOrderLines.MeasureUnitColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public double Quantity
      {
        get
        {
          return (double) this[this.tableSupplyOrderLines.QuantityColumn];
        }
        set
        {
          this[this.tableSupplyOrderLines.QuantityColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public long SupplyOrderLineID
      {
        get
        {
          return (long) this[this.tableSupplyOrderLines.SupplyOrderLineIDColumn];
        }
        set
        {
          this[this.tableSupplyOrderLines.SupplyOrderLineIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SupplyOrderLinesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSupplyOrderLines = (WizLogisticsDataSet.SupplyOrderLinesDataTable) this.Table;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class SupplyOrderLinesRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.SupplyOrderLinesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrderLinesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SupplyOrderLinesRowChangeEvent(WizLogisticsDataSet.SupplyOrderLinesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void SupplyOrderLinesRowChangeEventHandler(object sender, WizLogisticsDataSet.SupplyOrderLinesRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class SupplyOrdersDataTable : TypedTableBase<WizLogisticsDataSet.SupplyOrdersRow>
    {
      private DataColumn columnSupplyOrderID;
      private DataColumn columnDocInfo;
      private DataColumn columnSupplierName;

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn DocInfoColumn
      {
        get
        {
          return this.columnDocInfo;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrdersRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.SupplyOrdersRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SupplierNameColumn
      {
        get
        {
          return this.columnSupplierName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn SupplyOrderIDColumn
      {
        get
        {
          return this.columnSupplyOrderID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrdersRowChangeEventHandler SupplyOrdersRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrdersRowChangeEventHandler SupplyOrdersRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrdersRowChangeEventHandler SupplyOrdersRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.SupplyOrdersRowChangeEventHandler SupplyOrdersRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SupplyOrdersDataTable()
      {
        this.TableName = "SupplyOrders";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SupplyOrdersDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected SupplyOrdersDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddSupplyOrdersRow(WizLogisticsDataSet.SupplyOrdersRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrdersRow AddSupplyOrdersRow(string DocInfo, string SupplierName)
      {
        WizLogisticsDataSet.SupplyOrdersRow supplyOrdersRow = (WizLogisticsDataSet.SupplyOrdersRow) this.NewRow();
        supplyOrdersRow.ItemArray = new object[3]
        {
          null,
          (object) DocInfo,
          (object) SupplierName
        };
        this.Rows.Add((DataRow) supplyOrdersRow);
        return supplyOrdersRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.SupplyOrdersDataTable supplyOrdersDataTable = (WizLogisticsDataSet.SupplyOrdersDataTable) base.Clone();
        supplyOrdersDataTable.InitVars();
        return (DataTable) supplyOrdersDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.SupplyOrdersDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrdersRow FindBySupplyOrderID(long SupplyOrderID)
      {
        return (WizLogisticsDataSet.SupplyOrdersRow) this.Rows.Find(new object[1]
        {
          (object) SupplyOrderID
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.SupplyOrdersRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "SupplyOrdersDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnSupplyOrderID = new DataColumn("SupplyOrderID", typeof (long), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSupplyOrderID);
        this.columnDocInfo = new DataColumn("DocInfo", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnDocInfo);
        this.columnSupplierName = new DataColumn("SupplierName", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnSupplierName);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnSupplyOrderID
        }, true));
        this.columnSupplyOrderID.AutoIncrement = true;
        this.columnSupplyOrderID.AutoIncrementSeed = -1L;
        this.columnSupplyOrderID.AutoIncrementStep = -1L;
        this.columnSupplyOrderID.AllowDBNull = false;
        this.columnSupplyOrderID.ReadOnly = true;
        this.columnSupplyOrderID.Unique = true;
        this.columnDocInfo.ReadOnly = true;
        this.columnDocInfo.MaxLength = 31;
        this.columnSupplierName.AllowDBNull = false;
        this.columnSupplierName.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnSupplyOrderID = this.Columns["SupplyOrderID"];
        this.columnDocInfo = this.Columns["DocInfo"];
        this.columnSupplierName = this.Columns["SupplierName"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.SupplyOrdersRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrdersRow NewSupplyOrdersRow()
      {
        return (WizLogisticsDataSet.SupplyOrdersRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrdersRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrdersRowChanged((object) this, new WizLogisticsDataSet.SupplyOrdersRowChangeEvent((WizLogisticsDataSet.SupplyOrdersRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrdersRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrdersRowChanging((object) this, new WizLogisticsDataSet.SupplyOrdersRowChangeEvent((WizLogisticsDataSet.SupplyOrdersRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrdersRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrdersRowDeleted((object) this, new WizLogisticsDataSet.SupplyOrdersRowChangeEvent((WizLogisticsDataSet.SupplyOrdersRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.SupplyOrdersRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.SupplyOrdersRowDeleting((object) this, new WizLogisticsDataSet.SupplyOrdersRowChangeEvent((WizLogisticsDataSet.SupplyOrdersRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveSupplyOrdersRow(WizLogisticsDataSet.SupplyOrdersRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class SupplyOrdersRow : DataRow
    {
      private WizLogisticsDataSet.SupplyOrdersDataTable tableSupplyOrders;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string DocInfo
      {
        get
        {
          try
          {
            return (string) this[this.tableSupplyOrders.DocInfoColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'DocInfo' in table 'SupplyOrders' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableSupplyOrders.DocInfoColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string SupplierName
      {
        get
        {
          return (string) this[this.tableSupplyOrders.SupplierNameColumn];
        }
        set
        {
          this[this.tableSupplyOrders.SupplierNameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public long SupplyOrderID
      {
        get
        {
          return (long) this[this.tableSupplyOrders.SupplyOrderIDColumn];
        }
        set
        {
          this[this.tableSupplyOrders.SupplyOrderIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal SupplyOrdersRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableSupplyOrders = (WizLogisticsDataSet.SupplyOrdersDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsDocInfoNull()
      {
        return this.IsNull(this.tableSupplyOrders.DocInfoColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetDocInfoNull()
      {
        this[this.tableSupplyOrders.DocInfoColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class SupplyOrdersRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.SupplyOrdersRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.SupplyOrdersRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public SupplyOrdersRowChangeEvent(WizLogisticsDataSet.SupplyOrdersRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void SupplyOrdersRowChangeEventHandler(object sender, WizLogisticsDataSet.SupplyOrdersRowChangeEvent e);

    [XmlSchemaProvider("GetTypedTableSchema")]
    [Serializable]
    public class WarehousesDataTable : TypedTableBase<WizLogisticsDataSet.WarehousesRow>
    {
      private DataColumn columnWarehouseID;
      private DataColumn columnCode;
      private DataColumn columnName;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn CodeColumn
      {
        get
        {
          return this.columnCode;
        }
      }

      [Browsable(false)]
      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int Count
      {
        get
        {
          return this.Rows.Count;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.WarehousesRow this[int index]
      {
        get
        {
          return (WizLogisticsDataSet.WarehousesRow) this.Rows[index];
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn NameColumn
      {
        get
        {
          return this.columnName;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataColumn WarehouseIDColumn
      {
        get
        {
          return this.columnWarehouseID;
        }
      }

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.WarehousesRowChangeEventHandler WarehousesRowChanged;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.WarehousesRowChangeEventHandler WarehousesRowChanging;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.WarehousesRowChangeEventHandler WarehousesRowDeleted;

      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public event WizLogisticsDataSet.WarehousesRowChangeEventHandler WarehousesRowDeleting;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WarehousesDataTable()
      {
        this.TableName = "Warehouses";
        this.BeginInit();
        this.InitClass();
        this.EndInit();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal WarehousesDataTable(DataTable table)
      {
        this.TableName = table.TableName;
        if (table.CaseSensitive != table.DataSet.CaseSensitive)
          this.CaseSensitive = table.CaseSensitive;
        if (table.Locale.ToString() != table.DataSet.Locale.ToString())
          this.Locale = table.Locale;
        if (table.Namespace != table.DataSet.Namespace)
          this.Namespace = table.Namespace;
        this.Prefix = table.Prefix;
        this.MinimumCapacity = table.MinimumCapacity;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected WarehousesDataTable(SerializationInfo info, StreamingContext context)
        : base(info, context)
      {
        this.InitVars();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void AddWarehousesRow(WizLogisticsDataSet.WarehousesRow row)
      {
        this.Rows.Add((DataRow) row);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.WarehousesRow AddWarehousesRow(string Code, string Name)
      {
        WizLogisticsDataSet.WarehousesRow warehousesRow = (WizLogisticsDataSet.WarehousesRow) this.NewRow();
        warehousesRow.ItemArray = new object[3]
        {
          null,
          (object) Code,
          (object) Name
        };
        this.Rows.Add((DataRow) warehousesRow);
        return warehousesRow;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public override DataTable Clone()
      {
        WizLogisticsDataSet.WarehousesDataTable warehousesDataTable = (WizLogisticsDataSet.WarehousesDataTable) base.Clone();
        warehousesDataTable.InitVars();
        return (DataTable) warehousesDataTable;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataTable CreateInstance()
      {
        return (DataTable) new WizLogisticsDataSet.WarehousesDataTable();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.WarehousesRow FindByWarehouseID(int WarehouseID)
      {
        return (WizLogisticsDataSet.WarehousesRow) this.Rows.Find(new object[1]
        {
          (object) WarehouseID
        });
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override Type GetRowType()
      {
        return typeof (WizLogisticsDataSet.WarehousesRow);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
      {
        XmlSchemaComplexType schemaComplexType = new XmlSchemaComplexType();
        XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
        WizLogisticsDataSet logisticsDataSet = new WizLogisticsDataSet();
        XmlSchemaAny xmlSchemaAny1 = new XmlSchemaAny();
        xmlSchemaAny1.Namespace = "http://www.w3.org/2001/XMLSchema";
        Decimal num1 = new Decimal(0);
        xmlSchemaAny1.MinOccurs = num1;
        Decimal num2 = new Decimal(-1, -1, -1, false, (byte) 0);
        xmlSchemaAny1.MaxOccurs = num2;
        int num3 = 2;
        xmlSchemaAny1.ProcessContents = (XmlSchemaContentProcessing) num3;
        XmlSchemaAny xmlSchemaAny2 = xmlSchemaAny1;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny2);
        XmlSchemaAny xmlSchemaAny3 = new XmlSchemaAny();
        xmlSchemaAny3.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
        Decimal num4 = new Decimal(1);
        xmlSchemaAny3.MinOccurs = num4;
        int num5 = 2;
        xmlSchemaAny3.ProcessContents = (XmlSchemaContentProcessing) num5;
        XmlSchemaAny xmlSchemaAny4 = xmlSchemaAny3;
        xmlSchemaSequence.Items.Add((XmlSchemaObject) xmlSchemaAny4);
        XmlSchemaAttribute xmlSchemaAttribute1 = new XmlSchemaAttribute();
        xmlSchemaAttribute1.Name = "namespace";
        string str = logisticsDataSet.Namespace;
        xmlSchemaAttribute1.FixedValue = str;
        XmlSchemaAttribute xmlSchemaAttribute2 = xmlSchemaAttribute1;
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute2);
        XmlSchemaAttribute xmlSchemaAttribute3 = new XmlSchemaAttribute()
        {
          Name = "tableTypeName",
          FixedValue = "WarehousesDataTable"
        };
        schemaComplexType.Attributes.Add((XmlSchemaObject) xmlSchemaAttribute3);
        schemaComplexType.Particle = (XmlSchemaParticle) xmlSchemaSequence;
        XmlSchema schemaSerializable = logisticsDataSet.GetSchemaSerializable();
        if (xs.Contains(schemaSerializable.TargetNamespace))
        {
          MemoryStream memoryStream1 = new MemoryStream();
          MemoryStream memoryStream2 = new MemoryStream();
          try
          {
            schemaSerializable.Write((Stream) memoryStream1);
            foreach (XmlSchema schema in (IEnumerable) xs.Schemas(schemaSerializable.TargetNamespace))
            {
              memoryStream2.SetLength(0L);
              MemoryStream memoryStream3 = memoryStream2;
              schema.Write((Stream) memoryStream3);
              if (memoryStream1.Length == memoryStream2.Length)
              {
                memoryStream1.Position = 0L;
                memoryStream2.Position = 0L;
                do
                  ;
                while (memoryStream1.Position != memoryStream1.Length && memoryStream1.ReadByte() == memoryStream2.ReadByte());
                if (memoryStream1.Position == memoryStream1.Length)
                  return schemaComplexType;
              }
            }
            xs.Add(schemaSerializable);
            return schemaComplexType;
          }
          finally
          {
            if (memoryStream1 != null)
              memoryStream1.Close();
            if (memoryStream2 != null)
              memoryStream2.Close();
          }
        }
        else
        {
          xs.Add(schemaSerializable);
          return schemaComplexType;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      private void InitClass()
      {
        this.columnWarehouseID = new DataColumn("WarehouseID", typeof (int), (string) null, MappingType.Element);
        this.Columns.Add(this.columnWarehouseID);
        this.columnCode = new DataColumn("Code", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnCode);
        this.columnName = new DataColumn("Name", typeof (string), (string) null, MappingType.Element);
        this.Columns.Add(this.columnName);
        this.Constraints.Add((Constraint) new UniqueConstraint("Constraint1", new DataColumn[1]
        {
          this.columnWarehouseID
        }, true));
        this.columnWarehouseID.AutoIncrement = true;
        this.columnWarehouseID.AutoIncrementSeed = -1L;
        this.columnWarehouseID.AutoIncrementStep = -1L;
        this.columnWarehouseID.AllowDBNull = false;
        this.columnWarehouseID.ReadOnly = true;
        this.columnWarehouseID.Unique = true;
        this.columnCode.ReadOnly = true;
        this.columnCode.MaxLength = 10;
        this.columnName.ReadOnly = true;
        this.columnName.MaxLength = 50;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal void InitVars()
      {
        this.columnWarehouseID = this.Columns["WarehouseID"];
        this.columnCode = this.Columns["Code"];
        this.columnName = this.Columns["Name"];
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
      {
        return (DataRow) new WizLogisticsDataSet.WarehousesRow(builder);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.WarehousesRow NewWarehousesRow()
      {
        return (WizLogisticsDataSet.WarehousesRow) this.NewRow();
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanged(DataRowChangeEventArgs e)
      {
        base.OnRowChanged(e);
        // ISSUE: reference to a compiler-generated field
        if (this.WarehousesRowChanged == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.WarehousesRowChanged((object) this, new WizLogisticsDataSet.WarehousesRowChangeEvent((WizLogisticsDataSet.WarehousesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowChanging(DataRowChangeEventArgs e)
      {
        base.OnRowChanging(e);
        // ISSUE: reference to a compiler-generated field
        if (this.WarehousesRowChanging == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.WarehousesRowChanging((object) this, new WizLogisticsDataSet.WarehousesRowChangeEvent((WizLogisticsDataSet.WarehousesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleted(DataRowChangeEventArgs e)
      {
        base.OnRowDeleted(e);
        // ISSUE: reference to a compiler-generated field
        if (this.WarehousesRowDeleted == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.WarehousesRowDeleted((object) this, new WizLogisticsDataSet.WarehousesRowChangeEvent((WizLogisticsDataSet.WarehousesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      protected override void OnRowDeleting(DataRowChangeEventArgs e)
      {
        base.OnRowDeleting(e);
        // ISSUE: reference to a compiler-generated field
        if (this.WarehousesRowDeleting == null)
          return;
        // ISSUE: reference to a compiler-generated field
        this.WarehousesRowDeleting((object) this, new WizLogisticsDataSet.WarehousesRowChangeEvent((WizLogisticsDataSet.WarehousesRow) e.Row, e.Action));
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void RemoveWarehousesRow(WizLogisticsDataSet.WarehousesRow row)
      {
        this.Rows.Remove((DataRow) row);
      }
    }

    public class WarehousesRow : DataRow
    {
      private WizLogisticsDataSet.WarehousesDataTable tableWarehouses;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Code
      {
        get
        {
          try
          {
            return (string) this[this.tableWarehouses.CodeColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Code' in table 'Warehouses' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableWarehouses.CodeColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public string Name
      {
        get
        {
          try
          {
            return (string) this[this.tableWarehouses.NameColumn];
          }
          catch (InvalidCastException ex)
          {
            throw new StrongTypingException("The value for column 'Name' in table 'Warehouses' is DBNull.", (Exception) ex);
          }
        }
        set
        {
          this[this.tableWarehouses.NameColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public int WarehouseID
      {
        get
        {
          return (int) this[this.tableWarehouses.WarehouseIDColumn];
        }
        set
        {
          this[this.tableWarehouses.WarehouseIDColumn] = (object) value;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      internal WarehousesRow(DataRowBuilder rb)
        : base(rb)
      {
        this.tableWarehouses = (WizLogisticsDataSet.WarehousesDataTable) this.Table;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsCodeNull()
      {
        return this.IsNull(this.tableWarehouses.CodeColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public bool IsNameNull()
      {
        return this.IsNull(this.tableWarehouses.NameColumn);
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetCodeNull()
      {
        this[this.tableWarehouses.CodeColumn] = Convert.DBNull;
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public void SetNameNull()
      {
        this[this.tableWarehouses.NameColumn] = Convert.DBNull;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public class WarehousesRowChangeEvent : EventArgs
    {
      private WizLogisticsDataSet.WarehousesRow eventRow;
      private DataRowAction eventAction;

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public DataRowAction Action
      {
        get
        {
          return this.eventAction;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WizLogisticsDataSet.WarehousesRow Row
      {
        get
        {
          return this.eventRow;
        }
      }

      [DebuggerNonUserCode]
      [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
      public WarehousesRowChangeEvent(WizLogisticsDataSet.WarehousesRow row, DataRowAction action)
      {
        this.eventRow = row;
        this.eventAction = action;
      }
    }

    [GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
    public delegate void WarehousesRowChangeEventHandler(object sender, WizLogisticsDataSet.WarehousesRowChangeEvent e);
  }
}
