using PhotoBlog.Service.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PhotoBlog.Service.DomainModels;
using System.Collections.Generic;

namespace PhotoBlog.Service.Tests
{
    
    
    /// <summary>
    ///This is a test class for FlickrRepositoryTest and is intended
    ///to contain all FlickrRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FlickrRepositoryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for GetEntries
        ///</summary>
        [TestMethod()]
        public void GetEntriesTest()
        {
            var rssUrl = new Uri("http://api.flickr.com/services/feeds/photos_public.gne?id=8407953@N03&lang=en-us&format=rss_200"); 
            var target = new FlickrRepository(rssUrl);

            IEnumerable<Entry> entries = target.GetEntries();
            
            Assert.AreNotEqual(entries, null);
        }
    }
}
