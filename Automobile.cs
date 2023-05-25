using Automotive.Vehicle.Jeep;
using System;
using System.Collections.Generic;
using System.Text;
using Utility_Vehicle.Car;
using Utility_Vehicle = Automotive.Vehicle.Jeep;

namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category
            {
                string category;
                public Category()
                {
                    category = "MultiUtilityVehicle";
                }
                public void Display()
                {
                    Console.WriteLine( "Jeep Category: " + category);
                }
            }
        }

        class Automobile
        {
            static void Main()
            {
                Category objCat = new Category();
                objCat.Display();
                Utility_Vehicle.Category objCategoty = new Utility_Vehicle.Category();
                objCategoty.Display();
            }
            
        }
    }
}