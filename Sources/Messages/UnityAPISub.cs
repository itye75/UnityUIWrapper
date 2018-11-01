// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UnityAPISub.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UnityAPI.Sub {

  /// <summary>Holder for reflection information generated from UnityAPISub.proto</summary>
  public static partial class UnityAPISubReflection {

    #region Descriptor
    /// <summary>File descriptor for UnityAPISub.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityAPISubReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFVbml0eUFQSVN1Yi5wcm90bxIMVW5pdHlBUEkuU3ViIrMCChJVbml0eUds",
            "b2JhbENvbW1hbmQSLAoHb3BfY29kZRgBIAEoDjIbLlVuaXR5QVBJLlN1Yi5D",
            "b21tYW5kT3BDb2RlEjkKEW9iamVjdF9tYW5hZ2VtZW50GAIgASgLMh4uVW5p",
            "dHlBUEkuU3ViLk9iamVjdE1hbmFnZW1lbnQSLQoLY2FtZXJhX3ZpZXcYAyAB",
            "KA4yGC5Vbml0eUFQSS5TdWIuQ2FtZXJhVmlldxJKChp0YWN0aWNhbF9vYmpl",
            "Y3RfbWFuYWdlbWVudBgEIAEoCzImLlVuaXR5QVBJLlN1Yi5UYWN0aWNhbE9i",
            "amVjdE1hbmFnZW1lbnQSOQoNcmVtb3RlQ29udHJvbBgFIAEoCzIiLlVuaXR5",
            "QVBJLlN1Yi5SZW1vdGVDb250cm9sTWVzc2FnZSJXChRSZW1vdGVDb250cm9s",
            "TWVzc2FnZRIxCgZvcENvZGUYASABKA4yIS5Vbml0eUFQSS5TdWIuU2NlbmVN",
            "YW5hZ2VyQ29tbWFuZBIMCgRwYXRoGAIgASgJIm4KEE9iamVjdE1hbmFnZW1l",
            "bnQSMgoHb3BfY29kZRgBIAEoDjIhLlVuaXR5QVBJLlN1Yi5PYmplY3RDb250",
            "cm9sT3BDb2RlEhMKC29iamVjdF90eXBlGAIgASgFEhEKCWhpZ2hsaWdodBgD",
            "IAEoCCJPChhUYWN0aWNhbE9iamVjdE1hbmFnZW1lbnQSMwoHb3BfY29kZRgB",
            "IAEoDjIiLlVuaXR5QVBJLlN1Yi5UYWN0aWNhbE9iamVjdE9wQ29kZSpjCg1D",
            "b21tYW5kT3BDb2RlEhUKEU9CSkVDVF9NQU5BR0VNRU5UEAASEgoOQ0FNRVJB",
            "X0NPTlRST0wQARITCg9UQUNUSUNBTF9PQkpFQ1QQAhISCg5SRU1PVEVfQ09O",
            "VFJPTBADKkgKE1NjZW5lTWFuYWdlckNvbW1hbmQSCAoEU0FWRRAAEggKBExP",
            "QUQQARIICgRQTEFZEAISCAoEU1RPUBADEgkKBVBBVVNFEAQqKgoKQ2FtZXJh",
            "VmlldxINCglQTEFOX1ZJRVcQABINCglGUkVFX0xPT0sQASo1ChNPYmplY3RD",
            "b250cm9sT3BDb2RlEgcKA0FERBAAEhUKEUhJR0hMSUdIVF9PQkpFQ1RTEAEq",
            "KAoUVGFjdGljYWxPYmplY3RPcENvZGUSEAoMQ1JFQVRFX1JPVVRFEABiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::UnityAPI.Sub.CommandOpCode), typeof(global::UnityAPI.Sub.SceneManagerCommand), typeof(global::UnityAPI.Sub.CameraView), typeof(global::UnityAPI.Sub.ObjectControlOpCode), typeof(global::UnityAPI.Sub.TacticalObjectOpCode), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Sub.UnityGlobalCommand), global::UnityAPI.Sub.UnityGlobalCommand.Parser, new[]{ "OpCode", "ObjectManagement", "CameraView", "TacticalObjectManagement", "RemoteControl" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Sub.RemoteControlMessage), global::UnityAPI.Sub.RemoteControlMessage.Parser, new[]{ "OpCode", "Path" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Sub.ObjectManagement), global::UnityAPI.Sub.ObjectManagement.Parser, new[]{ "OpCode", "ObjectType", "Highlight" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Sub.TacticalObjectManagement), global::UnityAPI.Sub.TacticalObjectManagement.Parser, new[]{ "OpCode" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum CommandOpCode {
    [pbr::OriginalName("OBJECT_MANAGEMENT")] ObjectManagement = 0,
    [pbr::OriginalName("CAMERA_CONTROL")] CameraControl = 1,
    [pbr::OriginalName("TACTICAL_OBJECT")] TacticalObject = 2,
    [pbr::OriginalName("REMOTE_CONTROL")] RemoteControl = 3,
  }

  public enum SceneManagerCommand {
    [pbr::OriginalName("SAVE")] Save = 0,
    [pbr::OriginalName("LOAD")] Load = 1,
    [pbr::OriginalName("PLAY")] Play = 2,
    [pbr::OriginalName("STOP")] Stop = 3,
    [pbr::OriginalName("PAUSE")] Pause = 4,
  }

  public enum CameraView {
    [pbr::OriginalName("PLAN_VIEW")] PlanView = 0,
    [pbr::OriginalName("FREE_LOOK")] FreeLook = 1,
  }

  public enum ObjectControlOpCode {
    [pbr::OriginalName("ADD")] Add = 0,
    [pbr::OriginalName("HIGHLIGHT_OBJECTS")] HighlightObjects = 1,
  }

  public enum TacticalObjectOpCode {
    [pbr::OriginalName("CREATE_ROUTE")] CreateRoute = 0,
  }

  #endregion

  #region Messages
  public sealed partial class UnityGlobalCommand : pb::IMessage<UnityGlobalCommand> {
    private static readonly pb::MessageParser<UnityGlobalCommand> _parser = new pb::MessageParser<UnityGlobalCommand>(() => new UnityGlobalCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnityGlobalCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Sub.UnityAPISubReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityGlobalCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityGlobalCommand(UnityGlobalCommand other) : this() {
      opCode_ = other.opCode_;
      objectManagement_ = other.objectManagement_ != null ? other.objectManagement_.Clone() : null;
      cameraView_ = other.cameraView_;
      tacticalObjectManagement_ = other.tacticalObjectManagement_ != null ? other.tacticalObjectManagement_.Clone() : null;
      remoteControl_ = other.remoteControl_ != null ? other.remoteControl_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnityGlobalCommand Clone() {
      return new UnityGlobalCommand(this);
    }

    /// <summary>Field number for the "op_code" field.</summary>
    public const int OpCodeFieldNumber = 1;
    private global::UnityAPI.Sub.CommandOpCode opCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.CommandOpCode OpCode {
      get { return opCode_; }
      set {
        opCode_ = value;
      }
    }

    /// <summary>Field number for the "object_management" field.</summary>
    public const int ObjectManagementFieldNumber = 2;
    private global::UnityAPI.Sub.ObjectManagement objectManagement_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.ObjectManagement ObjectManagement {
      get { return objectManagement_; }
      set {
        objectManagement_ = value;
      }
    }

    /// <summary>Field number for the "camera_view" field.</summary>
    public const int CameraViewFieldNumber = 3;
    private global::UnityAPI.Sub.CameraView cameraView_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.CameraView CameraView {
      get { return cameraView_; }
      set {
        cameraView_ = value;
      }
    }

    /// <summary>Field number for the "tactical_object_management" field.</summary>
    public const int TacticalObjectManagementFieldNumber = 4;
    private global::UnityAPI.Sub.TacticalObjectManagement tacticalObjectManagement_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.TacticalObjectManagement TacticalObjectManagement {
      get { return tacticalObjectManagement_; }
      set {
        tacticalObjectManagement_ = value;
      }
    }

    /// <summary>Field number for the "remoteControl" field.</summary>
    public const int RemoteControlFieldNumber = 5;
    private global::UnityAPI.Sub.RemoteControlMessage remoteControl_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.RemoteControlMessage RemoteControl {
      get { return remoteControl_; }
      set {
        remoteControl_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnityGlobalCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnityGlobalCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpCode != other.OpCode) return false;
      if (!object.Equals(ObjectManagement, other.ObjectManagement)) return false;
      if (CameraView != other.CameraView) return false;
      if (!object.Equals(TacticalObjectManagement, other.TacticalObjectManagement)) return false;
      if (!object.Equals(RemoteControl, other.RemoteControl)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpCode != 0) hash ^= OpCode.GetHashCode();
      if (objectManagement_ != null) hash ^= ObjectManagement.GetHashCode();
      if (CameraView != 0) hash ^= CameraView.GetHashCode();
      if (tacticalObjectManagement_ != null) hash ^= TacticalObjectManagement.GetHashCode();
      if (remoteControl_ != null) hash ^= RemoteControl.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OpCode);
      }
      if (objectManagement_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(ObjectManagement);
      }
      if (CameraView != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) CameraView);
      }
      if (tacticalObjectManagement_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(TacticalObjectManagement);
      }
      if (remoteControl_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(RemoteControl);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpCode);
      }
      if (objectManagement_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjectManagement);
      }
      if (CameraView != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) CameraView);
      }
      if (tacticalObjectManagement_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TacticalObjectManagement);
      }
      if (remoteControl_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RemoteControl);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnityGlobalCommand other) {
      if (other == null) {
        return;
      }
      if (other.OpCode != 0) {
        OpCode = other.OpCode;
      }
      if (other.objectManagement_ != null) {
        if (objectManagement_ == null) {
          objectManagement_ = new global::UnityAPI.Sub.ObjectManagement();
        }
        ObjectManagement.MergeFrom(other.ObjectManagement);
      }
      if (other.CameraView != 0) {
        CameraView = other.CameraView;
      }
      if (other.tacticalObjectManagement_ != null) {
        if (tacticalObjectManagement_ == null) {
          tacticalObjectManagement_ = new global::UnityAPI.Sub.TacticalObjectManagement();
        }
        TacticalObjectManagement.MergeFrom(other.TacticalObjectManagement);
      }
      if (other.remoteControl_ != null) {
        if (remoteControl_ == null) {
          remoteControl_ = new global::UnityAPI.Sub.RemoteControlMessage();
        }
        RemoteControl.MergeFrom(other.RemoteControl);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            opCode_ = (global::UnityAPI.Sub.CommandOpCode) input.ReadEnum();
            break;
          }
          case 18: {
            if (objectManagement_ == null) {
              objectManagement_ = new global::UnityAPI.Sub.ObjectManagement();
            }
            input.ReadMessage(objectManagement_);
            break;
          }
          case 24: {
            cameraView_ = (global::UnityAPI.Sub.CameraView) input.ReadEnum();
            break;
          }
          case 34: {
            if (tacticalObjectManagement_ == null) {
              tacticalObjectManagement_ = new global::UnityAPI.Sub.TacticalObjectManagement();
            }
            input.ReadMessage(tacticalObjectManagement_);
            break;
          }
          case 42: {
            if (remoteControl_ == null) {
              remoteControl_ = new global::UnityAPI.Sub.RemoteControlMessage();
            }
            input.ReadMessage(remoteControl_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RemoteControlMessage : pb::IMessage<RemoteControlMessage> {
    private static readonly pb::MessageParser<RemoteControlMessage> _parser = new pb::MessageParser<RemoteControlMessage>(() => new RemoteControlMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RemoteControlMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Sub.UnityAPISubReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteControlMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteControlMessage(RemoteControlMessage other) : this() {
      opCode_ = other.opCode_;
      path_ = other.path_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RemoteControlMessage Clone() {
      return new RemoteControlMessage(this);
    }

    /// <summary>Field number for the "opCode" field.</summary>
    public const int OpCodeFieldNumber = 1;
    private global::UnityAPI.Sub.SceneManagerCommand opCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.SceneManagerCommand OpCode {
      get { return opCode_; }
      set {
        opCode_ = value;
      }
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 2;
    private string path_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Path {
      get { return path_; }
      set {
        path_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RemoteControlMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RemoteControlMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpCode != other.OpCode) return false;
      if (Path != other.Path) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpCode != 0) hash ^= OpCode.GetHashCode();
      if (Path.Length != 0) hash ^= Path.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OpCode);
      }
      if (Path.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Path);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpCode);
      }
      if (Path.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Path);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RemoteControlMessage other) {
      if (other == null) {
        return;
      }
      if (other.OpCode != 0) {
        OpCode = other.OpCode;
      }
      if (other.Path.Length != 0) {
        Path = other.Path;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            opCode_ = (global::UnityAPI.Sub.SceneManagerCommand) input.ReadEnum();
            break;
          }
          case 18: {
            Path = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ObjectManagement : pb::IMessage<ObjectManagement> {
    private static readonly pb::MessageParser<ObjectManagement> _parser = new pb::MessageParser<ObjectManagement>(() => new ObjectManagement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ObjectManagement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Sub.UnityAPISubReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectManagement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectManagement(ObjectManagement other) : this() {
      opCode_ = other.opCode_;
      objectType_ = other.objectType_;
      highlight_ = other.highlight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ObjectManagement Clone() {
      return new ObjectManagement(this);
    }

    /// <summary>Field number for the "op_code" field.</summary>
    public const int OpCodeFieldNumber = 1;
    private global::UnityAPI.Sub.ObjectControlOpCode opCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.ObjectControlOpCode OpCode {
      get { return opCode_; }
      set {
        opCode_ = value;
      }
    }

    /// <summary>Field number for the "object_type" field.</summary>
    public const int ObjectTypeFieldNumber = 2;
    private int objectType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ObjectType {
      get { return objectType_; }
      set {
        objectType_ = value;
      }
    }

    /// <summary>Field number for the "highlight" field.</summary>
    public const int HighlightFieldNumber = 3;
    private bool highlight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Highlight {
      get { return highlight_; }
      set {
        highlight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ObjectManagement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ObjectManagement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpCode != other.OpCode) return false;
      if (ObjectType != other.ObjectType) return false;
      if (Highlight != other.Highlight) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpCode != 0) hash ^= OpCode.GetHashCode();
      if (ObjectType != 0) hash ^= ObjectType.GetHashCode();
      if (Highlight != false) hash ^= Highlight.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OpCode);
      }
      if (ObjectType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ObjectType);
      }
      if (Highlight != false) {
        output.WriteRawTag(24);
        output.WriteBool(Highlight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpCode);
      }
      if (ObjectType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ObjectType);
      }
      if (Highlight != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ObjectManagement other) {
      if (other == null) {
        return;
      }
      if (other.OpCode != 0) {
        OpCode = other.OpCode;
      }
      if (other.ObjectType != 0) {
        ObjectType = other.ObjectType;
      }
      if (other.Highlight != false) {
        Highlight = other.Highlight;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            opCode_ = (global::UnityAPI.Sub.ObjectControlOpCode) input.ReadEnum();
            break;
          }
          case 16: {
            ObjectType = input.ReadInt32();
            break;
          }
          case 24: {
            Highlight = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class TacticalObjectManagement : pb::IMessage<TacticalObjectManagement> {
    private static readonly pb::MessageParser<TacticalObjectManagement> _parser = new pb::MessageParser<TacticalObjectManagement>(() => new TacticalObjectManagement());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TacticalObjectManagement> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Sub.UnityAPISubReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TacticalObjectManagement() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TacticalObjectManagement(TacticalObjectManagement other) : this() {
      opCode_ = other.opCode_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TacticalObjectManagement Clone() {
      return new TacticalObjectManagement(this);
    }

    /// <summary>Field number for the "op_code" field.</summary>
    public const int OpCodeFieldNumber = 1;
    private global::UnityAPI.Sub.TacticalObjectOpCode opCode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Sub.TacticalObjectOpCode OpCode {
      get { return opCode_; }
      set {
        opCode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TacticalObjectManagement);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TacticalObjectManagement other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OpCode != other.OpCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (OpCode != 0) hash ^= OpCode.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (OpCode != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) OpCode);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (OpCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TacticalObjectManagement other) {
      if (other == null) {
        return;
      }
      if (other.OpCode != 0) {
        OpCode = other.OpCode;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            opCode_ = (global::UnityAPI.Sub.TacticalObjectOpCode) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code