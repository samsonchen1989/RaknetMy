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

public class FileListTransferCBInterface : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileListTransferCBInterface(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileListTransferCBInterface obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileListTransferCBInterface() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FileListTransferCBInterface(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public class OnFileStruct : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal OnFileStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OnFileStruct obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~OnFileStruct() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FileListTransferCBInterface_OnFileStruct(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public uint fileIndex {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_fileIndex_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_fileIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public string fileName {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_fileName_set(swigCPtr, value);
      } 
      get {
        string ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_fileName_get(swigCPtr);
        return ret;
      } 
    }
  
    public byte[] fileData {
  	set 
  	{
  	    	fileDataCache=value;
  		fileDataIsCached = true;
  		SetFileData (value, value.Length);    
  	}
  
          get
          {
              byte[] returnArray;
              if (!fileDataIsCached)
              {
                  IntPtr cPtr = RakNetPINVOKE.OnFileStruct_fileData_get (swigCPtr);
                  int len = (int) byteLengthOfThisFile;
  		if (len<=0)
  		{
  			return null;
  		}
                  returnArray = new byte[len];
                  byte[] marshalArray = new byte[len];
                  Marshal.Copy(cPtr, marshalArray, 0, len);
                  marshalArray.CopyTo(returnArray, 0);
                  fileDataCache = returnArray;
                  fileDataIsCached = true;
              }
              else
              {
                  returnArray = fileDataCache;
              }
              return returnArray;
          }
   
    }
  
    public uint byteLengthOfThisFile {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_byteLengthOfThisFile_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_byteLengthOfThisFile_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint bytesDownloadedForThisFile {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_bytesDownloadedForThisFile_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_bytesDownloadedForThisFile_get(swigCPtr);
        return ret;
      } 
    }
  
    public ushort setID {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_setID_set(swigCPtr, value);
      } 
      get {
        ushort ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_setID_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint numberOfFilesInThisSet {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_numberOfFilesInThisSet_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_numberOfFilesInThisSet_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint byteLengthOfThisSet {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_byteLengthOfThisSet_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_byteLengthOfThisSet_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint bytesDownloadedForThisSet {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_bytesDownloadedForThisSet_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_bytesDownloadedForThisSet_get(swigCPtr);
        return ret;
      } 
    }
  
    public FileListNodeContext context {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_context_set(swigCPtr, FileListNodeContext.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_context_get(swigCPtr);
        FileListNodeContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new FileListNodeContext(cPtr, false);
        return ret;
      } 
    }
  
    public SystemAddress senderSystemAddress {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_senderSystemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_senderSystemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public RakNetGUID senderGuid {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_senderGuid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_OnFileStruct_senderGuid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public OnFileStruct() : this(RakNetPINVOKE.new_FileListTransferCBInterface_OnFileStruct(), true) {
    }
  
  }

  public class FileProgressStruct : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal FileProgressStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileProgressStruct obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~FileProgressStruct() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FileListTransferCBInterface_FileProgressStruct(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public FileListTransferCBInterface.OnFileStruct onFileStruct {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_onFileStruct_set(swigCPtr, FileListTransferCBInterface.OnFileStruct.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_onFileStruct_get(swigCPtr);
        FileListTransferCBInterface.OnFileStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new FileListTransferCBInterface.OnFileStruct(cPtr, false);
        return ret;
      } 
    }
  
    public uint partCount {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_partCount_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_partCount_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint partTotal {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_partTotal_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_partTotal_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint dataChunkLength {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_dataChunkLength_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_dataChunkLength_get(swigCPtr);
        return ret;
      } 
    }
  
    public byte[] firstDataChunk {
  	set 
  	{
  	    	firstDataChunkCache=value;
  		firstDataChunkIsCached = true;
  		SetFirstDataChunk (value, value.Length);    
  	}
  
          get
          {
              byte[] returnArray;
              if (!firstDataChunkIsCached)
              {
                  IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_firstDataChunk_get (swigCPtr);
                  int len = (int) dataChunkLength;
  		if (len<=0)
  		{
  			return null;
  		}
                  returnArray = new byte[len];
                  byte[] marshalArray = new byte[len];
                  Marshal.Copy(cPtr, marshalArray, 0, len);
                  marshalArray.CopyTo(returnArray, 0);
                  firstDataChunkCache = returnArray;
                  firstDataChunkIsCached = true;
              }
              else
              {
                  returnArray = firstDataChunkCache;
              }
              return returnArray;
          }
   
    }
  
    public byte[] iriDataChunk {
  	set 
  	{
  	    	iriDataChunkCache=value;
  		iriDataChunkIsCached = true;
  		SetIriDataChunk (value, value.Length);    
  	}
  
          get
          {
              byte[] returnArray;
              if (!iriDataChunkIsCached)
              {
                  IntPtr cPtr = RakNetPINVOKE.FileProgressStruct_iriDataChunk_get (swigCPtr);
                  int len = (int) dataChunkLength;
  		if (len<=0)
  		{
  			return null;
  		}
                  returnArray = new byte[len];
                  byte[] marshalArray = new byte[len];
                  Marshal.Copy(cPtr, marshalArray, 0, len);
                  marshalArray.CopyTo(returnArray, 0);
                  iriDataChunkCache = returnArray;
                  iriDataChunkIsCached = true;
              }
              else
              {
                  returnArray = iriDataChunkCache;
              }
              return returnArray;
          }
   
    }
  
    public uint iriWriteOffset {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_iriWriteOffset_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_iriWriteOffset_get(swigCPtr);
        return ret;
      } 
    }
  
    public SystemAddress senderSystemAddress {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_senderSystemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_senderSystemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public RakNetGUID senderGuid {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_senderGuid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_senderGuid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public bool allocateIrIDataChunkAutomatically {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_allocateIrIDataChunkAutomatically_set(swigCPtr, value);
      } 
      get {
        bool ret = RakNetPINVOKE.FileListTransferCBInterface_FileProgressStruct_allocateIrIDataChunkAutomatically_get(swigCPtr);
        return ret;
      } 
    }
  
    public FileProgressStruct() : this(RakNetPINVOKE.new_FileListTransferCBInterface_FileProgressStruct(), true) {
    }
  
  }

  public class DownloadCompleteStruct : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal DownloadCompleteStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DownloadCompleteStruct obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~DownloadCompleteStruct() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FileListTransferCBInterface_DownloadCompleteStruct(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ushort setID {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_setID_set(swigCPtr, value);
      } 
      get {
        ushort ret = RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_setID_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint numberOfFilesInThisSet {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_numberOfFilesInThisSet_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_numberOfFilesInThisSet_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint byteLengthOfThisSet {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_byteLengthOfThisSet_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_byteLengthOfThisSet_get(swigCPtr);
        return ret;
      } 
    }
  
    public SystemAddress senderSystemAddress {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_senderSystemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_senderSystemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public RakNetGUID senderGuid {
      set {
        RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_senderGuid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FileListTransferCBInterface_DownloadCompleteStruct_senderGuid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public DownloadCompleteStruct() : this(RakNetPINVOKE.new_FileListTransferCBInterface_DownloadCompleteStruct(), true) {
    }
  
  }

  public FileListTransferCBInterface() : this(RakNetPINVOKE.new_FileListTransferCBInterface(), true) {
    SwigDirectorConnect();
  }

  public virtual bool OnFile(FileListTransferCBInterface.OnFileStruct onFileStruct) {
    bool ret = RakNetPINVOKE.FileListTransferCBInterface_OnFile(swigCPtr, FileListTransferCBInterface.OnFileStruct.getCPtr(onFileStruct));
    return ret;
  }

  public virtual void OnFileProgress(FileListTransferCBInterface.FileProgressStruct fps) {
    RakNetPINVOKE.FileListTransferCBInterface_OnFileProgress(swigCPtr, FileListTransferCBInterface.FileProgressStruct.getCPtr(fps));
  }

  public virtual bool Update() {
    bool ret = (SwigDerivedClassHasMethod("Update", swigMethodTypes2) ? RakNetPINVOKE.FileListTransferCBInterface_UpdateSwigExplicitFileListTransferCBInterface(swigCPtr) : RakNetPINVOKE.FileListTransferCBInterface_Update(swigCPtr));
    return ret;
  }

  public virtual bool OnDownloadComplete(FileListTransferCBInterface.DownloadCompleteStruct dcs) {
    bool ret = (SwigDerivedClassHasMethod("OnDownloadComplete", swigMethodTypes3) ? RakNetPINVOKE.FileListTransferCBInterface_OnDownloadCompleteSwigExplicitFileListTransferCBInterface(swigCPtr, FileListTransferCBInterface.DownloadCompleteStruct.getCPtr(dcs)) : RakNetPINVOKE.FileListTransferCBInterface_OnDownloadComplete(swigCPtr, FileListTransferCBInterface.DownloadCompleteStruct.getCPtr(dcs)));
    return ret;
  }

  public virtual void OnDereference() {
    if (SwigDerivedClassHasMethod("OnDereference", swigMethodTypes4)) RakNetPINVOKE.FileListTransferCBInterface_OnDereferenceSwigExplicitFileListTransferCBInterface(swigCPtr); else RakNetPINVOKE.FileListTransferCBInterface_OnDereference(swigCPtr);
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("OnFile", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateFileListTransferCBInterface_0(SwigDirectorOnFile);
    if (SwigDerivedClassHasMethod("OnFileProgress", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateFileListTransferCBInterface_1(SwigDirectorOnFileProgress);
    if (SwigDerivedClassHasMethod("Update", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateFileListTransferCBInterface_2(SwigDirectorUpdate);
    if (SwigDerivedClassHasMethod("OnDownloadComplete", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateFileListTransferCBInterface_3(SwigDirectorOnDownloadComplete);
    if (SwigDerivedClassHasMethod("OnDereference", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateFileListTransferCBInterface_4(SwigDirectorOnDereference);
    RakNetPINVOKE.FileListTransferCBInterface_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(FileListTransferCBInterface));
    return hasDerivedMethod;
  }

  private bool SwigDirectorOnFile(global::System.IntPtr onFileStruct) {
    return OnFile((onFileStruct == global::System.IntPtr.Zero) ? null : new FileListTransferCBInterface.OnFileStruct(onFileStruct, false));
  }

  private void SwigDirectorOnFileProgress(global::System.IntPtr fps) {
    OnFileProgress((fps == global::System.IntPtr.Zero) ? null : new FileListTransferCBInterface.FileProgressStruct(fps, false));
  }

  private bool SwigDirectorUpdate() {
    return Update();
  }

  private bool SwigDirectorOnDownloadComplete(global::System.IntPtr dcs) {
    return OnDownloadComplete((dcs == global::System.IntPtr.Zero) ? null : new FileListTransferCBInterface.DownloadCompleteStruct(dcs, false));
  }

  private void SwigDirectorOnDereference() {
    OnDereference();
  }

  public delegate bool SwigDelegateFileListTransferCBInterface_0(global::System.IntPtr onFileStruct);
  public delegate void SwigDelegateFileListTransferCBInterface_1(global::System.IntPtr fps);
  public delegate bool SwigDelegateFileListTransferCBInterface_2();
  public delegate bool SwigDelegateFileListTransferCBInterface_3(global::System.IntPtr dcs);
  public delegate void SwigDelegateFileListTransferCBInterface_4();

  private SwigDelegateFileListTransferCBInterface_0 swigDelegate0;
  private SwigDelegateFileListTransferCBInterface_1 swigDelegate1;
  private SwigDelegateFileListTransferCBInterface_2 swigDelegate2;
  private SwigDelegateFileListTransferCBInterface_3 swigDelegate3;
  private SwigDelegateFileListTransferCBInterface_4 swigDelegate4;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] { typeof(FileListTransferCBInterface.OnFileStruct) };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(FileListTransferCBInterface.FileProgressStruct) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(FileListTransferCBInterface.DownloadCompleteStruct) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] {  };
}

}
