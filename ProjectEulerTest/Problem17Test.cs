using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectEuler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Test
{
    [TestClass]
    public class Problem17Test
    {        
        [TestMethod()]
        public void ThreeHundredAndFortyTwoContains23Letters()
        {
            var problem = new Problem17();
            Assert.AreEqual(23, problem.WriteNumber(342).Length);
        }
        [TestMethod]
        public void OneHundredAndFifteenContains20Letters()
        {
            var problem = new Problem17();
            Assert.AreEqual(20, problem.WriteNumber(115).Length);
        }
        [TestMethod]
        public void EverythingAbove1000Returns11Letters()
        {
            var problem = new Problem17();
            Assert.AreEqual(11, problem.WriteNumber(10001).Length);
        }
    }
}