// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/enums/bid_modifier_source.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V2.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v2/enums/bid_modifier_source.proto</summary>
  public static partial class BidModifierSourceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v2/enums/bid_modifier_source.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BidModifierSourceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92Mi9lbnVtcy9iaWRfbW9kaWZpZXJf",
            "c291cmNlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52Mi5lbnVtcxoc",
            "Z29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byJmChVCaWRNb2RpZmllclNv",
            "dXJjZUVudW0iTQoRQmlkTW9kaWZpZXJTb3VyY2USDwoLVU5TUEVDSUZJRUQQ",
            "ABILCgdVTktOT1dOEAESDAoIQ0FNUEFJR04QAhIMCghBRF9HUk9VUBADQusB",
            "CiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjIuZW51bXNCFkJpZE1vZGlm",
            "aWVyU291cmNlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YyL2VudW1zO2VudW1zogIDR0FB",
            "qgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjIuRW51bXPKAh1Hb29nbGVcQWRz",
            "XEdvb2dsZUFkc1xWMlxFbnVtc+oCIUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYyOjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V2.Enums.BidModifierSourceEnum), global::Google.Ads.GoogleAds.V2.Enums.BidModifierSourceEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V2.Enums.BidModifierSourceEnum.Types.BidModifierSource) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible bid modifier sources.
  /// </summary>
  public sealed partial class BidModifierSourceEnum : pb::IMessage<BidModifierSourceEnum> {
    private static readonly pb::MessageParser<BidModifierSourceEnum> _parser = new pb::MessageParser<BidModifierSourceEnum>(() => new BidModifierSourceEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BidModifierSourceEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V2.Enums.BidModifierSourceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BidModifierSourceEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BidModifierSourceEnum(BidModifierSourceEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BidModifierSourceEnum Clone() {
      return new BidModifierSourceEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BidModifierSourceEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BidModifierSourceEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BidModifierSourceEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BidModifierSourceEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible bid modifier sources.
      /// </summary>
      public enum BidModifierSource {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The bid modifier is specified at the campaign level, on the campaign
        /// level criterion.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN")] Campaign = 2,
        /// <summary>
        /// The bid modifier is specified (overridden) at the ad group level.
        /// </summary>
        [pbr::OriginalName("AD_GROUP")] AdGroup = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code