// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/resources/feed_item_target.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/resources/feed_item_target.proto</summary>
  public static partial class FeedItemTargetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/resources/feed_item_target.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemTargetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXMvZmVlZF9pdGVt",
            "X3RhcmdldC5wcm90bxIhZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEucmVzb3Vy",
            "Y2VzGi1nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24vY3JpdGVyaWEu",
            "cHJvdG8aO2dvb2dsZS9hZHMvZ29vZ2xlYWRzL3YxL2VudW1zL2ZlZWRfaXRl",
            "bV90YXJnZXRfZGV2aWNlLnByb3RvGjlnb29nbGUvYWRzL2dvb2dsZWFkcy92",
            "MS9lbnVtcy9mZWVkX2l0ZW1fdGFyZ2V0X3R5cGUucHJvdG8aH2dvb2dsZS9h",
            "cGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2Uu",
            "cHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byLyBwoORmVlZEl0ZW1UYXJnZXQSRgoN",
            "cmVzb3VyY2VfbmFtZRgBIAEoCUIv4EEF+kEpCidnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vRmVlZEl0ZW1UYXJnZXQSWgoJZmVlZF9pdGVtGAIgASgLMhwu",
            "Z29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQingQQX6QSMKIWdvb2dsZWFk",
            "cy5nb29nbGVhcGlzLmNvbS9GZWVkSXRlbRJsChVmZWVkX2l0ZW1fdGFyZ2V0",
            "X3R5cGUYAyABKA4ySC5nb29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtcy5G",
            "ZWVkSXRlbVRhcmdldFR5cGVFbnVtLkZlZWRJdGVtVGFyZ2V0VHlwZUID4EED",
            "Ej0KE2ZlZWRfaXRlbV90YXJnZXRfaWQYBiABKAsyGy5nb29nbGUucHJvdG9i",
            "dWYuSW50NjRWYWx1ZUID4EEDElsKCGNhbXBhaWduGAQgASgLMhwuZ29vZ2xl",
            "LnByb3RvYnVmLlN0cmluZ1ZhbHVlQingQQX6QSMKIWdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9DYW1wYWlnbkgAEloKCGFkX2dyb3VwGAUgASgLMhwuZ29v",
            "Z2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlQijgQQX6QSIKIGdvb2dsZWFkcy5n",
            "b29nbGVhcGlzLmNvbS9BZEdyb3VwSAASQwoHa2V5d29yZBgHIAEoCzIrLmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmNvbW1vbi5LZXl3b3JkSW5mb0ID4EEF",
            "SAASbwoTZ2VvX3RhcmdldF9jb25zdGFudBgIIAEoCzIcLmdvb2dsZS5wcm90",
            "b2J1Zi5TdHJpbmdWYWx1ZUIy4EEF+kEsCipnb29nbGVhZHMuZ29vZ2xlYXBp",
            "cy5jb20vR2VvVGFyZ2V0Q29uc3RhbnRIABJjCgZkZXZpY2UYCSABKA4yTC5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MS5lbnVtcy5GZWVkSXRlbVRhcmdldERl",
            "dmljZUVudW0uRmVlZEl0ZW1UYXJnZXREZXZpY2VCA+BBBUgAEkoKC2FkX3Nj",
            "aGVkdWxlGAogASgLMi4uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuY29tbW9u",
            "LkFkU2NoZWR1bGVJbmZvQgPgQQVIADpl6kFiCidnb29nbGVhZHMuZ29vZ2xl",
            "YXBpcy5jb20vRmVlZEl0ZW1UYXJnZXQSN2N1c3RvbWVycy97Y3VzdG9tZXJ9",
            "L2ZlZWRJdGVtVGFyZ2V0cy97ZmVlZF9pdGVtX3RhcmdldH1CCAoGdGFyZ2V0",
            "QoACCiVjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEucmVzb3VyY2VzQhNG",
            "ZWVkSXRlbVRhcmdldFByb3RvUAFaSmdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9yZXNvdXJjZXM7cmVz",
            "b3VyY2VzogIDR0FBqgIhR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuUmVzb3Vy",
            "Y2VzygIhR29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcUmVzb3VyY2Vz6gIlR29v",
            "Z2xlOjpBZHM6Okdvb2dsZUFkczo6VjE6OlJlc291cmNlc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetDeviceReflection.Descriptor, global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Resources.FeedItemTarget), global::Google.Ads.GoogleAds.V1.Resources.FeedItemTarget.Parser, new[]{ "ResourceName", "FeedItem", "FeedItemTargetType", "FeedItemTargetId", "Campaign", "AdGroup", "Keyword", "GeoTargetConstant", "Device", "AdSchedule" }, new[]{ "Target" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A feed item target.
  /// </summary>
  public sealed partial class FeedItemTarget : pb::IMessage<FeedItemTarget> {
    private static readonly pb::MessageParser<FeedItemTarget> _parser = new pb::MessageParser<FeedItemTarget>(() => new FeedItemTarget());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemTarget> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Resources.FeedItemTargetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTarget() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTarget(FeedItemTarget other) : this() {
      resourceName_ = other.resourceName_;
      FeedItem = other.FeedItem;
      feedItemTargetType_ = other.feedItemTargetType_;
      FeedItemTargetId = other.FeedItemTargetId;
      switch (other.TargetCase) {
        case TargetOneofCase.Campaign:
          Campaign = other.Campaign;
          break;
        case TargetOneofCase.AdGroup:
          AdGroup = other.AdGroup;
          break;
        case TargetOneofCase.Keyword:
          Keyword = other.Keyword.Clone();
          break;
        case TargetOneofCase.GeoTargetConstant:
          GeoTargetConstant = other.GeoTargetConstant;
          break;
        case TargetOneofCase.Device:
          Device = other.Device;
          break;
        case TargetOneofCase.AdSchedule:
          AdSchedule = other.AdSchedule.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTarget Clone() {
      return new FeedItemTarget(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the feed item target.
    /// Feed item target resource names have the form:
    /// `customers/{customer_id}/feedItemTargets/{feed_id}~{feed_item_id}~{feed_item_target_type}~{feed_item_target_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "feed_item" field.</summary>
    public const int FeedItemFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_feedItem_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string feedItem_;
    /// <summary>
    /// Immutable. The feed item to which this feed item target belongs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FeedItem {
      get { return feedItem_; }
      set {
        feedItem_ = value;
      }
    }


    /// <summary>Field number for the "feed_item_target_type" field.</summary>
    public const int FeedItemTargetTypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType feedItemTargetType_ = global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified;
    /// <summary>
    /// Output only. The target type of this feed item target. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType FeedItemTargetType {
      get { return feedItemTargetType_; }
      set {
        feedItemTargetType_ = value;
      }
    }

    /// <summary>Field number for the "feed_item_target_id" field.</summary>
    public const int FeedItemTargetIdFieldNumber = 6;
    private static readonly pb::FieldCodec<long?> _single_feedItemTargetId_codec = pb::FieldCodec.ForStructWrapper<long>(50);
    private long? feedItemTargetId_;
    /// <summary>
    /// Output only. The ID of the targeted resource. This field is read-only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? FeedItemTargetId {
      get { return feedItemTargetId_; }
      set {
        feedItemTargetId_ = value;
      }
    }


    /// <summary>Field number for the "campaign" field.</summary>
    public const int CampaignFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _oneof_campaign_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    /// <summary>
    /// Immutable. The targeted campaign.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Campaign {
      get { return targetCase_ == TargetOneofCase.Campaign ? (string) target_ : (string) null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.Campaign;
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _oneof_adGroup_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    /// <summary>
    /// Immutable. The targeted ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AdGroup {
      get { return targetCase_ == TargetOneofCase.AdGroup ? (string) target_ : (string) null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.AdGroup;
      }
    }

    /// <summary>Field number for the "keyword" field.</summary>
    public const int KeywordFieldNumber = 7;
    /// <summary>
    /// Immutable. The targeted keyword.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.KeywordInfo Keyword {
      get { return targetCase_ == TargetOneofCase.Keyword ? (global::Google.Ads.GoogleAds.V1.Common.KeywordInfo) target_ : null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.Keyword;
      }
    }

    /// <summary>Field number for the "geo_target_constant" field.</summary>
    public const int GeoTargetConstantFieldNumber = 8;
    private static readonly pb::FieldCodec<string> _oneof_geoTargetConstant_codec = pb::FieldCodec.ForClassWrapper<string>(66);
    /// <summary>
    /// Immutable. The targeted geo target constant resource name.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GeoTargetConstant {
      get { return targetCase_ == TargetOneofCase.GeoTargetConstant ? (string) target_ : (string) null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.GeoTargetConstant;
      }
    }

    /// <summary>Field number for the "device" field.</summary>
    public const int DeviceFieldNumber = 9;
    /// <summary>
    /// Immutable. The targeted device.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice Device {
      get { return targetCase_ == TargetOneofCase.Device ? (global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice) target_ : global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetDeviceEnum.Types.FeedItemTargetDevice.Unspecified; }
      set {
        target_ = value;
        targetCase_ = TargetOneofCase.Device;
      }
    }

    /// <summary>Field number for the "ad_schedule" field.</summary>
    public const int AdScheduleFieldNumber = 10;
    /// <summary>
    /// Immutable. The targeted schedule.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Common.AdScheduleInfo AdSchedule {
      get { return targetCase_ == TargetOneofCase.AdSchedule ? (global::Google.Ads.GoogleAds.V1.Common.AdScheduleInfo) target_ : null; }
      set {
        target_ = value;
        targetCase_ = value == null ? TargetOneofCase.None : TargetOneofCase.AdSchedule;
      }
    }

    private object target_;
    /// <summary>Enum of possible cases for the "target" oneof.</summary>
    public enum TargetOneofCase {
      None = 0,
      Campaign = 4,
      AdGroup = 5,
      Keyword = 7,
      GeoTargetConstant = 8,
      Device = 9,
      AdSchedule = 10,
    }
    private TargetOneofCase targetCase_ = TargetOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TargetOneofCase TargetCase {
      get { return targetCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTarget() {
      targetCase_ = TargetOneofCase.None;
      target_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemTarget);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemTarget other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (FeedItem != other.FeedItem) return false;
      if (FeedItemTargetType != other.FeedItemTargetType) return false;
      if (FeedItemTargetId != other.FeedItemTargetId) return false;
      if (Campaign != other.Campaign) return false;
      if (AdGroup != other.AdGroup) return false;
      if (!object.Equals(Keyword, other.Keyword)) return false;
      if (GeoTargetConstant != other.GeoTargetConstant) return false;
      if (Device != other.Device) return false;
      if (!object.Equals(AdSchedule, other.AdSchedule)) return false;
      if (TargetCase != other.TargetCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (feedItem_ != null) hash ^= FeedItem.GetHashCode();
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) hash ^= FeedItemTargetType.GetHashCode();
      if (feedItemTargetId_ != null) hash ^= FeedItemTargetId.GetHashCode();
      if (targetCase_ == TargetOneofCase.Campaign) hash ^= Campaign.GetHashCode();
      if (targetCase_ == TargetOneofCase.AdGroup) hash ^= AdGroup.GetHashCode();
      if (targetCase_ == TargetOneofCase.Keyword) hash ^= Keyword.GetHashCode();
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) hash ^= GeoTargetConstant.GetHashCode();
      if (targetCase_ == TargetOneofCase.Device) hash ^= Device.GetHashCode();
      if (targetCase_ == TargetOneofCase.AdSchedule) hash ^= AdSchedule.GetHashCode();
      hash ^= (int) targetCase_;
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
      if (feedItem_ != null) {
        _single_feedItem_codec.WriteTagAndValue(output, FeedItem);
      }
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) FeedItemTargetType);
      }
      if (targetCase_ == TargetOneofCase.Campaign) {
        _oneof_campaign_codec.WriteTagAndValue(output, (string) target_);
      }
      if (targetCase_ == TargetOneofCase.AdGroup) {
        _oneof_adGroup_codec.WriteTagAndValue(output, (string) target_);
      }
      if (feedItemTargetId_ != null) {
        _single_feedItemTargetId_codec.WriteTagAndValue(output, FeedItemTargetId);
      }
      if (targetCase_ == TargetOneofCase.Keyword) {
        output.WriteRawTag(58);
        output.WriteMessage(Keyword);
      }
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) {
        _oneof_geoTargetConstant_codec.WriteTagAndValue(output, (string) target_);
      }
      if (targetCase_ == TargetOneofCase.Device) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Device);
      }
      if (targetCase_ == TargetOneofCase.AdSchedule) {
        output.WriteRawTag(82);
        output.WriteMessage(AdSchedule);
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
      if (feedItem_ != null) {
        size += _single_feedItem_codec.CalculateSizeWithTag(FeedItem);
      }
      if (FeedItemTargetType != global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FeedItemTargetType);
      }
      if (feedItemTargetId_ != null) {
        size += _single_feedItemTargetId_codec.CalculateSizeWithTag(FeedItemTargetId);
      }
      if (targetCase_ == TargetOneofCase.Campaign) {
        size += _oneof_campaign_codec.CalculateSizeWithTag(Campaign);
      }
      if (targetCase_ == TargetOneofCase.AdGroup) {
        size += _oneof_adGroup_codec.CalculateSizeWithTag(AdGroup);
      }
      if (targetCase_ == TargetOneofCase.Keyword) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Keyword);
      }
      if (targetCase_ == TargetOneofCase.GeoTargetConstant) {
        size += _oneof_geoTargetConstant_codec.CalculateSizeWithTag(GeoTargetConstant);
      }
      if (targetCase_ == TargetOneofCase.Device) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Device);
      }
      if (targetCase_ == TargetOneofCase.AdSchedule) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(AdSchedule);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeedItemTarget other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.feedItem_ != null) {
        if (feedItem_ == null || other.FeedItem != "") {
          FeedItem = other.FeedItem;
        }
      }
      if (other.FeedItemTargetType != global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType.Unspecified) {
        FeedItemTargetType = other.FeedItemTargetType;
      }
      if (other.feedItemTargetId_ != null) {
        if (feedItemTargetId_ == null || other.FeedItemTargetId != 0L) {
          FeedItemTargetId = other.FeedItemTargetId;
        }
      }
      switch (other.TargetCase) {
        case TargetOneofCase.Campaign:
          Campaign = other.Campaign;
          break;
        case TargetOneofCase.AdGroup:
          AdGroup = other.AdGroup;
          break;
        case TargetOneofCase.Keyword:
          if (Keyword == null) {
            Keyword = new global::Google.Ads.GoogleAds.V1.Common.KeywordInfo();
          }
          Keyword.MergeFrom(other.Keyword);
          break;
        case TargetOneofCase.GeoTargetConstant:
          GeoTargetConstant = other.GeoTargetConstant;
          break;
        case TargetOneofCase.Device:
          Device = other.Device;
          break;
        case TargetOneofCase.AdSchedule:
          if (AdSchedule == null) {
            AdSchedule = new global::Google.Ads.GoogleAds.V1.Common.AdScheduleInfo();
          }
          AdSchedule.MergeFrom(other.AdSchedule);
          break;
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
            string value = _single_feedItem_codec.Read(input);
            if (feedItem_ == null || value != "") {
              FeedItem = value;
            }
            break;
          }
          case 24: {
            FeedItemTargetType = (global::Google.Ads.GoogleAds.V1.Enums.FeedItemTargetTypeEnum.Types.FeedItemTargetType) input.ReadEnum();
            break;
          }
          case 34: {
            Campaign = _oneof_campaign_codec.Read(input);
            break;
          }
          case 42: {
            AdGroup = _oneof_adGroup_codec.Read(input);
            break;
          }
          case 50: {
            long? value = _single_feedItemTargetId_codec.Read(input);
            if (feedItemTargetId_ == null || value != 0L) {
              FeedItemTargetId = value;
            }
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V1.Common.KeywordInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.KeywordInfo();
            if (targetCase_ == TargetOneofCase.Keyword) {
              subBuilder.MergeFrom(Keyword);
            }
            input.ReadMessage(subBuilder);
            Keyword = subBuilder;
            break;
          }
          case 66: {
            GeoTargetConstant = _oneof_geoTargetConstant_codec.Read(input);
            break;
          }
          case 72: {
            target_ = input.ReadEnum();
            targetCase_ = TargetOneofCase.Device;
            break;
          }
          case 82: {
            global::Google.Ads.GoogleAds.V1.Common.AdScheduleInfo subBuilder = new global::Google.Ads.GoogleAds.V1.Common.AdScheduleInfo();
            if (targetCase_ == TargetOneofCase.AdSchedule) {
              subBuilder.MergeFrom(AdSchedule);
            }
            input.ReadMessage(subBuilder);
            AdSchedule = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
