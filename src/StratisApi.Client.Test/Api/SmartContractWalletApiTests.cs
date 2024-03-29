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
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing SmartContractWalletApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SmartContractWalletApiTests
    {
        private SmartContractWalletApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SmartContractWalletApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SmartContractWalletApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SmartContractWalletApi
            //Assert.IsInstanceOfType(typeof(SmartContractWalletApi), instance, "instance is a SmartContractWalletApi");
        }

        
        /// <summary>
        /// Test Call
        /// </summary>
        [Test]
        public void CallTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BuildCallContractTransactionRequest request = null;
            //instance.Call(request);
            
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //BuildCreateContractTransactionRequest request = null;
            //instance.Create(request);
            
        }
        
        /// <summary>
        /// Test GetAccountAddresses
        /// </summary>
        [Test]
        public void GetAccountAddressesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string walletName = null;
            //instance.GetAccountAddresses(walletName);
            
        }
        
        /// <summary>
        /// Test GetAddressBalance
        /// </summary>
        [Test]
        public void GetAddressBalanceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string address = null;
            //instance.GetAddressBalance(address);
            
        }
        
        /// <summary>
        /// Test GetHistory
        /// </summary>
        [Test]
        public void GetHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string walletName = null;
            //string address = null;
            //instance.GetHistory(walletName, address);
            
        }
        
        /// <summary>
        /// Test GetTransactionHistory
        /// </summary>
        [Test]
        public void GetTransactionHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string walletName = null;
            //string accountName = null;
            //string address = null;
            //int? skip = null;
            //int? take = null;
            //string searchQuery = null;
            //instance.GetTransactionHistory(walletName, accountName, address, skip, take, searchQuery);
            
        }
        
        /// <summary>
        /// Test SendTransaction
        /// </summary>
        [Test]
        public void SendTransactionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SendTransactionRequest request = null;
            //instance.SendTransaction(request);
            
        }
        
    }

}
