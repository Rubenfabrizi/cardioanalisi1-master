using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using equazionilybrary;

namespace datacardiotest
{
    //test primo punto
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(17,203)]
        [DataRow(54, 166)]
       
        public void TestMethod1(int eta, int etaattesa)
        {

            
            int etarestituita = equazionilybrary.DataCardio.CalcfrecquenzaMin(eta);

            Assert.AreEqual(etaattesa, etarestituita);
        }
        [TestMethod]
        [DataTestMethod]
        [DataRow(17, 203)]
        [DataRow(54,166)]

        public void TestMethod2(int eta, int etaattesa)
        {


            int etarestituita = equazionilybrary.DataCardio.CalcfrecquenzaMax(eta);

            Assert.AreEqual(etaattesa, etarestituita);
        }
        //test secondo punto
        [TestMethod]
        [DataTestMethod]
        [DataRow(60, "normale")]
        [DataRow(40, "bradicardia")]
        [DataRow(120, "tachicardia")]

        public void TestMethodInterpretaredati(int battiti, string etaattesa)
        {


           string etarestituita = equazionilybrary.DataCardio.interpretaredati(battiti);
            Assert.AreEqual(etaattesa, etarestituita);
        }
        //test terzo metodo

        [TestMethod]
        [DataTestMethod]
        [DataRow("f"]
        [DataRow("m")]
        public void TestMethodcalcolocalorie(int  frequenza, int eta, double durata, double peso, string sesso)
        {


             
            
        }
    }
}
