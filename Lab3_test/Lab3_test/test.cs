using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab3_test
{
    [TestClass]
    public class Test_gamer
    {


        [TestMethod]
        public void Test_Create_Clock()
        {
            Clock watch = new Clock();
            Assert.IsNotNull(watch);
        }

        [TestMethod]
        public void Test_Create_Hours()
        {
            Clock watch = new Clock();
            Assert.IsNotNull(watch.hours);
        }

        [TestMethod]
        public void Test_Create_Minutes()
        {
            Clock watch = new Clock();
            Assert.IsNotNull(watch.hours);
        }

        [TestMethod]
        public void Test_Create_Seconds()
        {
            Clock watch = new Clock();
            Assert.IsNotNull(watch.hours);
        }
    }
}
