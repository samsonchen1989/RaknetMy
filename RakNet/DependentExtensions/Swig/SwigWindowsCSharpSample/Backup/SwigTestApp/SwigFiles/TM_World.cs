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

public class TM_World : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TM_World(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TM_World obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TM_World() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.delete_TM_World(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TM_World() : this(RakNetPINVOKE.new_TM_World(), true) {
  }

  public TeamManager GetTeamManager() {
    global::System.IntPtr cPtr = RakNetPINVOKE.TM_World_GetTeamManager(swigCPtr);
    TeamManager ret = (cPtr == global::System.IntPtr.Zero) ? null : new TeamManager(cPtr, false);
    return ret;
  }

  public void AddParticipant(RakNetGUID rakNetGUID) {
    RakNetPINVOKE.TM_World_AddParticipant(swigCPtr, RakNetGUID.getCPtr(rakNetGUID));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveParticipant(RakNetGUID rakNetGUID) {
    RakNetPINVOKE.TM_World_RemoveParticipant(swigCPtr, RakNetGUID.getCPtr(rakNetGUID));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAutoManageConnections(bool autoAdd) {
    RakNetPINVOKE.TM_World_SetAutoManageConnections(swigCPtr, autoAdd);
  }

  public void GetParticipantList(RakNetListRakNetGUID participantList) {
    RakNetPINVOKE.TM_World_GetParticipantList(swigCPtr, RakNetListRakNetGUID.getCPtr(participantList));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReferenceTeam(TM_Team team, ulong networkId, bool applyBalancing) {
    RakNetPINVOKE.TM_World_ReferenceTeam(swigCPtr, TM_Team.getCPtr(team), networkId, applyBalancing);
  }

  public void DereferenceTeam(TM_Team team, byte noTeamSubcategory) {
    RakNetPINVOKE.TM_World_DereferenceTeam(swigCPtr, TM_Team.getCPtr(team), noTeamSubcategory);
  }

  public uint GetTeamCount() {
    uint ret = RakNetPINVOKE.TM_World_GetTeamCount(swigCPtr);
    return ret;
  }

  public TM_Team GetTeamByIndex(uint index) {
    global::System.IntPtr cPtr = RakNetPINVOKE.TM_World_GetTeamByIndex(swigCPtr, index);
    TM_Team ret = (cPtr == global::System.IntPtr.Zero) ? null : new TM_Team(cPtr, false);
    return ret;
  }

  public TM_Team GetTeamByNetworkID(ulong teamId) {
    global::System.IntPtr cPtr = RakNetPINVOKE.TM_World_GetTeamByNetworkID(swigCPtr, teamId);
    TM_Team ret = (cPtr == global::System.IntPtr.Zero) ? null : new TM_Team(cPtr, false);
    return ret;
  }

  public uint GetTeamIndex(TM_Team team) {
    uint ret = RakNetPINVOKE.TM_World_GetTeamIndex(swigCPtr, TM_Team.getCPtr(team));
    return ret;
  }

  public void ReferenceTeamMember(TM_TeamMember teamMember, ulong networkId) {
    RakNetPINVOKE.TM_World_ReferenceTeamMember(swigCPtr, TM_TeamMember.getCPtr(teamMember), networkId);
  }

  public void DereferenceTeamMember(TM_TeamMember teamMember) {
    RakNetPINVOKE.TM_World_DereferenceTeamMember(swigCPtr, TM_TeamMember.getCPtr(teamMember));
  }

  public uint GetTeamMemberCount() {
    uint ret = RakNetPINVOKE.TM_World_GetTeamMemberCount(swigCPtr);
    return ret;
  }

  public TM_TeamMember GetTeamMemberByIndex(uint index) {
    global::System.IntPtr cPtr = RakNetPINVOKE.TM_World_GetTeamMemberByIndex(swigCPtr, index);
    TM_TeamMember ret = (cPtr == global::System.IntPtr.Zero) ? null : new TM_TeamMember(cPtr, false);
    return ret;
  }

  public ulong GetTeamMemberIDByIndex(uint index) {
    ulong ret = RakNetPINVOKE.TM_World_GetTeamMemberIDByIndex(swigCPtr, index);
    return ret;
  }

  public TM_TeamMember GetTeamMemberByNetworkID(ulong teamMemberId) {
    global::System.IntPtr cPtr = RakNetPINVOKE.TM_World_GetTeamMemberByNetworkID(swigCPtr, teamMemberId);
    TM_TeamMember ret = (cPtr == global::System.IntPtr.Zero) ? null : new TM_TeamMember(cPtr, false);
    return ret;
  }

  public uint GetTeamMemberIndex(TM_TeamMember teamMember) {
    uint ret = RakNetPINVOKE.TM_World_GetTeamMemberIndex(swigCPtr, TM_TeamMember.getCPtr(teamMember));
    return ret;
  }

  public bool SetBalanceTeams(bool balanceTeams, byte noTeamSubcategory) {
    bool ret = RakNetPINVOKE.TM_World_SetBalanceTeams(swigCPtr, balanceTeams, noTeamSubcategory);
    return ret;
  }

  public bool GetBalanceTeams() {
    bool ret = RakNetPINVOKE.TM_World_GetBalanceTeams(swigCPtr);
    return ret;
  }

  public void SetHost(RakNetGUID _hostGuid) {
    RakNetPINVOKE.TM_World_SetHost(swigCPtr, RakNetGUID.getCPtr(_hostGuid));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakNetGUID GetHost() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.TM_World_GetHost(swigCPtr), true);
    return ret;
  }

  public byte GetWorldId() {
    byte ret = RakNetPINVOKE.TM_World_GetWorldId(swigCPtr);
    return ret;
  }

  public void Clear() {
    RakNetPINVOKE.TM_World_Clear(swigCPtr);
  }

  public class JoinRequestHelper : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal JoinRequestHelper(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(JoinRequestHelper obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~JoinRequestHelper() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            RakNetPINVOKE.delete_TM_World_JoinRequestHelper(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public ulong whenRequestMade {
      set {
        RakNetPINVOKE.TM_World_JoinRequestHelper_whenRequestMade_set(swigCPtr, value);
      } 
      get {
        ulong ret = RakNetPINVOKE.TM_World_JoinRequestHelper_whenRequestMade_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint teamMemberIndex {
      set {
        RakNetPINVOKE.TM_World_JoinRequestHelper_teamMemberIndex_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.TM_World_JoinRequestHelper_teamMemberIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint indexIntoTeamsRequested {
      set {
        RakNetPINVOKE.TM_World_JoinRequestHelper_indexIntoTeamsRequested_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.TM_World_JoinRequestHelper_indexIntoTeamsRequested_get(swigCPtr);
        return ret;
      } 
    }
  
    public uint requestIndex {
      set {
        RakNetPINVOKE.TM_World_JoinRequestHelper_requestIndex_set(swigCPtr, value);
      } 
      get {
        uint ret = RakNetPINVOKE.TM_World_JoinRequestHelper_requestIndex_get(swigCPtr);
        return ret;
      } 
    }
  
    public JoinRequestHelper() : this(RakNetPINVOKE.new_TM_World_JoinRequestHelper(), true) {
    }
  
  }

  public static int JoinRequestHelperComp(TM_World.JoinRequestHelper key, TM_World.JoinRequestHelper data) {
    int ret = RakNetPINVOKE.TM_World_JoinRequestHelperComp(TM_World.JoinRequestHelper.getCPtr(key), TM_World.JoinRequestHelper.getCPtr(data));
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}