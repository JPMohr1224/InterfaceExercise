using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }
        public int HowManySeatbelts { get; set; }
        public string Model { get; set; }
        public bool IsAmerican { get; set; }
        public bool IsJapanese { get; set; }
        public string Slogan { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHUD { get; set; }
        public string ElectricOrGas { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"This is a {Name} {Model}. It is {Color} and has {NumberOfWheels} wheels! {Slogan}!");
        }



    }

}

//In each of your Car, Truck, and SUV classes

        /* DONE
         * Create 2 members that are specific to each class
         * Example for Car: public bool HasTrunk { get; set; }
         * Example for SUV: public int NumberOfSeats { get; set; }
         *
         * DONE
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         */