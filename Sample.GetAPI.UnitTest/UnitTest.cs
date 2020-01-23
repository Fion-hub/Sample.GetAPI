using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sample.GetAPI.UnitTest.Controllers;
using System.Web.Http.Results;
namespace Sample.GetAPI.UnitTest

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        static void  Mind()
        {
            var target = new DemoController();
            var name = "http://od.moi.gov.tw/od/data/api/";
            var expected = typeof(BadRequestResult);
            //act
            var actualAction = target.Post(name);
            var actual = actualAction as BadRequestResult;
            //assert
            Assert.IsNotNull(actual);
            Assert.IsInstanceOfType(actual, expected);
        }
    }
}
