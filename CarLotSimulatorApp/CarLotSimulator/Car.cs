﻿using System;
namespace CarLotSimulator
{
	public class Car
	{
       
        //done //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //done //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
       //done //The methods should take one string parameter: the respective noise property
        public Car()
		{
            CarLot.numberOfCars++;
		}

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDriveable;
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set;  }
        public bool IsDrivable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.WriteLine(HonkNoise);
        }
	}
}

