// TYPES of inheritance
// single
/*{
	common attributes of all vehicles
}

classs car: vehical
	{
	somee attributes of car only 
}*/
	

using System;

namespace NIRAV
{
    class Vehicle
    {
        public string model;
        public float speed;
        public string color;

        public void ShowVehicleInfo()
        {
            Console.WriteLine("This is a Vehicle");
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Speed: " + speed);
            Console.WriteLine("Color: " + color);
        }
    }
    
    class Car : Vehicle
    {
        public int seats;
        public string fuelType;
        
        public void ShowCarInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine("Seats: " + seats);
            Console.WriteLine("Fuel Type: " + fuelType);
        }
    }

    class sigleInheritance
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.model = "Honda City";
            myCar.speed = 160;
            myCar.color = "Black";
            myCar.seats = 5;
            myCar.fuelType = "Petrol";
            myCar.ShowCarInfo();
        }
    }
}


























