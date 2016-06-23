using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGebruikerslijst()
        {
            T_Sloepke.Klassen.Database database = new T_Sloepke.Klassen.Database();

            Assert.AreEqual(3, database.Huurontracten().Count, "Huurcontracten lijst klopt niet");
        }
    }
}
