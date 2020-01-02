/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using CyberSource.Client;
using CyberSource.Api;
using CyberSource.Model;

namespace CyberSource.Test
{
    /// <summary>
    ///  Class for testing PayerAuthenticationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PayerAuthenticationApiTests
    {
        private PayerAuthenticationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PayerAuthenticationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PayerAuthenticationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PayerAuthenticationApi
            //Assert.IsInstanceOfType(typeof(PayerAuthenticationApi), instance, "instance is a PayerAuthenticationApi");
        }

        
        /// <summary>
        /// Test CheckPayerAuthEnrollment
        /// </summary>
        [Test]
        public void CheckPayerAuthEnrollmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CheckPayerAuthEnrollmentRequest checkPayerAuthEnrollmentRequest = null;
            //var response = instance.CheckPayerAuthEnrollment(checkPayerAuthEnrollmentRequest);
            //Assert.IsInstanceOf<RiskV1AuthenticationsPost201Response> (response, "response is RiskV1AuthenticationsPost201Response");
        }
        
        /// <summary>
        /// Test ValidateAuthenticationResults
        /// </summary>
        [Test]
        public void ValidateAuthenticationResultsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Request request = null;
            //var response = instance.ValidateAuthenticationResults(request);
            //Assert.IsInstanceOf<RiskV1AuthenticationResultsPost201Response> (response, "response is RiskV1AuthenticationResultsPost201Response");
        }
        
    }

}
