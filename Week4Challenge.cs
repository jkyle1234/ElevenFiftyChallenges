using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace week4challenge
{

    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int MileagePerGallon { get; set; }
        public bool IsTruck { get; set; }
        public double Trip { get; set; }
        public int Age { get; set; }
        public double GasCostPerGallon { get; set; }
        public abstract double GetGasCostOfTrip();
    }

    public class Car : Vehicle
    {
        public Car() { }
        public Car(int Miles, double Trip,double gas)
        {
            this.MileagePerGallon = Miles;
            this.Trip = Trip;
            this.GasCostPerGallon = gas;
        }

        public override double GetGasCostOfTrip()
        {
            return Math.Round((Trip / MileagePerGallon * GasCostPerGallon),2);
        }
    }

    public class Truck : Vehicle
    {
        private const double TruckMileagePerGallon = 0.88;

        public Truck() { }
        
        public Truck(int  Miles, double Trip,double gas)
        {
            this.MileagePerGallon = Miles;
            this.Trip = Trip;
            this.GasCostPerGallon = gas;
        }

        public override double GetGasCostOfTrip()
        {
            return Math.Round((Trip / (MileagePerGallon * TruckMileagePerGallon)) * GasCostPerGallon,2); 
        }

    }

    class Week4Challenge
    {
        static void Main(string[] args)
        {
            Car civic = new Car(32,1000.0,2.3);
            Truck ford150 = new Truck(18, 1000.0,2.3);

            Console.WriteLine("Calculating the cost of going to florida in our honda civic versus ford 150");
            Console.WriteLine($"The cost of the travelling in the civic is ${civic.GetGasCostOfTrip()} and the cost of the ford is ${ford150.GetGasCostOfTrip()}");
            Console.ReadLine();

        }
    }
}
