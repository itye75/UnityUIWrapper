// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: UnityAPIPub.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace UnityAPI.Pub {

  /// <summary>Holder for reflection information generated from UnityAPIPub.proto</summary>
  public static partial class UnityAPIPubReflection {

    #region Descriptor
    /// <summary>File descriptor for UnityAPIPub.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnityAPIPubReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFVbml0eUFQSVB1Yi5wcm90bxIMVW5pdHlBUEkuUHViIj8KEUVudGl0aWVz",
            "VXBkYXRlTXNnEioKCGVudGl0aWVzGAEgAygLMhguVW5pdHlBUEkuUHViLkVu",
            "dGl0eURhdGEieQoKRW50aXR5RGF0YRIsCghsb2NhdGlvbhgBIAEoCzIaLlVu",
            "aXR5QVBJLlB1Yi5WZWN0b3JEb3VibGUSLwoLb3JpZW50YXRpb24YAiABKAsy",
            "Gi5Vbml0eUFQSS5QdWIuVmVjdG9yRG91YmxlEgwKBE5hbWUYAyABKAkiLwoM",
            "VmVjdG9yRG91YmxlEgkKAXgYASABKAESCQoBeRgCIAEoARIJCgF6GAMgASgB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Pub.EntitiesUpdateMsg), global::UnityAPI.Pub.EntitiesUpdateMsg.Parser, new[]{ "Entities" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Pub.EntityData), global::UnityAPI.Pub.EntityData.Parser, new[]{ "Location", "Orientation", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::UnityAPI.Pub.VectorDouble), global::UnityAPI.Pub.VectorDouble.Parser, new[]{ "X", "Y", "Z" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class EntitiesUpdateMsg : pb::IMessage<EntitiesUpdateMsg> {
    private static readonly pb::MessageParser<EntitiesUpdateMsg> _parser = new pb::MessageParser<EntitiesUpdateMsg>(() => new EntitiesUpdateMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EntitiesUpdateMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Pub.UnityAPIPubReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntitiesUpdateMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntitiesUpdateMsg(EntitiesUpdateMsg other) : this() {
      entities_ = other.entities_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntitiesUpdateMsg Clone() {
      return new EntitiesUpdateMsg(this);
    }

    /// <summary>Field number for the "entities" field.</summary>
    public const int EntitiesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::UnityAPI.Pub.EntityData> _repeated_entities_codec
        = pb::FieldCodec.ForMessage(10, global::UnityAPI.Pub.EntityData.Parser);
    private readonly pbc::RepeatedField<global::UnityAPI.Pub.EntityData> entities_ = new pbc::RepeatedField<global::UnityAPI.Pub.EntityData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::UnityAPI.Pub.EntityData> Entities {
      get { return entities_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EntitiesUpdateMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EntitiesUpdateMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!entities_.Equals(other.entities_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= entities_.GetHashCode();
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
      entities_.WriteTo(output, _repeated_entities_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += entities_.CalculateSize(_repeated_entities_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EntitiesUpdateMsg other) {
      if (other == null) {
        return;
      }
      entities_.Add(other.entities_);
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
          case 10: {
            entities_.AddEntriesFrom(input, _repeated_entities_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class EntityData : pb::IMessage<EntityData> {
    private static readonly pb::MessageParser<EntityData> _parser = new pb::MessageParser<EntityData>(() => new EntityData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<EntityData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Pub.UnityAPIPubReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityData(EntityData other) : this() {
      location_ = other.location_ != null ? other.location_.Clone() : null;
      orientation_ = other.orientation_ != null ? other.orientation_.Clone() : null;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public EntityData Clone() {
      return new EntityData(this);
    }

    /// <summary>Field number for the "location" field.</summary>
    public const int LocationFieldNumber = 1;
    private global::UnityAPI.Pub.VectorDouble location_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Pub.VectorDouble Location {
      get { return location_; }
      set {
        location_ = value;
      }
    }

    /// <summary>Field number for the "orientation" field.</summary>
    public const int OrientationFieldNumber = 2;
    private global::UnityAPI.Pub.VectorDouble orientation_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::UnityAPI.Pub.VectorDouble Orientation {
      get { return orientation_; }
      set {
        orientation_ = value;
      }
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 3;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as EntityData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(EntityData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Location, other.Location)) return false;
      if (!object.Equals(Orientation, other.Orientation)) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (location_ != null) hash ^= Location.GetHashCode();
      if (orientation_ != null) hash ^= Orientation.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (location_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Location);
      }
      if (orientation_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Orientation);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (location_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Location);
      }
      if (orientation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Orientation);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(EntityData other) {
      if (other == null) {
        return;
      }
      if (other.location_ != null) {
        if (location_ == null) {
          location_ = new global::UnityAPI.Pub.VectorDouble();
        }
        Location.MergeFrom(other.Location);
      }
      if (other.orientation_ != null) {
        if (orientation_ == null) {
          orientation_ = new global::UnityAPI.Pub.VectorDouble();
        }
        Orientation.MergeFrom(other.Orientation);
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
          case 10: {
            if (location_ == null) {
              location_ = new global::UnityAPI.Pub.VectorDouble();
            }
            input.ReadMessage(location_);
            break;
          }
          case 18: {
            if (orientation_ == null) {
              orientation_ = new global::UnityAPI.Pub.VectorDouble();
            }
            input.ReadMessage(orientation_);
            break;
          }
          case 26: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class VectorDouble : pb::IMessage<VectorDouble> {
    private static readonly pb::MessageParser<VectorDouble> _parser = new pb::MessageParser<VectorDouble>(() => new VectorDouble());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VectorDouble> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::UnityAPI.Pub.UnityAPIPubReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VectorDouble() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VectorDouble(VectorDouble other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      z_ = other.z_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VectorDouble Clone() {
      return new VectorDouble(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "z" field.</summary>
    public const int ZFieldNumber = 3;
    private double z_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Z {
      get { return z_; }
      set {
        z_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VectorDouble);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VectorDouble other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(X, other.X)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Y, other.Y)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Z, other.Z)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(X);
      if (Y != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Y);
      if (Z != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Z);
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
      if (X != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Y);
      }
      if (Z != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Z);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (Z != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VectorDouble other) {
      if (other == null) {
        return;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.Z != 0D) {
        Z = other.Z;
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
          case 9: {
            X = input.ReadDouble();
            break;
          }
          case 17: {
            Y = input.ReadDouble();
            break;
          }
          case 25: {
            Z = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code