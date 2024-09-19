// <copyright file="ControllerTestBase.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApimaticCalculator.Standard;
using ApimaticCalculator.Standard.Http.Client;
using ApimaticCalculator.Standard.Models;
using NUnit.Framework;

namespace ApimaticCalculator.Tests
{
    /// <summary>
    /// ControllerTestBase Class.
    /// </summary>
    [TestFixture]
    public class ControllerTestBase
    {
        /// <summary>
        /// Assert precision.
        /// </summary>
        protected const double AssertPrecision = 0.1;

        /// <summary>
        /// Gets HttpCallBackHandler.
        /// </summary>
        internal HttpCallback HttpCallBack { get; private set; } = new HttpCallback();

        /// <summary>
        /// Gets ApimaticCalculatorClient Client.
        /// </summary>
        protected ApimaticCalculatorClient Client { get; private set; }

        /// <summary>
        /// Set up the client.
        /// </summary>
        [OneTimeSetUp]
        public void SetUp()
        {
            ApimaticCalculatorClient config = ApimaticCalculatorClient.CreateFromEnvironment();
            this.Client = config.ToBuilder()
                .HttpCallback(HttpCallBack)
                .Build();
        }
    }
}