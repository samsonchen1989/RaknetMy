//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class UDPForwarder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UDPForwarder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UDPForwarder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UDPForwarder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_UDPForwarder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UDPForwarder() : this(RakNetPINVOKE.new_UDPForwarder(), true) {
  }

  public void Startup() {
    RakNetPINVOKE.UDPForwarder_Startup(swigCPtr);
  }

  public void Shutdown() {
    RakNetPINVOKE.UDPForwarder_Shutdown(swigCPtr);
  }

  public void SetMaxForwardEntries(ushort maxEntries) {
    RakNetPINVOKE.UDPForwarder_SetMaxForwardEntries(swigCPtr, maxEntries);
  }

  public int GetMaxForwardEntries() {
    int ret = RakNetPINVOKE.UDPForwarder_GetMaxForwardEntries(swigCPtr);
    return ret;
  }

  public int GetUsedForwardEntries() {
    int ret = RakNetPINVOKE.UDPForwarder_GetUsedForwardEntries(swigCPtr);
    return ret;
  }

  public UDPForwarderResult StartForwarding(SystemAddress source, SystemAddress destination, uint timeoutOnNoDataMS, string forceHostAddress, ushort socketFamily, out ushort forwardingPort, out int forwardingSocket) {
    UDPForwarderResult ret = (UDPForwarderResult)RakNetPINVOKE.UDPForwarder_StartForwarding(swigCPtr, SystemAddress.getCPtr(source), SystemAddress.getCPtr(destination), timeoutOnNoDataMS, forceHostAddress, socketFamily, out forwardingPort, out forwardingSocket);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void StopForwarding(SystemAddress source, SystemAddress destination) {
    RakNetPINVOKE.UDPForwarder_StopForwarding(swigCPtr, SystemAddress.getCPtr(source), SystemAddress.getCPtr(destination));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public class ForwardEntry : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal ForwardEntry(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ForwardEntry obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~ForwardEntry() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_UDPForwarder_ForwardEntry(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ForwardEntry() : this(RakNetPINVOKE.new_UDPForwarder_ForwardEntry(), true) {
    }
  
    public SystemAddress addr1Unconfirmed {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_addr1Unconfirmed_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.UDPForwarder_ForwardEntry_addr1Unconfirmed_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public SystemAddress addr2Unconfirmed {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_addr2Unconfirmed_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.UDPForwarder_ForwardEntry_addr2Unconfirmed_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public SystemAddress addr1Confirmed {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_addr1Confirmed_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.UDPForwarder_ForwardEntry_addr1Confirmed_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public SystemAddress addr2Confirmed {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_addr2Confirmed_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.UDPForwarder_ForwardEntry_addr2Confirmed_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public uint timeLastDatagramForwarded {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_timeLastDatagramForwarded_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.UDPForwarder_ForwardEntry_timeLastDatagramForwarded_get(swigCPtr);
        return ret;
      } 
    }
  
    public int socket {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_socket_set(swigCPtr, value);
      } 
      get {
        int ret = RakNetPINVOKE.UDPForwarder_ForwardEntry_socket_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint timeoutOnNoDataMS {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_timeoutOnNoDataMS_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.UDPForwarder_ForwardEntry_timeoutOnNoDataMS_get(swigCPtr);
        return ret;
      } 
    }
  
    public short socketFamily {
      set {
        RakNetPINVOKE.UDPForwarder_ForwardEntry_socketFamily_set(swigCPtr, value);
      } 
      get {
        short ret = RakNetPINVOKE.UDPForwarder_ForwardEntry_socketFamily_get(swigCPtr);
        return ret;
      } 
    }
  
  }

}

}
