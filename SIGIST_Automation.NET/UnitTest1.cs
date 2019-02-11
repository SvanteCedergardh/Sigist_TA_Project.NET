using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TAF.Core;
using TAF.WebSupport;
using TAF.WebSupport.SeleniumAdapter;

namespace SIGIST_Automation.NET
{
    [TestClass]
    public class UnitTest1 : TestSet
    {

        private WebInteraction _web;

        [TestInitialize]
        public void SetUp()
        {
            _web = new WebInteractionSelenium(CurrentTestCase);
            
            _web.Navigate(TestDataSet.homePage);
        }

        [TestCleanup]
        public void TearDown()
        {
            _web.MakeSureDriverIsClosed();
        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
