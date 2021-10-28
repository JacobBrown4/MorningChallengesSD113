using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassChallenge
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HeroTests()
        {

            Hero supe = new Hero("Superman", "Clark Kent", "Smallville", true, 100, 100, 100);

            Console.WriteLine(supe.Power);
            Console.WriteLine($"His speed is {supe.Speed}");
            Console.WriteLine(supe.HeroStatus());
            Console.WriteLine(supe.AveragePower());

            Hero flash = new Hero("The Flash", "Wally West", "Central City", true, 120, 70, 80);

            Console.WriteLine(flash.Speed);
            Console.WriteLine($"{flash.HeroStatus()} His average power is {flash.AveragePower()}");

            Assert.AreEqual(supe.Speed, 99);
            Assert.AreEqual(flash.Speed, 100);

            Console.WriteLine($"{flash.Compare(supe).HeroName} is stronger");

        }
    }
}
