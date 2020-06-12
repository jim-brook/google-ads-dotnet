// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v2/services/ad_group_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V2.Services {
  /// <summary>
  /// Service to manage ad groups.
  /// </summary>
  public static partial class AdGroupService
  {
    static readonly string __ServiceName = "google.ads.googleads.v2.services.AdGroupService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest> __Marshaller_google_ads_googleads_v2_services_GetAdGroupRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Resources.AdGroup> __Marshaller_google_ads_googleads_v2_resources_AdGroup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Resources.AdGroup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest> __Marshaller_google_ads_googleads_v2_services_MutateAdGroupsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse> __Marshaller_google_ads_googleads_v2_services_MutateAdGroupsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroup> __Method_GetAdGroup = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroup>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroup",
        __Marshaller_google_ads_googleads_v2_services_GetAdGroupRequest,
        __Marshaller_google_ads_googleads_v2_resources_AdGroup);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse> __Method_MutateAdGroups = new grpc::Method<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroups",
        __Marshaller_google_ads_googleads_v2_services_MutateAdGroupsRequest,
        __Marshaller_google_ads_googleads_v2_services_MutateAdGroupsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V2.Services.AdGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupService</summary>
    [grpc::BindServiceMethod(typeof(AdGroupService), "BindService")]
    public abstract partial class AdGroupServiceBase
    {
      /// <summary>
      /// Returns the requested ad group in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Resources.AdGroup> GetAdGroup(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates, updates, or removes ad groups. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse> MutateAdGroups(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupService</summary>
    public partial class AdGroupServiceClient : grpc::ClientBase<AdGroupServiceClient>
    {
      /// <summary>Creates a new client for AdGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdGroup GetAdGroup(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroup(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Resources.AdGroup GetAdGroup(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroup, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdGroup> GetAdGroupAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Resources.AdGroup> GetAdGroupAsync(global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroup, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad groups. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse MutateAdGroups(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroups(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad groups. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse MutateAdGroups(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroups, null, options, request);
      }
      /// <summary>
      /// Creates, updates, or removes ad groups. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse> MutateAdGroupsAsync(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates, updates, or removes ad groups. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse> MutateAdGroupsAsync(global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroups, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroup, serviceImpl.GetAdGroup)
          .AddMethod(__Method_MutateAdGroups, serviceImpl.MutateAdGroups).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroup, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V2.Services.GetAdGroupRequest, global::Google.Ads.GoogleAds.V2.Resources.AdGroup>(serviceImpl.GetAdGroup));
      serviceBinder.AddMethod(__Method_MutateAdGroups, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsRequest, global::Google.Ads.GoogleAds.V2.Services.MutateAdGroupsResponse>(serviceImpl.MutateAdGroups));
    }

  }
}
#endregion
