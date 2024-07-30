using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.KATACARFOLD
{
    internal class KataCar
    {//classes
        public class Car : ICar, IFuelTankDisplay
        {

            public IEngine engine;

            public IFuelTank fuelTank;

            public IFuelTankDisplay fuelTankDisplay;

            public Car() : this(20) {; }

            public Car(double fuelLevel)
            {
                this.fuelTank = new FuelTank(fuelLevel);
                this.engine = new Engine(fuelTank);
                this.fuelTankDisplay = new FuelTankDisplay(this.fuelTank);
            }
            // should see if the eng is running??
            public bool EngineIsRunning => engine.IsRunning;

            public void EngineStart()
            {
                             if (!engine.IsRunning)
                {
                    engine.Start(); // starts the engine if not already on
                }
            }

            public void EngingStop()
            {
                if (engine.IsRunning) engine.Stop();
            }

            public void RunningIdle()
            {
                if (engine.IsRunning) 
                { 
                    fuelTank.Consume(); 
                }
            
        }

        public class Engine : IEngine
        {
            public bool IsRunning {  get; set; } = false;
            private FuelTank _fuelTank;
            public void Consume(double liters) {
                    _fuelTank.Consume(liters);
                }
            public Engine(FuelTank fuelTank)
                {
                    _fuelTank= fuelTank;
                }

                public void Start()
            {
                IsRunning = true;   
            }

            public void Stop() 
            { 
                IsRunning = false; 
            }

            
        }

        public class FuelTank : IFuelTank
        {   //fields
            private double _fillLevel;
            private double ReserveLevel = 5.0;
            private double MaxCapacity = 60.0;
            private double InitialFuelLevel = 20.0;
            //properties
            public double FillLevel { get => Math.Round(_fillLevel, 2); }
            public bool IsOnReserve { get => _fillLevel < ReserveLevel; }
            public bool IsComplete { get => _fillLevel == MaxCapacity; }


            //constructor
            public FuelTank()
            {
                _fillLevel = InitialFuelLevel;
            }


        }

            public class FuelTankDisplay : IFuelTankDisplay
            {
                private IFuelTank fuelTank;

                public FuelTankDisplay(IFuelTank fuelTank)
                {
                    this.fuelTank = fuelTank;
                }
            }

        }

    //Interfaces
    public interface ICar
    {
        bool EngineIsRunning { get; }

        void EngineStart();

        void EngineStop();

        void Refuel(double liters);

        void RunningIdle();
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
