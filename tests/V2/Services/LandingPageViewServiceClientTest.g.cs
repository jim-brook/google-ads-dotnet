// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V2.Services;

namespace Google.Ads.GoogleAds.Tests.V2.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedLandingPageViewServiceClientTest
    {
        [Test]
        public void GetLandingPageViewRequestObject()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView response = client.GetLandingPageView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLandingPageViewRequestObjectAsync()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView responseCallSettings = await client.GetLandingPageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LandingPageView responseCancellationToken = await client.GetLandingPageViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLandingPageView()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView response = client.GetLandingPageView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLandingPageViewAsync()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView responseCallSettings = await client.GetLandingPageViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LandingPageView responseCancellationToken = await client.GetLandingPageViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetLandingPageViewResourceNames()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView response = client.GetLandingPageView(request.ResourceNameAsLandingPageViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetLandingPageViewResourceNamesAsync()
        {
            moq::Mock<LandingPageViewService.LandingPageViewServiceClient> mockGrpcClient = new moq::Mock<LandingPageViewService.LandingPageViewServiceClient>(moq::MockBehavior.Strict);
            GetLandingPageViewRequest request = new GetLandingPageViewRequest
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
            };
            gagvr::LandingPageView expectedResponse = new gagvr::LandingPageView
            {
                ResourceNameAsLandingPageViewName = gagvr::LandingPageViewName.FromCustomerLandingPageView("[CUSTOMER]", "[LANDING_PAGE_VIEW]"),
                UnexpandedFinalUrl = "unexpanded_final_url7d6e0a3e",
            };
            mockGrpcClient.Setup(x => x.GetLandingPageViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::LandingPageView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            LandingPageViewServiceClient client = new LandingPageViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::LandingPageView responseCallSettings = await client.GetLandingPageViewAsync(request.ResourceNameAsLandingPageViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::LandingPageView responseCancellationToken = await client.GetLandingPageViewAsync(request.ResourceNameAsLandingPageViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
