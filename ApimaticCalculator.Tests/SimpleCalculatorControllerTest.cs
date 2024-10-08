// <copyright file="SimpleCalculatorControllerTest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using APIMatic.Core.Utilities;
using ApimaticCalculator.Standard;
using ApimaticCalculator.Standard.Controllers;
using ApimaticCalculator.Standard.Exceptions;
using ApimaticCalculator.Standard.Http.Client;
using ApimaticCalculator.Standard.Http.Response;
using ApimaticCalculator.Standard.Utilities;
using Newtonsoft.Json.Converters;
using NUnit.Framework;

namespace ApimaticCalculator.Tests
{
    /// <summary>
    /// SimpleCalculatorControllerTest.
    /// </summary>
    [TestFixture]
    public class SimpleCalculatorControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests).
        /// </summary>
        private SimpleCalculatorController controller;

        /// <summary>
        /// Setup test class.
        /// </summary>
        [OneTimeSetUp]
        public void SetUpDerived()
        {
            this.controller = this.Client.SimpleCalculatorController;
        }

        /// <summary>
        /// Check if multiplication works.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous unit test.</returns>
        [Test]
        public async Task TestMultiply()
        {
            // Parameters for the API call
            Standard.Models.OperationTypeEnum operation = ApiHelper.JsonDeserialize<Standard.Models.OperationTypeEnum>("\"MULTIPLY\"");
            double x = 4;
            double y = 5;
            Standard.Models.GetCalculateInput input = new Standard.Models.GetCalculateInput(operation, x, y);

            // Perform API call
            double result = 0;
            try
            {
                result = await this.controller.GetCalculateAsync(input);
            }
            catch (ApiException)
            {
            }

            // Test response code
            Assert.AreEqual(200, HttpCallBack.Response.StatusCode, "Status should be 200");

            // Test whether the captured response is as we expected
            Assert.IsNotNull(result, "Result should exist");
            Assert.AreEqual(20, result, AssertPrecision, "Response should match expected value");
        }
    }
}