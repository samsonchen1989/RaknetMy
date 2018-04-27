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

using System;
using System.Runtime.InteropServices;
#pragma warning disable 0660

public class RakNetGUID : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RakNetGUID(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RakNetGUID obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RakNetGUID() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_RakNetGUID(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }


	public override int GetHashCode()
	{
		// return (int)(this.g%int.MaxValue);
		 return (int) ToUint32(this);
	}

	public static bool operator ==(RakNetGUID a, RakNetGUID b)
	{
 	   	// If both are null, or both are same instance, return true.
 		if (System.Object.ReferenceEquals(a, b))
 		{
 	       		return true;
 	   	}

  		// If one is null, but not both, return false.
   	 	if (((object)a == null) || ((object)b == null))
    		{
       		 	return false;
    		}

		    return a.Equals(b);//Equals should be overloaded as well
	}

	public static bool operator !=(RakNetGUID a, RakNetGUID b)
	{
   		 return a.OpNotEqual(b);
	}

	public static bool operator < (RakNetGUID a, RakNetGUID b)
	{
    		return a.OpLess(b);
	}

	public static bool operator >(RakNetGUID a, RakNetGUID b)
	{
		return a.OpGreater(b);
	}

	public static bool operator <=(RakNetGUID a, RakNetGUID b)
	{
		return (a.OpLess(b) || a==b);
	}

	public static bool operator >=(RakNetGUID a, RakNetGUID b)
	{
		return (a.OpGreater(b) || a==b);
	}

 	public void ToString(out string dest) 
	{
		dest = ToString();
	}

  public RakNetGUID() : this(RakNetPINVOKE.new_RakNetGUID__SWIG_0(), true) {
  }

  public RakNetGUID(ulong _g) : this(RakNetPINVOKE.new_RakNetGUID__SWIG_1(_g), true) {
  }

  public ulong g {
    set {
      RakNetPINVOKE.RakNetGUID_g_set(swigCPtr, value);
    } 
    get {
      ulong ret = RakNetPINVOKE.RakNetGUID_g_get(swigCPtr);
      return ret;
    } 
  }

  public override string ToString() {
    string ret = RakNetPINVOKE.RakNetGUID_ToString(swigCPtr);
    return ret;
  }

  public bool FromString(string source) {
    bool ret = RakNetPINVOKE.RakNetGUID_FromString(swigCPtr, source);
    return ret;
  }

  public static uint ToUint32(RakNetGUID g) {
    uint ret = RakNetPINVOKE.RakNetGUID_ToUint32(RakNetGUID.getCPtr(g));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RakNetGUID CopyData(RakNetGUID input) {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.RakNetGUID_CopyData(swigCPtr, RakNetGUID.getCPtr(input)), false);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ushort systemIndex {
    set {
      RakNetPINVOKE.RakNetGUID_systemIndex_set(swigCPtr, value);
    } 
    get {
      ushort ret = RakNetPINVOKE.RakNetGUID_systemIndex_get(swigCPtr);
      return ret;
    } 
  }

  public static int size() {
    int ret = RakNetPINVOKE.RakNetGUID_size();
    return ret;
  }

  public bool Equals(RakNetGUID right) {
    bool ret = RakNetPINVOKE.RakNetGUID_Equals(swigCPtr, RakNetGUID.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpNotEqual(RakNetGUID right) {
    bool ret = RakNetPINVOKE.RakNetGUID_OpNotEqual(swigCPtr, RakNetGUID.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpGreater(RakNetGUID right) {
    bool ret = RakNetPINVOKE.RakNetGUID_OpGreater(swigCPtr, RakNetGUID.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private bool OpLess(RakNetGUID right) {
    bool ret = RakNetPINVOKE.RakNetGUID_OpLess(swigCPtr, RakNetGUID.getCPtr(right));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
