/* 
 * Cineast RESTful API
 *
 * Cineast is vitrivr's content-based multimedia retrieval engine. This is it's RESTful API.
 *
 * The version of the OpenAPI document: v1
 * Contact: contact@vitrivr.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Org.Vitrivr.CineastApi.Client;
using Org.Vitrivr.CineastApi.Api;
using Org.Vitrivr.CineastApi.Model;

namespace Org.Vitrivr.CineastApi.Test
{
    /// <summary>
    ///  Class for testing StatusApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class StatusApiTests
    {
        private StatusApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new StatusApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StatusApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' StatusApi
            //Assert.IsInstanceOf(typeof(StatusApi), instance);
        }

        
        /// <summary>
        /// Test Status
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.Status();
            //Assert.IsInstanceOf(typeof(Ping), response, "response is Ping");
        }
        
    }

}