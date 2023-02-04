using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate the a Carlot at the beginning of the program
            //and as you create a car add the car to the list
            var lot = new CarLot();
           
            //TODO

            //done //Create a seperate class file called Car
            //done //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            // done //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //done //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //instation 1
            var mircacleWhip = new Car();
            mircacleWhip.Make = "mercedes benz";
            mircacleWhip.Model = "g class";
            mircacleWhip.Year = 2004;
            mircacleWhip.EngineNoise = "yetothe";
            mircacleWhip.HonkNoise = "skrt";
            mircacleWhip.IsDrivable = true;

            lot.Cars.Add(mircacleWhip);


            //instation 2
            var pacWhip = new Car()
            {
                Make = "mercedes benz",
                Model = "500SL",
                Year = 1996,
                EngineNoise = "picturemerollinggg",
                HonkNoise = "beepbeep",
                IsDrivable = false
            };

            lot.Cars.Add(pacWhip);

            //instation 3
            var biggieWhip = new Car(1995, "lexus", "ls450", "beep", "baybebaybe", true);

            lot.Cars.Add(biggieWhip);

            //call methods
            mircacleWhip.MakeEngineNoise();
            pacWhip.MakeEngineNoise();
            biggieWhip.MakeEngineNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            {
                Console.WriteLine($"number of cars created: {CarLot.numberOfCars}");
            }
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"year: {car.Year} make: {car.Make} model: {car.Model}");
            }
        }
    }
}
