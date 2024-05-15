using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE Create 2 Interfaces called IVehicle & ICompany

            //DONE Create 3 classes called Car , Truck , & SUV


            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values
            var myCar = new Car()
            {
                Name = "Toyota",
                Model = "Corolla",
                IsAmerican = false,
                IsJapanese = true,
                Color = "Blue",
                ElectricOrGas = "Gas",
                NumberOfWheels = 4,
                HasHUD = false,
                HowManySeatbelts = 5,
                Slogan = "Let's Go Places"
                
            };

            var workTruch = new Truck()
            {
                Name = "Chevorlet",
                Model = "Silverado",
                IsAmerican = true,
                IsJapanese = false,
                ElectricOrGas = "gas",
                Payload = 2290,
                Color = "Silver",
                HasHUD = true,
                Slogan = "Together Lets Drive",
                NumberOfWheels = 4
                
            };

            var trailRide = new SUV()
            {
                Model = "Bronco",
                HasHUD = true,
                Color = "Green",
                ElectricOrGas = "Gas",
                NumberOfWheels = 4,
                SoftTop = true,
                Name = "Ford",
                IsAmerican = true,
                IsJapanese = false,
                Slogan = "Built Wild"
                
            };

            myCar.DisplayDetails();
            workTruch.DisplayDetails();
            trailRide.DisplayDetails();

            



            //Option for displaying values: 
            //DONE Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //DONE Implement the stubbed out method in the derived classes.
            //DONE In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
