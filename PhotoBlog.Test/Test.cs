using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimelinePhoto.Service.DomainModels;

namespace TimelinePhoto.Test
{
    [TestClass]
    public class Test
    {
        public Test()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void GetEntries()
        {
            var repository = new DummyRepository();
            repository.AddEntry(new Entry
                                    {
                                        Title = "TestEntry",
                                        Text = "Dummy",
                                        Date = DateTime.Now,
                                        Asset = new Asset()
                                    });
            var apiController = new Controllers.ApiController(repository: repository);

            var result = apiController.GetEntries();
            var dictionary = new System.Web.Routing.RouteValueDictionary(result.Data);
            var timeline = dictionary.Values.Cast<Models.Timeline.Timeline>().First();

            Assert.AreEqual(timeline.date.First().headline, "TestEntry");
        }
    }

    public class DummyRepository : Service.Repositories.ITimelinePhotoRepository
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public IEnumerable<Entry> GetEntries()
        {
            return _entries;
        }
    }
}
