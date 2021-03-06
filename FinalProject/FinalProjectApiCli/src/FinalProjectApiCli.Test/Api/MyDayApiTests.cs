/*
 * FinalProject.web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FinalProjectApiCli.Client;
using FinalProjectApiCli.Api;
// uncomment below to import models
//using FinalProjectApiCli.Model;

namespace FinalProjectApiCli.Test.Api
{
    /// <summary>
    ///  Class for testing MyDayApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MyDayApiTests : IDisposable
    {
        private MyDayApi instance;

        public MyDayApiTests()
        {
            instance = new MyDayApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MyDayApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MyDayApi
            //Assert.IsType<MyDayApi>(instance);
        }

        /// <summary>
        /// Test MyDayDeletebystatusDelete
        /// </summary>
        [Fact]
        public void MyDayDeletebystatusDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MyTask myTask = null;
            //instance.MyDayDeletebystatusDelete(myTask);
        }

        /// <summary>
        /// Test MyDayDonePost
        /// </summary>
        [Fact]
        public void MyDayDonePostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MyTask myTask = null;
            //instance.MyDayDonePost(myTask);
        }

        /// <summary>
        /// Test MyDayGet
        /// </summary>
        [Fact]
        public void MyDayGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MyDayGet();
            //Assert.IsType<List<MyTask>>(response);
        }

        /// <summary>
        /// Test MyDayNameDelete
        /// </summary>
        [Fact]
        public void MyDayNameDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //instance.MyDayNameDelete(name);
        }

        /// <summary>
        /// Test MyDayNameGet
        /// </summary>
        [Fact]
        public void MyDayNameGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.MyDayNameGet(name);
            //Assert.IsType<MyTask>(response);
        }

        /// <summary>
        /// Test MyDayPost
        /// </summary>
        [Fact]
        public void MyDayPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MyTask myTask = null;
            //instance.MyDayPost(myTask);
        }

        /// <summary>
        /// Test MyDayPut
        /// </summary>
        [Fact]
        public void MyDayPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //MyTask myTask = null;
            //instance.MyDayPut(name, myTask);
        }
    }
}
