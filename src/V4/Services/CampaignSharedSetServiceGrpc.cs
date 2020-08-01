// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v4/services/campaign_shared_set_service.proto
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

namespace Google.Ads.GoogleAds.V4.Services {
  /// <summary>
  /// Service to manage campaign shared sets.
  /// </summary>
  public static partial class CampaignSharedSetService
  {
    static readonly string __ServiceName = "google.ads.googleads.v4.services.CampaignSharedSetService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest> __Marshaller_google_ads_googleads_v4_services_GetCampaignSharedSetRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet> __Marshaller_google_ads_googleads_v4_resources_CampaignSharedSet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest> __Marshaller_google_ads_googleads_v4_services_MutateCampaignSharedSetsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse> __Marshaller_google_ads_googleads_v4_services_MutateCampaignSharedSetsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet> __Method_GetCampaignSharedSet = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCampaignSharedSet",
        __Marshaller_google_ads_googleads_v4_services_GetCampaignSharedSetRequest,
        __Marshaller_google_ads_googleads_v4_resources_CampaignSharedSet);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse> __Method_MutateCampaignSharedSets = new grpc::Method<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignSharedSets",
        __Marshaller_google_ads_googleads_v4_services_MutateCampaignSharedSetsRequest,
        __Marshaller_google_ads_googleads_v4_services_MutateCampaignSharedSetsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V4.Services.CampaignSharedSetServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CampaignSharedSetService</summary>
    [grpc::BindServiceMethod(typeof(CampaignSharedSetService), "BindService")]
    public abstract partial class CampaignSharedSetServiceBase
    {
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet> GetCampaignSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CampaignSharedSetService</summary>
    public partial class CampaignSharedSetServiceClient : grpc::ClientBase<CampaignSharedSetServiceClient>
    {
      /// <summary>Creates a new client for CampaignSharedSetService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CampaignSharedSetServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CampaignSharedSetService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CampaignSharedSetServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CampaignSharedSetServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CampaignSharedSetServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet GetCampaignSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignSharedSet(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet GetCampaignSharedSet(global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCampaignSharedSet, null, options, request);
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet> GetCampaignSharedSetAsync(global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignSharedSetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign shared set in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet> GetCampaignSharedSetAsync(global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCampaignSharedSet, null, options, request);
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignSharedSets(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse MutateCampaignSharedSets(global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignSharedSets, null, options, request);
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignSharedSetsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates or removes campaign shared sets. Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignSharedSets, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CampaignSharedSetServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CampaignSharedSetServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CampaignSharedSetServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCampaignSharedSet, serviceImpl.GetCampaignSharedSet)
          .AddMethod(__Method_MutateCampaignSharedSets, serviceImpl.MutateCampaignSharedSets).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CampaignSharedSetServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCampaignSharedSet, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.GetCampaignSharedSetRequest, global::Google.Ads.GoogleAds.V4.Resources.CampaignSharedSet>(serviceImpl.GetCampaignSharedSet));
      serviceBinder.AddMethod(__Method_MutateCampaignSharedSets, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsRequest, global::Google.Ads.GoogleAds.V4.Services.MutateCampaignSharedSetsResponse>(serviceImpl.MutateCampaignSharedSets));
    }

  }
}
#endregion