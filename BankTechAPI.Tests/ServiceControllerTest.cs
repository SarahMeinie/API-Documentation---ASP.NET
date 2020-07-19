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
    public class ServiceControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static ServiceController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [SetUp]
        public static void SetUpClass()
        {
            controller = GetClient().Service;
        }

        /// <summary>
        /// TODO: Add description for test TestClearApplicationCache 
        /// </summary>
        [Test]
        public async Task TestClearApplicationCache() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;

            // Perform API call
            Standard.Models.CacheCleared result = null;

            try
            {
                result = await controller.GetClearApplicationCacheAsync(xApiVersion);
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
                    "{\r\n  \"status\": 60443271,\r\n  \"title\": \"Lorem nostrud id in enim\"\r\n}", 
                    TestHelper.ConvertStreamToString(httpCallBackHandler.Response.RawBody), 
                    false, true, false),
                    "Response body should have matching keys");
        }

        /// <summary>
        /// TODO: Add description for test TestGetAListOfAClientsInstruments 
        /// </summary>
        [Test]
        public async Task TestGetAListOfAClientsInstruments() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;

            // Perform API call

            try
            {
                await controller.GetAListOfAClientsInstrumentsAsync(xApiVersion);
            }
            catch(ForbiddenRequestException) {};

            // Test response code
            Assert.AreEqual(403, httpCallBackHandler.Response.StatusCode,
                    "Status should be 403");

        }

        /// <summary>
        /// TODO: Add description for test TestGetAListOfNonProcessingDays 
        /// </summary>
        [Test]
        public async Task TestGetAListOfNonProcessingDays() 
        {
            // Parameters for the API call
            double xApiVersion = 1.0;

            // Perform API call

            try
            {
                await controller.GetAListOfNonProcessingDaysAsync(xApiVersion);
            }
            catch(ServiceIsCurrentlyUnavailablePleaseTryAgainLaterOrContactYourAdministratorException) {};

            // Test response code
            Assert.AreEqual(503, httpCallBackHandler.Response.StatusCode,
                    "Status should be 503");

        }

    }
}