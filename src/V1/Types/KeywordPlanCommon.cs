// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/common/keyword_plan_common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/common/keyword_plan_common.proto</summary>
  public static partial class KeywordPlanCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/common/keyword_plan_common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KeywordPlanCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9jb21tb24va2V5d29yZF9wbGFu",
            "X2NvbW1vbi5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuY29tbW9u",
            "GkJnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lbnVtcy9rZXl3b3JkX3BsYW5f",
            "Y29tcGV0aXRpb25fbGV2ZWwucHJvdG8aHmdvb2dsZS9wcm90b2J1Zi93cmFw",
            "cGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byLKAQoc",
            "S2V5d29yZFBsYW5IaXN0b3JpY2FsTWV0cmljcxI5ChRhdmdfbW9udGhseV9z",
            "ZWFyY2hlcxgBIAEoCzIbLmdvb2dsZS5wcm90b2J1Zi5JbnQ2NFZhbHVlEm8K",
            "C2NvbXBldGl0aW9uGAIgASgOMlouZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEu",
            "ZW51bXMuS2V5d29yZFBsYW5Db21wZXRpdGlvbkxldmVsRW51bS5LZXl3b3Jk",
            "UGxhbkNvbXBldGl0aW9uTGV2ZWxC8QEKImNvbS5nb29nbGUuYWRzLmdvb2ds",
            "ZWFkcy52MS5jb21tb25CFktleXdvcmRQbGFuQ29tbW9uUHJvdG9QAVpEZ29v",
            "Z2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xl",
            "YWRzL3YxL2NvbW1vbjtjb21tb26iAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMS5Db21tb27KAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMVxDb21t",
            "b27qAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6Q29tbW9uYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Common.KeywordPlanHistoricalMetrics), global::Google.Ads.GoogleAds.V1.Common.KeywordPlanHistoricalMetrics.Parser, new[]{ "AvgMonthlySearches", "Competition" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Historical metrics specific to the targeting options selected.
  /// Targeting options include geographies, network, etc.
  /// Refer to https://support.google.com/google-ads/answer/3022575 for more
  /// details.
  /// </summary>
  public sealed partial class KeywordPlanHistoricalMetrics : pb::IMessage<KeywordPlanHistoricalMetrics> {
    private static readonly pb::MessageParser<KeywordPlanHistoricalMetrics> _parser = new pb::MessageParser<KeywordPlanHistoricalMetrics>(() => new KeywordPlanHistoricalMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeywordPlanHistoricalMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Common.KeywordPlanCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics(KeywordPlanHistoricalMetrics other) : this() {
      AvgMonthlySearches = other.AvgMonthlySearches;
      competition_ = other.competition_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeywordPlanHistoricalMetrics Clone() {
      return new KeywordPlanHistoricalMetrics(this);
    }

    /// <summary>Field number for the "avg_monthly_searches" field.</summary>
    public const int AvgMonthlySearchesFieldNumber = 1;
    private static readonly pb::FieldCodec<long?> _single_avgMonthlySearches_codec = pb::FieldCodec.ForStructWrapper<long>(10);
    private long? avgMonthlySearches_;
    /// <summary>
    /// Approximate number of monthly searches on this query averaged
    /// for the past 12 months.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? AvgMonthlySearches {
      get { return avgMonthlySearches_; }
      set {
        avgMonthlySearches_ = value;
      }
    }


    /// <summary>Field number for the "competition" field.</summary>
    public const int CompetitionFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel competition_ = global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified;
    /// <summary>
    /// The competition level for the query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel Competition {
      get { return competition_; }
      set {
        competition_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeywordPlanHistoricalMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeywordPlanHistoricalMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AvgMonthlySearches != other.AvgMonthlySearches) return false;
      if (Competition != other.Competition) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (avgMonthlySearches_ != null) hash ^= AvgMonthlySearches.GetHashCode();
      if (Competition != global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) hash ^= Competition.GetHashCode();
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
      if (avgMonthlySearches_ != null) {
        _single_avgMonthlySearches_codec.WriteTagAndValue(output, AvgMonthlySearches);
      }
      if (Competition != global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Competition);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (avgMonthlySearches_ != null) {
        size += _single_avgMonthlySearches_codec.CalculateSizeWithTag(AvgMonthlySearches);
      }
      if (Competition != global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Competition);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeywordPlanHistoricalMetrics other) {
      if (other == null) {
        return;
      }
      if (other.avgMonthlySearches_ != null) {
        if (avgMonthlySearches_ == null || other.AvgMonthlySearches != 0L) {
          AvgMonthlySearches = other.AvgMonthlySearches;
        }
      }
      if (other.Competition != global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel.Unspecified) {
        Competition = other.Competition;
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
            long? value = _single_avgMonthlySearches_codec.Read(input);
            if (avgMonthlySearches_ == null || value != 0L) {
              AvgMonthlySearches = value;
            }
            break;
          }
          case 16: {
            Competition = (global::Google.Ads.GoogleAds.V1.Enums.KeywordPlanCompetitionLevelEnum.Types.KeywordPlanCompetitionLevel) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
