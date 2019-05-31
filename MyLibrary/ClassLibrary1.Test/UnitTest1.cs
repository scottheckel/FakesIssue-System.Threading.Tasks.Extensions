using System;
using System.Net.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibrary1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var httpClient = new HttpClient())
            {
                var myObject = new MyClass();
                myObject.Fetch(httpClient);
            }
        }
    }
}
