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

using gagve = Google.Ads.GoogleAds.V1.Enums;
using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V1.Services;

namespace Google.Ads.GoogleAds.Tests.V1.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCustomerManagerLinkServiceClientTest
    {
        [Test]
        public void GetCustomerManagerLinkRequestObject()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerManagerLinkRequestObjectAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerManagerLink()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerManagerLinkAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCustomerManagerLinkResourceNames()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink response = client.GetCustomerManagerLink(request.ResourceNameAsCustomerManagerLinkName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task GetCustomerManagerLinkResourceNamesAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            GetCustomerManagerLinkRequest request = new GetCustomerManagerLinkRequest
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
            };
            gagvr::CustomerManagerLink expectedResponse = new gagvr::CustomerManagerLink
            {
                ResourceNameAsCustomerManagerLinkName = gagvr::CustomerManagerLinkName.FromCustomerCustomerManagerLink("[CUSTOMER]", "[CUSTOMER_MANAGER_LINK]"),
                ManagerCustomer = "manager_customer3075601e",
                ManagerLinkId = 1955158851327798968L,
                Status = gagve::ManagerLinkStatusEnum.Types.ManagerLinkStatus.Inactive,
            };
            mockGrpcClient.Setup(x => x.GetCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::CustomerManagerLink>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::CustomerManagerLink responseCallSettings = await client.GetCustomerManagerLinkAsync(request.ResourceNameAsCustomerManagerLinkName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::CustomerManagerLink responseCancellationToken = await client.GetCustomerManagerLinkAsync(request.ResourceNameAsCustomerManagerLinkName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerManagerLinkRequestObject()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCustomerManagerLinkRequestObjectAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse responseCallSettings = await client.MutateCustomerManagerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerManagerLinkResponse responseCancellationToken = await client.MutateCustomerManagerLinkAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCustomerManagerLink()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLink(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse response = client.MutateCustomerManagerLink(request.CustomerId, request.Operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async stt::Task MutateCustomerManagerLinkAsync()
        {
            moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient> mockGrpcClient = new moq::Mock<CustomerManagerLinkService.CustomerManagerLinkServiceClient>(moq::MockBehavior.Strict);
            MutateCustomerManagerLinkRequest request = new MutateCustomerManagerLinkRequest
            {
                CustomerId = "customer_id3b3724cb",
                Operations =
                {
                    new CustomerManagerLinkOperation(),
                },
            };
            MutateCustomerManagerLinkResponse expectedResponse = new MutateCustomerManagerLinkResponse
            {
                Results =
                {
                    new MutateCustomerManagerLinkResult(),
                },
            };
            mockGrpcClient.Setup(x => x.MutateCustomerManagerLinkAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MutateCustomerManagerLinkResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CustomerManagerLinkServiceClient client = new CustomerManagerLinkServiceClientImpl(mockGrpcClient.Object, null);
            MutateCustomerManagerLinkResponse responseCallSettings = await client.MutateCustomerManagerLinkAsync(request.CustomerId, request.Operations, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            MutateCustomerManagerLinkResponse responseCancellationToken = await client.MutateCustomerManagerLinkAsync(request.CustomerId, request.Operations, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
