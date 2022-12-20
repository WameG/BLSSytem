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
            IEnumerable<Bog> Bøger = bs.GetBogs();
            foreach (var b in Bøger)
            {
                Console.WriteLine("Bogen findes ikke !");
            }

        }

        [TestMethod]
        public void TestMethod2()
            {
            BLSystemContext context = new BLSystemContext();
            HoldService hs = new HoldService(context);

            IEnumerable<Hold> holds = hs.GetHolds();

        }
        [TestMethod]
        public void TestFag() {
            BLSystemContext context = new BLSystemContext();
            FagService fs = new FagService(context);
            IEnumerable<Fag> fags = fs.GetFags();
            
                foreach (Fag f in fags)
                {
                Console.WriteLine();
                }
            
        }
        

        [TestMethod]
        public void TestUnderviser() {
            BLSystemContext context = new BLSystemContext();
            UnderviserService us = new UnderviserService(context);
            IEnumerable<Underviser> undervisers = us.GetUndervisers();
            foreach(var u in undervisers)
            {
                Console.WriteLine();
            }
        }

    }
}