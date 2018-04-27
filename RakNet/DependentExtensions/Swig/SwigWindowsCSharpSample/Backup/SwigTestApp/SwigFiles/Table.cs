//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class Table : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Table(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Table obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Table() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_Table(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


	public RakNetPageRow GetListHead() {
		return GetListHeadHelper();
	}

  	public void SortTable(SortQuery [] sortQueries, uint numSortQueries, out Row[] arg2) 
 	{
		RakNetListSortQuery sortQueriesList =null;
 		if (sortQueries!=null)
 		{
 			sortQueriesList = new RakNetListSortQuery();
 			int listLen = sortQueries.Length;
 			for (int i = 0; i < listLen; i++)
 			{
      	 		    sortQueriesList.Insert(sortQueries[i], "", 1);
 			}
 		}
 
 		int rowCount= (int)GetRowCount();
 		Row[] rowArray= new Row[rowCount];
 		RakNetListTableRow passVal = new RakNetListTableRow();
 		SortTableHelper(sortQueriesList,numSortQueries,passVal);
 		for (int i=0; i<rowCount;i++)
 		{
 		rowArray[i]=passVal[i];
	 	} 
 		arg2=rowArray;
  	}

 	public void GetCellValueByIndex(uint rowIndex, uint columnIndex, out byte[] outByteArray, out int outputLength) 
         {
 		int returnInt=0;
 		Row row = GetRowByIndex(rowIndex,ref returnInt);
 		int arrayLen=0;
 		if (row!=null)
 		{
 			arrayLen=(int)row.cells[(int)columnIndex].i;
 		}
 		byte[] inOutByteArray = new byte[arrayLen];
 		GetCellValueByIndexHelper(rowIndex,columnIndex,inOutByteArray,out outputLength);
 		outByteArray=inOutByteArray;
 	}

 	public void GetCellValueByIndex(uint rowIndex, uint columnIndex,out string output) 
 	{
 		int returnInt=0;
 		Row row = GetRowByIndex(rowIndex,ref returnInt);
 		int arrayLen=0;
 		if (row!=null)
 		{
 			arrayLen=(int)row.cells[(int)columnIndex].i;
 		}
    		String tmp = new String('c', arrayLen);
 		output=GetCellValueByIndexHelper( rowIndex, columnIndex, tmp);
 	}

       public  void QueryTable(uint[] columnIndicesSubset, uint numColumnSubset, FilterQuery[] inclusionFilters, uint numInclusionFilters, uint[] rowIds, uint numRowIDs, Table result)
 	{
 		RakNetListFilterQuery inclusionFiltersList =null;
 		if (inclusionFiltersList!=null)
 		{
 			inclusionFiltersList = new RakNetListFilterQuery();
 			int listLen = inclusionFilters.Length;
 			for (int i = 0; i < listLen; i++)
 			{
      	 		    inclusionFiltersList.Insert(inclusionFilters[i], "", 1);
 			}
 		}
 		QueryTableHelper(columnIndicesSubset, numColumnSubset, inclusionFiltersList, numInclusionFilters, rowIds, numRowIDs, result);
 	}

 	public uint ColumnIndex(string columnName) {
 	return ColumnIndexHelper(columnName);
 	}
 
  public class Cell : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Cell(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Cell obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Cell() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_Table_Cell(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Cell() : this(RakNetPINVOKE.new_Table_Cell__SWIG_0(), true) {
    }
  
    public Cell(double numericValue, string charValue, SWIGTYPE_p_void ptr, Table.ColumnType type) : this(RakNetPINVOKE.new_Table_Cell__SWIG_1(numericValue, charValue, SWIGTYPE_p_void.getCPtr(ptr), (int)type), true) {
    }
  
    public void SetByType(double numericValue, string charValue, SWIGTYPE_p_void ptr, Table.ColumnType type) {
      RakNetPINVOKE.Table_Cell_SetByType(swigCPtr, numericValue, charValue, SWIGTYPE_p_void.getCPtr(ptr), (int)type);
    }
  
    public void Clear() {
      RakNetPINVOKE.Table_Cell_Clear(swigCPtr);
    }
  
    public void Set(int input) {
      RakNetPINVOKE.Table_Cell_Set__SWIG_0(swigCPtr, input);
    }
  
    public void Set(uint input) {
      RakNetPINVOKE.Table_Cell_Set__SWIG_1(swigCPtr, input);
    }
  
    public void Set(double input) {
      RakNetPINVOKE.Table_Cell_Set__SWIG_2(swigCPtr, input);
    }
  
    public void Set(string input) {
      RakNetPINVOKE.Table_Cell_Set__SWIG_3(swigCPtr, input);
    }
  
    public void Set(string input, int inputLength) {
      RakNetPINVOKE.Table_Cell_Set__SWIG_4(swigCPtr, input, inputLength);
    }
  
    public void SetPtr(SWIGTYPE_p_void p) {
      RakNetPINVOKE.Table_Cell_SetPtr(swigCPtr, SWIGTYPE_p_void.getCPtr(p));
    }
  
    public void Get(out int output) {
      RakNetPINVOKE.Table_Cell_Get__SWIG_0(swigCPtr, out output);
    }
  
    public void Get(out double output) {
      RakNetPINVOKE.Table_Cell_Get__SWIG_1(swigCPtr, out output);
    }
  
    public void Get(string output) {
      RakNetPINVOKE.Table_Cell_Get__SWIG_2(swigCPtr, output);
    }
  
    public void Get(string output, out int outputLength) {
      RakNetPINVOKE.Table_Cell_Get__SWIG_3(swigCPtr, output, out outputLength);
    }
  
    public RakString ToString(Table.ColumnType columnType) {
      RakString ret = new RakString(RakNetPINVOKE.Table_Cell_ToString(swigCPtr, (int)columnType), true);
      return ret;
    }
  
    public Table.Cell CopyData(Table.Cell input) {
      Table.Cell ret = new Table.Cell(RakNetPINVOKE.Table_Cell_CopyData(swigCPtr, Table.Cell.getCPtr(input)), false);
      if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    }
  
    public Cell(Table.Cell input) : this(RakNetPINVOKE.new_Table_Cell__SWIG_2(Table.Cell.getCPtr(input)), true) {
      if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public Table.ColumnType EstimateColumnType() {
      Table.ColumnType ret = (Table.ColumnType)RakNetPINVOKE.Table_Cell_EstimateColumnType(swigCPtr);
      return ret;
    }
  
    public bool isEmpty {
      set {
        RakNetPINVOKE.Table_Cell_isEmpty_set(swigCPtr, value);
      } 
      get {
        bool ret = RakNetPINVOKE.Table_Cell_isEmpty_get(swigCPtr);
        return ret;
      } 
    }
  
    public double i {
      set {
        RakNetPINVOKE.Table_Cell_i_set(swigCPtr, value);
      } 
      get {
        double ret = RakNetPINVOKE.Table_Cell_i_get(swigCPtr);
        return ret;
      } 
    }
  
    public string c {
      set {
        RakNetPINVOKE.Table_Cell_c_set(swigCPtr, value);
      } 
      get {
        string ret = RakNetPINVOKE.Table_Cell_c_get(swigCPtr);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_void ptr {
      set {
        RakNetPINVOKE.Table_Cell_ptr_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.Table_Cell_ptr_get(swigCPtr);
        SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
        return ret;
      } 
    }
  
  }

  public class ColumnDescriptor : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ColumnDescriptor(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ColumnDescriptor obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ColumnDescriptor() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_Table_ColumnDescriptor(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ColumnDescriptor() : this(RakNetPINVOKE.new_Table_ColumnDescriptor__SWIG_0(), true) {
    }
  
    public ColumnDescriptor(string cn, Table.ColumnType ct) : this(RakNetPINVOKE.new_Table_ColumnDescriptor__SWIG_1(cn, (int)ct), true) {
    }
  
    public string columnName {
      set {
        RakNetPINVOKE.Table_ColumnDescriptor_columnName_set(swigCPtr, value);
      } 
      get {
        string ret = RakNetPINVOKE.Table_ColumnDescriptor_columnName_get(swigCPtr);
        return ret;
      } 
    }
  
    public Table.ColumnType columnType {
      set {
        RakNetPINVOKE.Table_ColumnDescriptor_columnType_set(swigCPtr, (int)value);
      } 
      get {
        Table.ColumnType ret = (Table.ColumnType)RakNetPINVOKE.Table_ColumnDescriptor_columnType_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public class Row : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Row(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Row obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Row() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_Table_Row(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t cells {
      set {
        RakNetPINVOKE.Table_Row_cells_set(swigCPtr, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.Table_Row_cells_get(swigCPtr);
        SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t(cPtr, false);
        return ret;
      } 
    }
  
    public void UpdateCell(uint columnIndex, double value) {
      RakNetPINVOKE.Table_Row_UpdateCell__SWIG_0(swigCPtr, columnIndex, value);
    }
  
    public void UpdateCell(uint columnIndex, string str) {
      RakNetPINVOKE.Table_Row_UpdateCell__SWIG_1(swigCPtr, columnIndex, str);
    }
  
    public void UpdateCell(uint columnIndex, int byteLength, string data) {
      RakNetPINVOKE.Table_Row_UpdateCell__SWIG_2(swigCPtr, columnIndex, byteLength, data);
    }
  
    public Row() : this(RakNetPINVOKE.new_Table_Row(), true) {
    }
  
  }

  public class FilterQuery : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal FilterQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FilterQuery obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~FilterQuery() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_Table_FilterQuery(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public FilterQuery() : this(RakNetPINVOKE.new_Table_FilterQuery__SWIG_0(), true) {
    }
  
    public FilterQuery(uint column, Table.Cell cell, Table.FilterQueryType op) : this(RakNetPINVOKE.new_Table_FilterQuery__SWIG_1(column, Table.Cell.getCPtr(cell), (int)op), true) {
    }
  
    public string columnName {
      set {
        RakNetPINVOKE.Table_FilterQuery_columnName_set(swigCPtr, value);
      } 
      get {
        string ret = RakNetPINVOKE.Table_FilterQuery_columnName_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint columnIndex {
      set {
        RakNetPINVOKE.Table_FilterQuery_columnIndex_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.Table_FilterQuery_columnIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public Table.Cell cellValue {
      set {
        RakNetPINVOKE.Table_FilterQuery_cellValue_set(swigCPtr, Table.Cell.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.Table_FilterQuery_cellValue_get(swigCPtr);
        Table.Cell ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Cell(cPtr, false);
        return ret;
      } 
    }
  
    public Table.FilterQueryType operation {
      set {
        RakNetPINVOKE.Table_FilterQuery_operation_set(swigCPtr, (int)value);
      } 
      get {
        Table.FilterQueryType ret = (Table.FilterQueryType)RakNetPINVOKE.Table_FilterQuery_operation_get(swigCPtr);
        return ret;
      } 
    }
  
  }

  public class SortQuery : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal SortQuery(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SortQuery obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~SortQuery() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_Table_SortQuery(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public uint columnIndex {
      set {
        RakNetPINVOKE.Table_SortQuery_columnIndex_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.Table_SortQuery_columnIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public Table.SortQueryType operation {
      set {
        RakNetPINVOKE.Table_SortQuery_operation_set(swigCPtr, (int)value);
      } 
      get {
        Table.SortQueryType ret = (Table.SortQueryType)RakNetPINVOKE.Table_SortQuery_operation_get(swigCPtr);
        return ret;
      } 
    }
  
    public SortQuery() : this(RakNetPINVOKE.new_Table_SortQuery(), true) {
    }
  
  }

  public Table() : this(RakNetPINVOKE.new_Table(), true) {
  }

  public uint AddColumn(string columnName, Table.ColumnType columnType) {
    uint ret = RakNetPINVOKE.Table_AddColumn(swigCPtr, columnName, (int)columnType);
    return ret;
  }

  public void RemoveColumn(uint columnIndex) {
    RakNetPINVOKE.Table_RemoveColumn(swigCPtr, columnIndex);
  }

  public string ColumnName(uint index) {
    string ret = RakNetPINVOKE.Table_ColumnName(swigCPtr, index);
    return ret;
  }

  public Table.ColumnType GetColumnType(uint index) {
    Table.ColumnType ret = (Table.ColumnType)RakNetPINVOKE.Table_GetColumnType(swigCPtr, index);
    return ret;
  }

  public uint GetColumnCount() {
    uint ret = RakNetPINVOKE.Table_GetColumnCount(swigCPtr);
    return ret;
  }

  public uint GetRowCount() {
    uint ret = RakNetPINVOKE.Table_GetRowCount(swigCPtr);
    return ret;
  }

  public Table.Row AddRow(uint rowId) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_AddRow__SWIG_0(swigCPtr, rowId);
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    return ret;
  }

  public Table.Row AddRow(uint rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_t initialCellValues) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_AddRow__SWIG_1(swigCPtr, rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_t.getCPtr(initialCellValues));
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Table.Row AddRow(uint rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t initialCellValues, bool copyCells) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_AddRow__SWIG_2(swigCPtr, rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t.getCPtr(initialCellValues), copyCells);
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Table.Row AddRow(uint rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t initialCellValues) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_AddRow__SWIG_3(swigCPtr, rowId, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Cell_p_t.getCPtr(initialCellValues));
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool RemoveRow(uint rowId) {
    bool ret = RakNetPINVOKE.Table_RemoveRow(swigCPtr, rowId);
    return ret;
  }

  public void RemoveRows(Table tableContainingRowIDs) {
    RakNetPINVOKE.Table_RemoveRows(swigCPtr, Table.getCPtr(tableContainingRowIDs));
  }

  public bool UpdateCell(uint rowId, uint columnIndex, int value) {
    bool ret = RakNetPINVOKE.Table_UpdateCell__SWIG_0(swigCPtr, rowId, columnIndex, value);
    return ret;
  }

  public bool UpdateCell(uint rowId, uint columnIndex, string str) {
    bool ret = RakNetPINVOKE.Table_UpdateCell__SWIG_1(swigCPtr, rowId, columnIndex, str);
    return ret;
  }

  public bool UpdateCellByIndex(uint rowIndex, uint columnIndex, int value) {
    bool ret = RakNetPINVOKE.Table_UpdateCellByIndex__SWIG_0(swigCPtr, rowIndex, columnIndex, value);
    return ret;
  }

  public bool UpdateCellByIndex(uint rowIndex, uint columnIndex, string str) {
    bool ret = RakNetPINVOKE.Table_UpdateCellByIndex__SWIG_1(swigCPtr, rowIndex, columnIndex, str);
    return ret;
  }

  public void GetCellValueByIndex(uint rowIndex, uint columnIndex, out int output) {
    RakNetPINVOKE.Table_GetCellValueByIndex(swigCPtr, rowIndex, columnIndex, out output);
  }

  public Table.Row GetRowByID(uint rowId) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_GetRowByID(swigCPtr, rowId);
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    return ret;
  }

  public Table.Row GetRowByIndex(uint rowIndex, ref int key) {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_GetRowByIndex(swigCPtr, rowIndex, ref key);
    Table.Row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Table.Row(cPtr, false);
    return ret;
  }

  public void Clear() {
    RakNetPINVOKE.Table_Clear(swigCPtr);
  }

  public SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__ColumnDescriptor_t GetColumns() {
    SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__ColumnDescriptor_t ret = new SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__ColumnDescriptor_t(RakNetPINVOKE.Table_GetColumns(swigCPtr), false);
    return ret;
  }

  public RakNetBPlusTreeRow GetRows() {
    RakNetBPlusTreeRow ret = new RakNetBPlusTreeRow(RakNetPINVOKE.Table_GetRows(swigCPtr), false);
    return ret;
  }

  public uint GetAvailableRowId() {
    uint ret = RakNetPINVOKE.Table_GetAvailableRowId(swigCPtr);
    return ret;
  }

  public Table CopyData(Table input) {
    Table ret = new Table(RakNetPINVOKE.Table_CopyData(swigCPtr, Table.getCPtr(input)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private RakNetPageRow GetListHeadHelper() {
    global::System.IntPtr cPtr = RakNetPINVOKE.Table_GetListHeadHelper(swigCPtr);
    RakNetPageRow ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetPageRow(cPtr, false);
    return ret;
  }

  private void SortTableHelper(SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__SortQuery_t sortQueries, uint numSortQueries, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Row_t arg2) {
    RakNetPINVOKE.Table_SortTableHelper(swigCPtr, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__SortQuery_t.getCPtr(sortQueries), numSortQueries, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__Row_t.getCPtr(arg2));
  }

  private void GetCellValueByIndexHelper(uint rowIndex, uint columnIndex, byte[] inOutByteArray, out int outputLength) {
    RakNetPINVOKE.Table_GetCellValueByIndexHelper__SWIG_0(swigCPtr, rowIndex, columnIndex, inOutByteArray, out outputLength);
  }

  private string GetCellValueByIndexHelper(uint rowIndex, uint columnIndex, string output) {
    string ret = RakNetPINVOKE.Table_GetCellValueByIndexHelper__SWIG_1(swigCPtr, rowIndex, columnIndex, output);
    return ret;
  }

  public void PrintColumnHeaders(byte[] inOutByteArray, int byteArrayLength, char columnDelineator) {
    RakNetPINVOKE.Table_PrintColumnHeaders(swigCPtr, inOutByteArray, byteArrayLength, columnDelineator);
  }

  public void PrintRow(byte[] inOutByteArray, int byteArrayLength, char columnDelineator, bool printDelineatorForBinary, Table.Row inputRow) {
    RakNetPINVOKE.Table_PrintRow(swigCPtr, inOutByteArray, byteArrayLength, columnDelineator, printDelineatorForBinary, Table.Row.getCPtr(inputRow));
  }

  private void QueryTableHelper(uint[] columnIndicesSubset, uint numColumnSubset, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__FilterQuery_t inclusionFilters, uint numInclusionFilters, uint[] rowIds, uint numRowIDs, Table result) {
    RakNetPINVOKE.Table_QueryTableHelper(swigCPtr, columnIndicesSubset, numColumnSubset, SWIGTYPE_p_DataStructures__ListT_DataStructures__Table__FilterQuery_t.getCPtr(inclusionFilters), numInclusionFilters, rowIds, numRowIDs, Table.getCPtr(result));
  }

  public bool UpdateCell(uint rowId, uint columnIndex, int byteLength, byte[] inByteArray) {
    bool ret = RakNetPINVOKE.Table_UpdateCell__SWIG_2(swigCPtr, rowId, columnIndex, byteLength, inByteArray);
    return ret;
  }

  public bool UpdateCellByIndex(uint rowIndex, uint columnIndex, int byteLength, byte[] inByteArray) {
    bool ret = RakNetPINVOKE.Table_UpdateCellByIndex__SWIG_2(swigCPtr, rowIndex, columnIndex, byteLength, inByteArray);
    return ret;
  }

  private uint ColumnIndexHelper(string columnName) {
    uint ret = RakNetPINVOKE.Table_ColumnIndexHelper(swigCPtr, columnName);
    return ret;
  }

  public enum ColumnType {
    NUMERIC,
    STRING,
    BINARY,
    POINTER
  }

  public enum FilterQueryType {
    QF_EQUAL,
    QF_NOT_EQUAL,
    QF_GREATER_THAN,
    QF_GREATER_THAN_EQ,
    QF_LESS_THAN,
    QF_LESS_THAN_EQ,
    QF_IS_EMPTY,
    QF_NOT_EMPTY
  }

  public enum SortQueryType {
    QS_INCREASING_ORDER,
    QS_DECREASING_ORDER
  }

}

}
