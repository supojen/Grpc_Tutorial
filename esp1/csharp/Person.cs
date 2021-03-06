// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: person.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace My.Project {

  /// <summary>Holder for reflection information generated from person.proto</summary>
  public static partial class PersonReflection {

    #region Descriptor
    /// <summary>File descriptor for person.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PersonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxwZXJzb24ucHJvdG8SCm15LnByb2plY3QaCmRhdGUucHJvdG8i/wIKBlBl",
            "cnNvbhIKCgJpZBgBIAEoBRIMCgRuYW1lGAIgASgJEg4KBmhlaWdodBgDIAEo",
            "AhIOCgZ3ZWlnaHQYBCABKAISDgoGYXZhdG9yGAUgASgMEg0KBWVtYWlsGAYg",
            "ASgJEhYKDmVtYWlsX3ZlcmlmaWVkGAcgASgIEhQKDHBob25lX251bWJlchgI",
            "IAMoCRIiCgZnZW5kZXIYCyABKA4yEi5teS5wcm9qZWN0LkdlbmRlchIXCghi",
            "aXJ0aGRheRgMIAEoCzIFLkRhdGUSLQoJYWRkcmVzc2VzGA0gAygLMhoubXku",
            "cHJvamVjdC5QZXJzb24uQWRkcmVzcxpbCgdBZGRyZXNzEhAKCHByb3ZpbmNl",
            "GAEgASgJEgwKBGNvZGUYAiABKAkSEAoIemlwX2NvZGUYAyABKAkSDgoGc3Ry",
            "ZWV0GAQgASgJEg4KBm51bWJlchgFIAEoCUoECAkQCkoECAoQC0oECBQQZUoJ",
            "CMgBEICAgIACUgNmb29SA2JhcipxCgZHZW5kZXISEQoNTk9UX1NQRUNJRklF",
            "RBAAEgoKBkZFTUFMRRABEggKBE1BTEUQAhIJCgVXT01BThABEgcKA01BThAC",
            "GgIQASIECAkQCSIECAoQCiIECBQQZCIJCMgBEP////8HKgNCT1kqBEdJUkxi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::DateReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::My.Project.Gender), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::My.Project.Person), global::My.Project.Person.Parser, new[]{ "Id", "Name", "Height", "Weight", "Avator", "Email", "EmailVerified", "PhoneNumber", "Gender", "Birthday", "Addresses" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::My.Project.Person.Types.Address), global::My.Project.Person.Types.Address.Parser, new[]{ "Province", "Code", "ZipCode", "Street", "Number" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Enums
  public enum Gender {
    [pbr::OriginalName("NOT_SPECIFIED")] NotSpecified = 0,
    [pbr::OriginalName("FEMALE")] Female = 1,
    [pbr::OriginalName("MALE")] Male = 2,
    /// <summary>
    /// 以下兩個是別名
    /// </summary>
    [pbr::OriginalName("WOMAN", PreferredAlias = false)] Woman = 1,
    [pbr::OriginalName("MAN", PreferredAlias = false)] Man = 2,
  }

  #endregion

  #region Messages
  public sealed partial class Person : pb::IMessage<Person>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::My.Project.PersonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person(Person other) : this() {
      id_ = other.id_;
      name_ = other.name_;
      height_ = other.height_;
      weight_ = other.weight_;
      avator_ = other.avator_;
      email_ = other.email_;
      emailVerified_ = other.emailVerified_;
      phoneNumber_ = other.phoneNumber_.Clone();
      gender_ = other.gender_;
      birthday_ = other.birthday_ != null ? other.birthday_.Clone() : null;
      addresses_ = other.addresses_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private int id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "height" field.</summary>
    public const int HeightFieldNumber = 3;
    private float height_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Height {
      get { return height_; }
      set {
        height_ = value;
      }
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 4;
    private float weight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Weight {
      get { return weight_; }
      set {
        weight_ = value;
      }
    }

    /// <summary>Field number for the "avator" field.</summary>
    public const int AvatorFieldNumber = 5;
    private pb::ByteString avator_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Avator {
      get { return avator_; }
      set {
        avator_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 6;
    private string email_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "email_verified" field.</summary>
    public const int EmailVerifiedFieldNumber = 7;
    private bool emailVerified_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EmailVerified {
      get { return emailVerified_; }
      set {
        emailVerified_ = value;
      }
    }

    /// <summary>Field number for the "phone_number" field.</summary>
    public const int PhoneNumberFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _repeated_phoneNumber_codec
        = pb::FieldCodec.ForString(66);
    private readonly pbc::RepeatedField<string> phoneNumber_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> PhoneNumber {
      get { return phoneNumber_; }
    }

    /// <summary>Field number for the "gender" field.</summary>
    public const int GenderFieldNumber = 11;
    private global::My.Project.Gender gender_ = global::My.Project.Gender.NotSpecified;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::My.Project.Gender Gender {
      get { return gender_; }
      set {
        gender_ = value;
      }
    }

    /// <summary>Field number for the "birthday" field.</summary>
    public const int BirthdayFieldNumber = 12;
    private global::Date birthday_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Date Birthday {
      get { return birthday_; }
      set {
        birthday_ = value;
      }
    }

    /// <summary>Field number for the "addresses" field.</summary>
    public const int AddressesFieldNumber = 13;
    private static readonly pb::FieldCodec<global::My.Project.Person.Types.Address> _repeated_addresses_codec
        = pb::FieldCodec.ForMessage(106, global::My.Project.Person.Types.Address.Parser);
    private readonly pbc::RepeatedField<global::My.Project.Person.Types.Address> addresses_ = new pbc::RepeatedField<global::My.Project.Person.Types.Address>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::My.Project.Person.Types.Address> Addresses {
      get { return addresses_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Height, other.Height)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Weight, other.Weight)) return false;
      if (Avator != other.Avator) return false;
      if (Email != other.Email) return false;
      if (EmailVerified != other.EmailVerified) return false;
      if(!phoneNumber_.Equals(other.phoneNumber_)) return false;
      if (Gender != other.Gender) return false;
      if (!object.Equals(Birthday, other.Birthday)) return false;
      if(!addresses_.Equals(other.addresses_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Height != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Height);
      if (Weight != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Weight);
      if (Avator.Length != 0) hash ^= Avator.GetHashCode();
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (EmailVerified != false) hash ^= EmailVerified.GetHashCode();
      hash ^= phoneNumber_.GetHashCode();
      if (Gender != global::My.Project.Gender.NotSpecified) hash ^= Gender.GetHashCode();
      if (birthday_ != null) hash ^= Birthday.GetHashCode();
      hash ^= addresses_.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Height != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Height);
      }
      if (Weight != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Weight);
      }
      if (Avator.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Avator);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Email);
      }
      if (EmailVerified != false) {
        output.WriteRawTag(56);
        output.WriteBool(EmailVerified);
      }
      phoneNumber_.WriteTo(output, _repeated_phoneNumber_codec);
      if (Gender != global::My.Project.Gender.NotSpecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Gender);
      }
      if (birthday_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Birthday);
      }
      addresses_.WriteTo(output, _repeated_addresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Id);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (Height != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(Height);
      }
      if (Weight != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(Weight);
      }
      if (Avator.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Avator);
      }
      if (Email.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Email);
      }
      if (EmailVerified != false) {
        output.WriteRawTag(56);
        output.WriteBool(EmailVerified);
      }
      phoneNumber_.WriteTo(ref output, _repeated_phoneNumber_codec);
      if (Gender != global::My.Project.Gender.NotSpecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) Gender);
      }
      if (birthday_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(Birthday);
      }
      addresses_.WriteTo(ref output, _repeated_addresses_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Height != 0F) {
        size += 1 + 4;
      }
      if (Weight != 0F) {
        size += 1 + 4;
      }
      if (Avator.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Avator);
      }
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (EmailVerified != false) {
        size += 1 + 1;
      }
      size += phoneNumber_.CalculateSize(_repeated_phoneNumber_codec);
      if (Gender != global::My.Project.Gender.NotSpecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Gender);
      }
      if (birthday_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Birthday);
      }
      size += addresses_.CalculateSize(_repeated_addresses_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Height != 0F) {
        Height = other.Height;
      }
      if (other.Weight != 0F) {
        Weight = other.Weight;
      }
      if (other.Avator.Length != 0) {
        Avator = other.Avator;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.EmailVerified != false) {
        EmailVerified = other.EmailVerified;
      }
      phoneNumber_.Add(other.phoneNumber_);
      if (other.Gender != global::My.Project.Gender.NotSpecified) {
        Gender = other.Gender;
      }
      if (other.birthday_ != null) {
        if (birthday_ == null) {
          Birthday = new global::Date();
        }
        Birthday.MergeFrom(other.Birthday);
      }
      addresses_.Add(other.addresses_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 29: {
            Height = input.ReadFloat();
            break;
          }
          case 37: {
            Weight = input.ReadFloat();
            break;
          }
          case 42: {
            Avator = input.ReadBytes();
            break;
          }
          case 50: {
            Email = input.ReadString();
            break;
          }
          case 56: {
            EmailVerified = input.ReadBool();
            break;
          }
          case 66: {
            phoneNumber_.AddEntriesFrom(input, _repeated_phoneNumber_codec);
            break;
          }
          case 88: {
            Gender = (global::My.Project.Gender) input.ReadEnum();
            break;
          }
          case 98: {
            if (birthday_ == null) {
              Birthday = new global::Date();
            }
            input.ReadMessage(Birthday);
            break;
          }
          case 106: {
            addresses_.AddEntriesFrom(input, _repeated_addresses_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Id = input.ReadInt32();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
          case 29: {
            Height = input.ReadFloat();
            break;
          }
          case 37: {
            Weight = input.ReadFloat();
            break;
          }
          case 42: {
            Avator = input.ReadBytes();
            break;
          }
          case 50: {
            Email = input.ReadString();
            break;
          }
          case 56: {
            EmailVerified = input.ReadBool();
            break;
          }
          case 66: {
            phoneNumber_.AddEntriesFrom(ref input, _repeated_phoneNumber_codec);
            break;
          }
          case 88: {
            Gender = (global::My.Project.Gender) input.ReadEnum();
            break;
          }
          case 98: {
            if (birthday_ == null) {
              Birthday = new global::Date();
            }
            input.ReadMessage(Birthday);
            break;
          }
          case 106: {
            addresses_.AddEntriesFrom(ref input, _repeated_addresses_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public sealed partial class Address : pb::IMessage<Address>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Address> _parser = new pb::MessageParser<Address>(() => new Address());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Address> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::My.Project.Person.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Address() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Address(Address other) : this() {
          province_ = other.province_;
          code_ = other.code_;
          zipCode_ = other.zipCode_;
          street_ = other.street_;
          number_ = other.number_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Address Clone() {
          return new Address(this);
        }

        /// <summary>Field number for the "province" field.</summary>
        public const int ProvinceFieldNumber = 1;
        private string province_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Province {
          get { return province_; }
          set {
            province_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "code" field.</summary>
        public const int CodeFieldNumber = 2;
        private string code_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Code {
          get { return code_; }
          set {
            code_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "zip_code" field.</summary>
        public const int ZipCodeFieldNumber = 3;
        private string zipCode_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ZipCode {
          get { return zipCode_; }
          set {
            zipCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "street" field.</summary>
        public const int StreetFieldNumber = 4;
        private string street_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Street {
          get { return street_; }
          set {
            street_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 5;
        private string number_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Number {
          get { return number_; }
          set {
            number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Address);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Address other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Province != other.Province) return false;
          if (Code != other.Code) return false;
          if (ZipCode != other.ZipCode) return false;
          if (Street != other.Street) return false;
          if (Number != other.Number) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Province.Length != 0) hash ^= Province.GetHashCode();
          if (Code.Length != 0) hash ^= Code.GetHashCode();
          if (ZipCode.Length != 0) hash ^= ZipCode.GetHashCode();
          if (Street.Length != 0) hash ^= Street.GetHashCode();
          if (Number.Length != 0) hash ^= Number.GetHashCode();
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
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Province.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Province);
          }
          if (Code.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Code);
          }
          if (ZipCode.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ZipCode);
          }
          if (Street.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Street);
          }
          if (Number.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Number);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Province.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Province);
          }
          if (Code.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(Code);
          }
          if (ZipCode.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(ZipCode);
          }
          if (Street.Length != 0) {
            output.WriteRawTag(34);
            output.WriteString(Street);
          }
          if (Number.Length != 0) {
            output.WriteRawTag(42);
            output.WriteString(Number);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Province.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Province);
          }
          if (Code.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Code);
          }
          if (ZipCode.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ZipCode);
          }
          if (Street.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Street);
          }
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Address other) {
          if (other == null) {
            return;
          }
          if (other.Province.Length != 0) {
            Province = other.Province;
          }
          if (other.Code.Length != 0) {
            Code = other.Code;
          }
          if (other.ZipCode.Length != 0) {
            ZipCode = other.ZipCode;
          }
          if (other.Street.Length != 0) {
            Street = other.Street;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Province = input.ReadString();
                break;
              }
              case 18: {
                Code = input.ReadString();
                break;
              }
              case 26: {
                ZipCode = input.ReadString();
                break;
              }
              case 34: {
                Street = input.ReadString();
                break;
              }
              case 42: {
                Number = input.ReadString();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                Province = input.ReadString();
                break;
              }
              case 18: {
                Code = input.ReadString();
                break;
              }
              case 26: {
                ZipCode = input.ReadString();
                break;
              }
              case 34: {
                Street = input.ReadString();
                break;
              }
              case 42: {
                Number = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
