// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/distance_view_service.proto
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

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to fetch distance views.
  /// </summary>
  public static partial class DistanceViewService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.DistanceViewService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest> __Marshaller_google_ads_googleads_v3_services_GetDistanceViewRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.DistanceView> __Marshaller_google_ads_googleads_v3_resources_DistanceView = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.DistanceView.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest, global::Google.Ads.GoogleAds.V3.Resources.DistanceView> __Method_GetDistanceView = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest, global::Google.Ads.GoogleAds.V3.Resources.DistanceView>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetDistanceView",
        __Marshaller_google_ads_googleads_v3_services_GetDistanceViewRequest,
        __Marshaller_google_ads_googleads_v3_resources_DistanceView);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.DistanceViewServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of DistanceViewService</summary>
    [grpc::BindServiceMethod(typeof(DistanceViewService), "BindService")]
    public abstract partial class DistanceViewServiceBase
    {
      /// <summary>
      /// Returns the attributes of the requested distance view.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.DistanceView> GetDistanceView(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for DistanceViewService</summary>
    public partial class DistanceViewServiceClient : grpc::ClientBase<DistanceViewServiceClient>
    {
      /// <summary>Creates a new client for DistanceViewService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public DistanceViewServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for DistanceViewService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public DistanceViewServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected DistanceViewServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected DistanceViewServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the attributes of the requested distance view.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.DistanceView GetDistanceView(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDistanceView(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the attributes of the requested distance view.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.DistanceView GetDistanceView(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetDistanceView, null, options, request);
      }
      /// <summary>
      /// Returns the attributes of the requested distance view.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.DistanceView> GetDistanceViewAsync(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetDistanceViewAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the attributes of the requested distance view.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.DistanceView> GetDistanceViewAsync(global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetDistanceView, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override DistanceViewServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new DistanceViewServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(DistanceViewServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetDistanceView, serviceImpl.GetDistanceView).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, DistanceViewServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetDistanceView, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Ads.GoogleAds.V3.Services.GetDistanceViewRequest, global::Google.Ads.GoogleAds.V3.Resources.DistanceView>(serviceImpl.GetDistanceView));
    }

  }
}
#endregion
