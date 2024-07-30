using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeWars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeWars.Tests
{
    [TestClass]
    internal class KataCarTest
    {
        [TestMethod]
        public void TestMotorStartAndStop()
        {
            var car = new Car();

            Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");

            car.EngineStart();

            Assert.IsTrue(car.EngineIsRunning, "Engine should be running.");

            car.EngineStop();

            Assert.IsFalse(car.EngineIsRunning, "Engine could not be running.");
        }

        [TestMethod]
        public void TestFuelConsumptionOnIdle()
        {
            var car = new Car(1);

            car.EngineStart();

            Enumerable.Range(0, 3000).ToList().ForEach(s => car.RunningIdle());

            Assert.AreEqual(0.10, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
        }

        [TestMethod]
        public void TestFuelTankDisplayIsComplete()
        {
            var car = new Car(60);

            Assert.IsTrue(car.fuelTankDisplay.IsComplete, "Fuel tank must be complete!");
        }

        [TestMethod]
        public void TestFuelTankDisplayIsOnReserve()
        {
            var car = new Car(4);

            Assert.IsTrue(car.fuelTankDisplay.IsOnReserve, "Fuel tank must be on reserve!");
        }

        [TestMethod]
        public void TestRefuel()
        {
            var car = new Car(5);

            car.Refuel(40);

            Assert.AreEqual(45, car.fuelTankDisplay.FillLevel, "Wrong fuel tank fill level!");
        }
    }
}

