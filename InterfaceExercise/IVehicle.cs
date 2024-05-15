using System;
namespace InterfaceExercise
{
	public interface IVehicle
    {
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasHUD { get; set; }
        public string ElectricOrGas { get; set; }

        public void DisplayDetails();
           
    }

    //DONE In your IVehicle:

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: public int NumberOfWheels { get; set; }
     */
    
}

