using System;
namespace InterfaceExercise
{
	public interface ICompany
	{

        public bool IsAmerican { get; set; }
        public bool IsJapanese { get; set; }
        public string Slogan { get; set; }
        public string Name { get; set; }

	}

    //DONE In ICompany: 
  
    /* Create 2 members that are specific to each every company
     * regardless of vehicle type.
     * Example: public string Logo { get; set; }
     */
}

