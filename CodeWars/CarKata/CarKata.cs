using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.CarKata

    {
        public class Car : ICar
        {
            public IFuelTankDisplay fuelTankDisplay;

            private IEngine engine;

            private IFuelTank fuelTank;

            public Car() : this(20) {; }


            public Car(double fuelLevel)
            {
                this.fuelTank = new FuelTank(fuelLevel);
                this.engine = new Engine(fuelTank);
                this.fuelTankDisplay = new FuelTankDisplay(fuelTank);
            }

            public bool EngineIsRunning => this.engine.IsRunning;

        public void Accelerate(int speed)
        {
            //if(!)
        }

        public void BrakeBy(int speed)
        {
            throw new NotImplementedException();
        }

        public void EngineStart() => this.engine.Start();

            public void EngineStop() => this.engine.Stop();

        public void FreeWheel()
        {
            throw new NotImplementedException();
        }

        public void Refuel(double liters) => this.fuelTank.Refuel(liters);


            public void RunningIdle() => this.fuelTank.Consume(0.0003);
        }

        public class Engine : IEngine
        {
            private IFuelTank fuelTank;
            private bool isRunning = false;
            public Engine(IFuelTank fuelTank)
            {
                this.fuelTank = fuelTank;
            }

            public bool IsRunning => isRunning;

            public void Consume(double liters)
            {
                this.fuelTank.Consume(liters);
            }

            public void Start()
            {
                isRunning = true;
            }

            public void Stop()
            {
                isRunning = false;
            }
        }

        public class FuelTank : IFuelTank
        {
            private double fuelLevel;

            public FuelTank(double fuelLevel)
            {
                this.fuelLevel = fuelLevel;
            }

            public double FillLevel => this.fuelLevel;

            public bool IsOnReserve => this.fuelLevel < 5;

            public bool IsComplete => this.fuelLevel == 60;

            public void Consume(double liters) => this.fuelLevel -= liters;

            public void Refuel(double liters)
            {
                this.fuelLevel += liters;
                if (this.fuelLevel > 60) this.fuelLevel = 60;
            }

        }

        public class FuelTankDisplay : IFuelTankDisplay
        {
            private IFuelTank fuelTank;

            public FuelTankDisplay(IFuelTank fuelTank)
            {
                this.fuelTank = fuelTank;
            }

            public double FillLevel => Math.Round(this.fuelTank.FillLevel, 2);

            public bool IsOnReserve => this.fuelTank.IsOnReserve;

            public bool IsComplete => this.fuelTank.IsComplete;
        }
    public interface ICar
    {
        bool EngineIsRunning { get; }

        void BrakeBy(int speed); // car #2

        void Accelerate(int speed); // car #2

        void EngineStart();

        void EngineStop();

        void FreeWheel(); // car #2

        void Refuel(double liters);

        void RunningIdle();
    }

    public interface IDrivingInformationDisplay // car #2
    {
        int ActualSpeed { get; }
    }

    public interface IDrivingProcessor // car #2
    {
        int ActualSpeed { get; }

        void IncreaseSpeedTo(int speed);

        void ReduceSpeed(int speed);
    }

    public interface IEngine
    {
        bool IsRunning { get; }

        void Consume(double liters);

        void Start();

        void Stop();
    }

    public interface IFuelTank
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }

        void Consume(double liters);

        void Refuel(double liters);
    }

    public interface IFuelTankDisplay
    {
        double FillLevel { get; }

        bool IsOnReserve { get; }

        bool IsComplete { get; }
    }
}