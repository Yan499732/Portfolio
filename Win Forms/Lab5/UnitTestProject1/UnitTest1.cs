using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            string a = "Admin";
            string b = "Admin";
            bool res = true;

            //act
            Lab5.Form1 F = new Lab5.Form1();
            bool Result = F.Log(a, b);

            //assert
            Assert.AreEqual(res, Result);
        }
    }
}
