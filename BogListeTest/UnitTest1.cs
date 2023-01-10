using Boglistesystem.Models;
using Boglistesystem.Services;
using Microsoft.AspNetCore.Builder;
using System.Collections.Generic;
using Boglistesystem.Pages;
using Boglistesystem.Pages.UnderviserPage.BogPage;
using Azure;

namespace BogListeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() {
            BLSystemContext context = new BLSystemContext();
            BogServices bs = new BogServices(context);
            IEnumerable<Bog> B�ger = bs.GetBogs();
           
            Assert.IsNotNull(B�ger);
            Assert.IsTrue(B�ger.Count() >= 1,"B�ger Skal v�re st�rre end 1");
        }

        [TestMethod]
        public void TestMethod2()
            {
            BLSystemContext context = new BLSystemContext();
            HoldService hs = new HoldService(context);

            IEnumerable<Hold> holds = hs.GetHolds();
            Assert.IsNotNull(holds);
            Assert.IsTrue(holds.Count() >= 1, "Hold skal v�re st�rre end 1 ");
        }
        [TestMethod]
        public void TestFag() {
            BLSystemContext context = new BLSystemContext();
            FagService fs = new FagService(context);
            IEnumerable<Fag> fags = fs.GetFags();

            Assert.IsNotNull(fags);
            Assert.IsTrue(fags.Count() > 1, "Fag skal v�re st�rre end 1");
            
        }
        

        [TestMethod]
        public void TestUnderviser() {
            BLSystemContext context = new BLSystemContext();
            UnderviserService us = new UnderviserService(context);
            IEnumerable<Underviser> undervisers = us.GetUndervisers();
            Assert.IsNotNull(undervisers);
            Assert.IsTrue(undervisers.Count() > 1, "Underviser skla v�re st�rre end 1");
        }

    }
}