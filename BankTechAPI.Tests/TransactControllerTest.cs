/*
 * BankTechAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using BankTechAPI.Standard;
using BankTechAPI.Standard.Utilities; 
using BankTechAPI.Standard.Http.Client;
using BankTechAPI.Standard.Http.Response;
using BankTechAPI.Tests.Helpers;
using NUnit.Framework;
using BankTechAPI.Standard;
using BankTechAPI.Standard.Controllers;
using BankTechAPI.Standard.Exceptions;

namespace BankTechAPI.Tests
{
    [TestFixture]
    public class TransactControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static TransactController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Transact;
        }

        /// <summary>
        /// TODO: Add description for test TestGetACollectionMatchingTheProvidedParameters 
        /// </summary>
        [Test]
        public async Task TestGetACollectionMatchingTheProvidedParameters() 
        {
            // Parameters for the API call
            string collectionIdentification = "<string>";
            double xApiVersion = 1.0;

            // Perform API call
            Standard.Models.CollectionReturned result = null;

            try
            {
                result = await controller.GetACollectionMatchingTheProvidedParametersAsync(collectionIdentification, xApiVersion);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"collection\": {\r\n    \"collectionIdentifications\": \"elit\",\r\n    \"contractReference\": \"ContractRef001\",\r\n    \"collectionReference\": \"CollectRef001\",\r\n    \"collectionCurrency\": \"ZAR\",\r\n    \"collectionAmount\": 21581117.095058784,\r\n    \"forDate\": \"2020-07-15\",\r\n    \"requestedActionDate\": \"2020-07-15\",\r\n    \"clientSegment\": \"Bad book\",\r\n    \"recall\": true,\r\n    \"collectionInstrument\": \"magna reprehenderit amet\",\r\n    \"trackingPeriod\": \"dol\",\r\n    \"submissionDate\": \"2020-07-15\",\r\n    \"actionDate\": \"2020-07-15\",\r\n    \"resultCode\": \"commodo sunt repr\",\r\n    \"resultDate\": \"2020-07-15\",\r\n    \"disputed\": true,\r\n    \"disputeCode\": \"sit\",\r\n    \"disputeDate\": \"2020-07-15\"\r\n  },\r\n  \"status\": 89917353,\r\n  \"title\": \"Ut minim enim\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestCreateNewEFTCollectionS 
        /// </summary>
        [Test]
        public async Task TestCreateNewEFTCollectionS() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;
            string contentType = "application/json";
            List<Standard.Models.CreateNewEFTCollectionSRequest> body = APIHelper.JsonDeserialize<List<Standard.Models.CreateNewEFTCollectionSRequest>>("[
  {
    \"objectId\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"mandateIdentification\": \"<string>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  },
  {
    \"objectId\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"mandateIdentification\": \"<string>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  }
]");

            // Perform API call
            Standard.Models.CollectionSCreated1 result = null;

            try
            {
                result = await controller.CreateNewEFTCollectionSAsync(xApiVersion, contentType, body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"results\": [\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": -74259811,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    },\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": 26720498,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    }\r\n  ],\r\n  \"status\": 49649662,\r\n  \"title\": \"sed do sunt elit\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestCreateNewNaedoCollectionS 
        /// </summary>
        [Test]
        public async Task TestCreateNewNaedoCollectionS() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;
            string contentType = "application/json";
            List<Standard.Models.CreateNewNaedoCollectionSRequest> body = APIHelper.JsonDeserialize<List<Standard.Models.CreateNewNaedoCollectionSRequest>>("[
  {
    \"objectId\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"mandateIdentification\": \"<string>\",
    \"trackingDays\": \"<integer>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  },
  {
    \"objectId\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"mandateIdentification\": \"<string>\",
    \"trackingDays\": \"<integer>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  }
]");

            // Perform API call
            Standard.Models.CollectionSCreated1 result = null;

            try
            {
                result = await controller.CreateNewNaedoCollectionSAsync(xApiVersion, contentType, body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"results\": [\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": -98697116,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    },\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": 92937278,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    }\r\n  ],\r\n  \"status\": 32472519,\r\n  \"title\": \"nulla dolore exercitation adipisicing\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestCreateNewDebiCheckCollectionS 
        /// </summary>
        [Test]
        public async Task TestCreateNewDebiCheckCollectionS() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;
            string contentType = "application/json";
            List<Standard.Models.CreateNewDebiCheckCollectionSRequest> body = APIHelper.JsonDeserialize<List<Standard.Models.CreateNewDebiCheckCollectionSRequest>>("[
  {
    \"objectId\": \"<integer>\",
    \"mandateIdentification\": \"<string>\",
    \"trackingDays\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  },
  {
    \"objectId\": \"<integer>\",
    \"mandateIdentification\": \"<string>\",
    \"trackingDays\": \"<integer>\",
    \"creditorShortName\": \"<string>\",
    \"debtorName\": \"<string>\",
    \"debtorAccountNumber\": \"<string>\",
    \"debtorBranch\": \"<string>\",
    \"debtorBank\": \"<string>\",
    \"collectionReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"requestedActionDate\": \"<date>\",
    \"debtorIdentificationType\": \"<string>\",
    \"debtorIdentification\": \"<string>\",
    \"debtorPhoneNumber\": \"<string>\",
    \"debtorEmail\": \"<string>\",
    \"debtorAccountType\": \"<string>\",
    \"forDate\": \"<date>\",
    \"preferredServiceType\": \"<string>\"
  }
]");

            // Perform API call
            Standard.Models.CollectionSCreated1 result = null;

            try
            {
                result = await controller.CreateNewDebiCheckCollectionSAsync(xApiVersion, contentType, body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"results\": [\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": -98697116,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    },\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": 92937278,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    }\r\n  ],\r\n  \"status\": 32472519,\r\n  \"title\": \"nulla dolore exercitation adipisicing\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestRecallCreatedCollectionS 
        /// </summary>
        [Test]
        public async Task TestRecallCreatedCollectionS() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;
            string contentType = "application/json";
            List<Standard.Models.RecallCreatedCollectionSRequest> body = APIHelper.JsonDeserialize<List<Standard.Models.RecallCreatedCollectionSRequest>>("[
  {
    \"objectId\": \"<integer>\",
    \"collectionIdentification\": \"<string>\"
  },
  {
    \"objectId\": \"<integer>\",
    \"collectionIdentification\": \"<string>\"
  }
]");

            // Perform API call
            Standard.Models.CollectionSCreated1 result = null;

            try
            {
                result = await controller.CreateRecallCreatedCollectionSAsync(xApiVersion, contentType, body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"results\": [\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": -98697116,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    },\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": 92937278,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    }\r\n  ],\r\n  \"status\": 32472519,\r\n  \"title\": \"nulla dolore exercitation adipisicing\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestCreateNewPaymentS 
        /// </summary>
        [Test]
        public async Task TestCreateNewPaymentS() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;
            string contentType = "application/json";
            List<Standard.Models.CreateNewPaymentSRequest> body = APIHelper.JsonDeserialize<List<Standard.Models.CreateNewPaymentSRequest>>("[
  {
    \"objectId\": \"<integer>\",
    \"bank\": \"<string>\",
    \"shortName\": \"<string>\",
    \"creditorName\": \"<string>\",
    \"creditorAccountNumber\": \"<string>\",
    \"creditorBranch\": \"<string>\",
    \"paymentReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"paymentDate\": \"<date>\",
    \"instrument\": \"<string>\",
    \"creditorAccountType\": \"<string>\"
  },
  {
    \"objectId\": \"<integer>\",
    \"bank\": \"<string>\",
    \"shortName\": \"<string>\",
    \"creditorName\": \"<string>\",
    \"creditorAccountNumber\": \"<string>\",
    \"creditorBranch\": \"<string>\",
    \"paymentReference\": \"<string>\",
    \"amount\": \"<double>\",
    \"paymentDate\": \"<date>\",
    \"instrument\": \"<string>\",
    \"creditorAccountType\": \"<string>\"
  }
]");

            // Perform API call
            Standard.Models.PaymentSCreated result = null;

            try
            {
                result = await controller.CreateNewPaymentSAsync(xApiVersion, contentType, body);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", null);

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");

            Assert.IsTrue(TestHelper.IsJsonObjectProperSubsetOf(
                    "{\r\n  \"results\": [\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": -98697116,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    },\r\n    {\r\n      \"requestedActionDate\": \"2020-07-15\",\r\n      \"objectId\": 92937278,\r\n      \"collectionIdentification\": \"69bdv168s0an1cs6vxq9bxnm\",\r\n      \"collectionReference\": \"CollectRef001\"\r\n    }\r\n  ],\r\n  \"status\": 32472519,\r\n  \"title\": \"nulla dolore exercitation adipisicing\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

    }
}