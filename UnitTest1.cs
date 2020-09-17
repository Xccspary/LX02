using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(DAL.UserInfo.Instance.UserCheck("Admin"));
        }
        public void TestMethod2()
        {
            Model.UserInfo user = new Model.UserInfo { username = "GEuset", passWord = "sql.123", type = "π‹¿Ì‘±" };
        }
    }
}
