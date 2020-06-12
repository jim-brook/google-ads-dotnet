// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/resources/ad_group_label.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/resources/ad_group_label.proto</summary>
  public static partial class AdGroupLabelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/resources/ad_group_label.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupLabelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXMvYWRfZ3JvdXBf",
            "bGFiZWwucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYyLnJlc291cmNl",
            "cxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZZ29vZ2xlL2Fw",
            "aS9yZXNvdXJjZS5wcm90bxoeZ29vZ2xlL3Byb3RvYnVmL3dyYXBwZXJzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIuQCCgxBZEdyb3Vw",
            "TGFiZWwSRAoNcmVzb3VyY2VfbmFtZRgBIAEoCUIt4EEF+kEnCiVnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cExhYmVsElgKCGFkX2dyb3VwGAIg",
            "ASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQijgQQX6QSIKIGdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9BZEdyb3VwElMKBWxhYmVsGAMgASgL",
            "MhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQibgQQX6QSAKHmdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9MYWJlbDpf6kFcCiVnb29nbGVhZHMuZ29v",
            "Z2xlYXBpcy5jb20vQWRHcm91cExhYmVsEjNjdXN0b21lcnMve2N1c3RvbWVy",
            "fS9hZEdyb3VwTGFiZWxzL3thZF9ncm91cF9sYWJlbH1C/gEKJWNvbS5nb29n",
            "bGUuYWRzLmdvb2dsZWFkcy52Mi5yZXNvdXJjZXNCEUFkR3JvdXBMYWJlbFBy",
            "b3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMv",
            "YWRzL2dvb2dsZWFkcy92Mi9yZXNvdXJjZXM7cmVzb3VyY2VzogIDR0FBqgIh",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuUmVzb3VyY2VzygIhR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjJcUmVzb3VyY2Vz6gIlR29vZ2xlOjpBZHM6Okdvb2ds",
            "ZUFkczo6VjI6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Resources.AdGroupLabel), global::Google.Ads.GoogleAds.V2.Resources.AdGroupLabel.Parser, new[]{ "ResourceName", "AdGroup", "Label" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A relationship between an ad group and a label.
  /// </summary>
  public sealed partial class AdGroupLabel : pb::IMessage<AdGroupLabel> {
    private static readonly pb::MessageParser<AdGroupLabel> _parser = new pb::MessageParser<AdGroupLabel>(() => new AdGroupLabel());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdGroupLabel> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Resources.AdGroupLabelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabel() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabel(AdGroupLabel other) : this() {
      resourceName_ = other.resourceName_;
      AdGroup = other.AdGroup;
      Label = other.Label;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdGroupLabel Clone() {
      return new AdGroupLabel(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group label.
    /// Ad group label resource names have the form:
    /// `customers/{customer_id}/adGroupLabels/{ad_group_id}~{label_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string adGroup_;
    /// <summary>
    /// Immutable. The ad group to which the label is attached.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = value;
      }
    }


    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_label_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string label_;
    /// <summary>
    /// Immutable. The label assigned to the ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdGroupLabel);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdGroupLabel other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (adGroup_ != null) hash ^= AdGroup.GetHashCode();
      if (label_ != null) hash ^= Label.GetHashCode();
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
      if (adGroup_ != null) {
        _single_adGroup_codec.WriteTagAndValue(output, AdGroup);
      }
      if (label_ != null) {
        _single_label_codec.WriteTagAndValue(output, Label);
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
      if (adGroup_ != null) {
        size += _single_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (label_ != null) {
        size += _single_label_codec.CalculateSizeWithTag(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdGroupLabel other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.adGroup_ != null) {
        if (adGroup_ == null || other.AdGroup != "") {
          AdGroup = other.AdGroup;
        }
      }
      if (other.label_ != null) {
        if (label_ == null || other.Label != "") {
          Label = other.Label;
        }
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
          case 18: {
            string value = _single_adGroup_codec.Read(input);
            if (adGroup_ == null || value != "") {
              AdGroup = value;
            }
            break;
          }
          case 26: {
            string value = _single_label_codec.Read(input);
            if (label_ == null || value != "") {
              Label = value;
            }
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
