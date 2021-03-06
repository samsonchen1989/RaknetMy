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

public class FullyConnectedMesh2 : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FullyConnectedMesh2(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.FullyConnectedMesh2_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FullyConnectedMesh2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FullyConnectedMesh2() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_FullyConnectedMesh2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static FullyConnectedMesh2 GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_GetInstance();
    FullyConnectedMesh2 ret = (cPtr == global::System.IntPtr.Zero) ? null : new FullyConnectedMesh2(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(FullyConnectedMesh2 i) {
    RakNetPINVOKE.FullyConnectedMesh2_DestroyInstance(FullyConnectedMesh2.getCPtr(i));
  }

  public FullyConnectedMesh2() : this(RakNetPINVOKE.new_FullyConnectedMesh2(), true) {
  }

  public void SetConnectOnNewRemoteConnection(bool attemptConnection, RakString pw) {
    RakNetPINVOKE.FullyConnectedMesh2_SetConnectOnNewRemoteConnection(swigCPtr, attemptConnection, RakString.getCPtr(pw));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetGUID GetConnectedHost() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.FullyConnectedMesh2_GetConnectedHost(swigCPtr), true);
    return ret;
  }

  public SystemAddress GetConnectedHostAddr() {
    SystemAddress ret = new SystemAddress(RakNetPINVOKE.FullyConnectedMesh2_GetConnectedHostAddr(swigCPtr), true);
    return ret;
  }

  public RakNetGUID GetHostSystem() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.FullyConnectedMesh2_GetHostSystem(swigCPtr), true);
    return ret;
  }

  public bool IsHostSystem() {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_IsHostSystem(swigCPtr);
    return ret;
  }

  public void GetHostOrder(RakNetListRakNetGUID hostList) {
    RakNetPINVOKE.FullyConnectedMesh2_GetHostOrder(swigCPtr, RakNetListRakNetGUID.getCPtr(hostList));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsConnectedHost() {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_IsConnectedHost(swigCPtr);
    return ret;
  }

  public void SetAutoparticipateConnections(bool b) {
    RakNetPINVOKE.FullyConnectedMesh2_SetAutoparticipateConnections(swigCPtr, b);
  }

  public void ResetHostCalculation() {
    RakNetPINVOKE.FullyConnectedMesh2_ResetHostCalculation(swigCPtr);
  }

  public void AddParticipant(RakNetGUID rakNetGuid) {
    RakNetPINVOKE.FullyConnectedMesh2_AddParticipant(swigCPtr, RakNetGUID.getCPtr(rakNetGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetParticipantList(RakNetListRakNetGUID participantList) {
    RakNetPINVOKE.FullyConnectedMesh2_GetParticipantList(swigCPtr, RakNetListRakNetGUID.getCPtr(participantList));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasParticipant(RakNetGUID participantGuid) {
    bool ret = RakNetPINVOKE.FullyConnectedMesh2_HasParticipant(swigCPtr, RakNetGUID.getCPtr(participantGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ConnectToRemoteNewIncomingConnections(Packet packet) {
    RakNetPINVOKE.FullyConnectedMesh2_ConnectToRemoteNewIncomingConnections(swigCPtr, Packet.getCPtr(packet));
  }

  public void Clear() {
    RakNetPINVOKE.FullyConnectedMesh2_Clear(swigCPtr);
  }

  public uint GetParticipantCount() {
    uint ret = RakNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_0(swigCPtr);
    return ret;
  }

  public void GetParticipantCount(SWIGTYPE_p_unsigned_int participantListSize) {
    RakNetPINVOKE.FullyConnectedMesh2_GetParticipantCount__SWIG_1(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(participantListSize));
  }

  public virtual void StartVerifiedJoin(RakNetGUID client) {
    RakNetPINVOKE.FullyConnectedMesh2_StartVerifiedJoin(swigCPtr, RakNetGUID.getCPtr(client));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void RespondOnVerifiedJoinCapable(Packet packet, bool accept, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_RespondOnVerifiedJoinCapable(swigCPtr, Packet.getCPtr(packet), accept, BitStream.getCPtr(additionalData));
  }

  public virtual void GetVerifiedJoinRequiredProcessingList(RakNetGUID host, RakNetListSystemAddress addresses, RakNetListRakNetGUID guids, SWIGTYPE_p_DataStructures__ListT_RakNet__BitStream_p_t userData) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRequiredProcessingList(swigCPtr, RakNetGUID.getCPtr(host), RakNetListSystemAddress.getCPtr(addresses), RakNetListRakNetGUID.getCPtr(guids), SWIGTYPE_p_DataStructures__ListT_RakNet__BitStream_p_t.getCPtr(userData));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinAcceptedAdditionalData(Packet packet, SWIGTYPE_p_bool thisSystemAccepted, RakNetListRakNetGUID systemsAccepted, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinAcceptedAdditionalData(swigCPtr, Packet.getCPtr(packet), SWIGTYPE_p_bool.getCPtr(thisSystemAccepted), RakNetListRakNetGUID.getCPtr(systemsAccepted), BitStream.getCPtr(additionalData));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void GetVerifiedJoinRejectedAdditionalData(Packet packet, BitStream additionalData) {
    RakNetPINVOKE.FullyConnectedMesh2_GetVerifiedJoinRejectedAdditionalData(swigCPtr, Packet.getCPtr(packet), BitStream.getCPtr(additionalData));
  }

  public virtual void WriteVJCUserData(BitStream bsOut) {
    RakNetPINVOKE.FullyConnectedMesh2_WriteVJCUserData(swigCPtr, BitStream.getCPtr(bsOut));
  }

  public static void SkipToVJCUserData(BitStream bsIn) {
    RakNetPINVOKE.FullyConnectedMesh2_SkipToVJCUserData(BitStream.getCPtr(bsIn));
  }

  public virtual void WriteVJSUserData(BitStream bsOut, RakNetGUID userGuid) {
    RakNetPINVOKE.FullyConnectedMesh2_WriteVJSUserData(swigCPtr, BitStream.getCPtr(bsOut), RakNetGUID.getCPtr(userGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public class FCM2Participant : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal FCM2Participant(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FCM2Participant obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~FCM2Participant() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FullyConnectedMesh2_FCM2Participant(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public FCM2Participant() : this(RakNetPINVOKE.new_FullyConnectedMesh2_FCM2Participant__SWIG_0(), true) {
    }
  
    public FCM2Participant(long _fcm2Guid, RakNetGUID _rakNetGuid) : this(RakNetPINVOKE.new_FullyConnectedMesh2_FCM2Participant__SWIG_1(_fcm2Guid, RakNetGUID.getCPtr(_rakNetGuid)), true) {
      if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public long fcm2Guid {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_FCM2Participant_fcm2Guid_set(swigCPtr, value);
      } 
      get {
        long ret = RakNetPINVOKE.FullyConnectedMesh2_FCM2Participant_fcm2Guid_get(swigCPtr);
        return ret;
      } 
    }
  
    public RakNetGUID rakNetGuid {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_FCM2Participant_rakNetGuid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_FCM2Participant_rakNetGuid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
  }

  public class VerifiedJoinInProgressMember : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal VerifiedJoinInProgressMember(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VerifiedJoinInProgressMember obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~VerifiedJoinInProgressMember() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FullyConnectedMesh2_VerifiedJoinInProgressMember(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public SystemAddress systemAddress {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_systemAddress_set(swigCPtr, SystemAddress.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_systemAddress_get(swigCPtr);
        SystemAddress ret = (cPtr == global::System.IntPtr.Zero) ? null : new SystemAddress(cPtr, false);
        return ret;
      } 
    }
  
    public RakNetGUID guid {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_guid_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_guid_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public FullyConnectedMesh2.JoinInProgressState joinInProgressState {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_joinInProgressState_set(swigCPtr, (int)value);
      } 
      get {
        FullyConnectedMesh2.JoinInProgressState ret = (FullyConnectedMesh2.JoinInProgressState)RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_joinInProgressState_get(swigCPtr);
        return ret;
      } 
    }
  
    public BitStream userData {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_userData_set(swigCPtr, BitStream.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_userData_get(swigCPtr);
        BitStream ret = (cPtr == global::System.IntPtr.Zero) ? null : new BitStream(cPtr, false);
        return ret;
      } 
    }
  
    public bool workingFlag {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_workingFlag_set(swigCPtr, value);
      } 
      get {
        bool ret = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgressMember_workingFlag_get(swigCPtr);
        return ret;
      } 
    }
  
    public VerifiedJoinInProgressMember() : this(RakNetPINVOKE.new_FullyConnectedMesh2_VerifiedJoinInProgressMember(), true) {
    }
  
  }

  public class VerifiedJoinInProgress : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal VerifiedJoinInProgress(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(VerifiedJoinInProgress obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~VerifiedJoinInProgress() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_FullyConnectedMesh2_VerifiedJoinInProgress(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public RakNetGUID requester {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgress_requester_set(swigCPtr, RakNetGUID.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgress_requester_get(swigCPtr);
        RakNetGUID ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakNetGUID(cPtr, false);
        return ret;
      } 
    }
  
    public SWIGTYPE_p_DataStructures__ListT_RakNet__FullyConnectedMesh2__VerifiedJoinInProgressMember_t vjipMembers {
      set {
        RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgress_vjipMembers_set(swigCPtr, SWIGTYPE_p_DataStructures__ListT_RakNet__FullyConnectedMesh2__VerifiedJoinInProgressMember_t.getCPtr(value));
      } 
      get {
        global::System.IntPtr cPtr = RakNetPINVOKE.FullyConnectedMesh2_VerifiedJoinInProgress_vjipMembers_get(swigCPtr);
        SWIGTYPE_p_DataStructures__ListT_RakNet__FullyConnectedMesh2__VerifiedJoinInProgressMember_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_DataStructures__ListT_RakNet__FullyConnectedMesh2__VerifiedJoinInProgressMember_t(cPtr, false);
        return ret;
      } 
    }
  
    public VerifiedJoinInProgress() : this(RakNetPINVOKE.new_FullyConnectedMesh2_VerifiedJoinInProgress(), true) {
    }
  
  }

  public uint GetTotalConnectionCount() {
    uint ret = RakNetPINVOKE.FullyConnectedMesh2_GetTotalConnectionCount(swigCPtr);
    return ret;
  }

  public enum JoinInProgressState {
    JIPS_PROCESSING,
    JIPS_FAILED,
    JIPS_CONNECTED,
    JIPS_UNNECESSARY
  }

}

}
