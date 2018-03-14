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
    public class PersoonTest
    {
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void EenPersoonHeeftMinstens1Naam()
        {
            var persoon = new Persoon(new List<string> { "" });            
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void EenPersoonHeeftAlleenUniekeNamen()
        {
            var persoon = new Persoon(new List<String> { "Frank", "Frank", "Bert" });
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void EenPersoonZijnNaamBevatMinstens1Teken()
        {
            var persoon = new Persoon(new List<String> {String.Empty});
        }
        [TestMethod]
        public void ToStringGeeftAlleVoornamenTerugMetEenSpatieTussen()
        {
            var persoon = new Persoon(new List<string> { "kenny", "kevin", "thomas" });
            Assert.AreEqual("kenny kevin thomas", persoon.ToString());
        }
    }
}