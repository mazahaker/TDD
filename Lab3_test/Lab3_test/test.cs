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

        [TestMethod]
        public void Test_Eual_Minutes()
        {
            Clock watch = new Clock();
            Assert.IsTrue(watch.minutes == DateTime.Now.Minute);
        }

        [TestMethod]
        public void Test_Eual_Hours()
        {
            Clock watch = new Clock();
            Assert.IsTrue(watch.hours == DateTime.Now.Hour);
        }

        [TestMethod]
        public void Test_Add_Min()
        {
            Clock watch = new Clock();
            watch.minutes = 1;
            watch.Get_Min();
            Assert.IsTrue(watch.minutes == 2);
        }
    }
}
