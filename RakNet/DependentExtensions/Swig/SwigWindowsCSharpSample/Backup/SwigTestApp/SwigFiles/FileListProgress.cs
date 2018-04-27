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

public class FileListProgress : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileListProgress(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileListProgress obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileListProgress() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FileListProgress(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static FileListProgress GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.FileListProgress_GetInstance();
    FileListProgress ret = (cPtr == global::System.IntPtr.Zero) ? null : new FileListProgress(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FileListProgress i) {
    RakNetPINVOKE.FileListProgress_DestroyInstance(FileListProgress.getCPtr(i));
  }

  public FileListProgress() : this(RakNetPINVOKE.new_FileListProgress(), true) {
  }

  public virtual void OnAddFilesFromDirectoryStarted(FileList fileList, string dir) {
    RakNetPINVOKE.FileListProgress_OnAddFilesFromDirectoryStarted(swigCPtr, FileList.getCPtr(fileList), dir);
  }

  public virtual void OnDirectory(FileList fileList, string dir, uint directoriesRemaining) {
    RakNetPINVOKE.FileListProgress_OnDirectory(swigCPtr, FileList.getCPtr(fileList), dir, directoriesRemaining);
  }

  public virtual void OnFile(FileList fileList, string dir, string fileName, uint fileSize) {
    RakNetPINVOKE.FileListProgress_OnFile(swigCPtr, FileList.getCPtr(fileList), dir, fileName, fileSize);
  }

  public virtual void OnFilePush(string fileName, uint fileLengthBytes, uint offset, uint bytesBeingSent, bool done, SystemAddress targetSystem, ushort setId) {
    RakNetPINVOKE.FileListProgress_OnFilePush(swigCPtr, fileName, fileLengthBytes, offset, bytesBeingSent, done, SystemAddress.getCPtr(targetSystem), setId);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnFilePushesComplete(SystemAddress systemAddress, ushort setId) {
    RakNetPINVOKE.FileListProgress_OnFilePushesComplete(swigCPtr, SystemAddress.getCPtr(systemAddress), setId);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void OnSendAborted(SystemAddress systemAddress) {
    RakNetPINVOKE.FileListProgress_OnSendAborted(swigCPtr, SystemAddress.getCPtr(systemAddress));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

}

}