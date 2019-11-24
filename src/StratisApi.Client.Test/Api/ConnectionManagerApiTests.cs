/* 
 * Stratis Node API
 *
 * Access to the Stratis Node's core features.
 *
 * OpenAPI spec version: 1
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

using IO.Swagger.Client;
using IO.Swagger.Api;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ConnectionManagerApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ConnectionManagerApiTests
    {
        private ConnectionManagerApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConnectionManagerApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConnectionManagerApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ConnectionManagerApi
            //Assert.IsInstanceOfType(typeof(ConnectionManagerApi), instance, "instance is a ConnectionManagerApi");
        }

        
        /// <summary>
        /// Test AddNodeAPI
        /// </summary>
        [Test]
        public void AddNodeAPITest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string endpoint = null;
            //string command = null;
            //instance.AddNodeAPI(endpoint, command);
            
        }
        
        /// <summary>
        /// Test GetPeerInfoAPI
        /// </summary>
        [Test]
        public void GetPeerInfoAPITest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.GetPeerInfoAPI();
            
        }
        
    }

}