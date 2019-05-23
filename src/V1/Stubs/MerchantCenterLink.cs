// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/merchant_center_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/merchant_center_link.proto</summary>
  public static partial class MerchantCenterLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/merchant_center_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MerchantCenterLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvbWVyY2hhbnRf",
            "Y2VudGVyX2xpbmsucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLnJl",
            "c291cmNlcxo/Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEvZW51bXMvbWVyY2hh",
            "bnRfY2VudGVyX2xpbmtfc3RhdHVzLnByb3RvGh5nb29nbGUvcHJvdG9idWYv",
            "d3JhcHBlcnMucHJvdG8aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8i",
            "/gEKEk1lcmNoYW50Q2VudGVyTGluaxIVCg1yZXNvdXJjZV9uYW1lGAEgASgJ",
            "EicKAmlkGAMgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWUSQgoc",
            "bWVyY2hhbnRfY2VudGVyX2FjY291bnRfbmFtZRgEIAEoCzIcLmdvb2dsZS5w",
            "cm90b2J1Zi5TdHJpbmdWYWx1ZRJkCgZzdGF0dXMYBSABKA4yVC5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52MS5lbnVtcy5NZXJjaGFudENlbnRlckxpbmtTdGF0",
            "dXNFbnVtLk1lcmNoYW50Q2VudGVyTGlua1N0YXR1c0KEAgolY29tLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYxLnJlc291cmNlc0IXTWVyY2hhbnRDZW50ZXJM",
            "aW5rUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvZ29vZ2xlYWRzL3YxL3Jlc291cmNlcztyZXNvdXJjZXOiAgNH",
            "QUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5WMS5SZXNvdXJjZXPKAiFHb29n",
            "bGVcQWRzXEdvb2dsZUFkc1xWMVxSZXNvdXJjZXPqAiVHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.MerchantCenterLinkStatusReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.MerchantCenterLink), global::Google.Ads.GoogleAds.V1.Resources.MerchantCenterLink.Parser, new[]{ "ResourceName", "Id", "MerchantCenterAccountName", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A data sharing connection, proposed or in use,
  /// between a Google Ads Customer and a Merchant Center account.
  /// </summary>
  public sealed partial class MerchantCenterLink : pb::IMessage<MerchantCenterLink> {
    private static readonly pb::MessageParser<MerchantCenterLink> _parser = new pb::MessageParser<MerchantCenterLink>(() => new MerchantCenterLink());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantCenterLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.MerchantCenterLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink(MerchantCenterLink other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      MerchantCenterAccountName = other.MerchantCenterAccountName;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink Clone() {
      return new MerchantCenterLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// The resource name of the merchant center link.
    /// Merchant center link resource names have the form:
    ///
    /// `customers/{customer_id}/merchantCenterLinks/{merchant_center_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 3;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(26);
    private long? id_;
    /// <summary>
    /// The ID of the Merchant Center account.
    /// This field is readonly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "merchant_center_account_name" field.</summary>
    public const int MerchantCenterAccountNameFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_merchantCenterAccountName_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string merchantCenterAccountName_;
    /// <summary>
    /// The name of the Merchant Center account.
    /// This field is readonly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MerchantCenterAccountName {
      get { return merchantCenterAccountName_; }
      set {
        merchantCenterAccountName_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V1.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus status_ = 0;
    /// <summary>
    /// The status of the link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantCenterLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantCenterLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (MerchantCenterAccountName != other.MerchantCenterAccountName) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (merchantCenterAccountName_ != null) hash ^= MerchantCenterAccountName.GetHashCode();
      if (Status != 0) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (merchantCenterAccountName_ != null) {
        _single_merchantCenterAccountName_codec.WriteTagAndValue(output, MerchantCenterAccountName);
      }
      if (Status != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (merchantCenterAccountName_ != null) {
        size += _single_merchantCenterAccountName_codec.CalculateSizeWithTag(MerchantCenterAccountName);
      }
      if (Status != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerchantCenterLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.merchantCenterAccountName_ != null) {
        if (merchantCenterAccountName_ == null || other.MerchantCenterAccountName != "") {
          MerchantCenterAccountName = other.MerchantCenterAccountName;
        }
      }
      if (other.Status != 0) {
        Status = other.Status;
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
            ResourceName = input.ReadString();
            break;
          }
          case 26: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 34: {
            string value = _single_merchantCenterAccountName_codec.Read(input);
            if (merchantCenterAccountName_ == null || value != "") {
              MerchantCenterAccountName = value;
            }
            break;
          }
          case 40: {
            status_ = (global::Google.Ads.GoogleAds.V1.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code