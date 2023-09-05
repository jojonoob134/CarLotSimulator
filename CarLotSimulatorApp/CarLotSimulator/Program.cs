﻿using Microsoft.VisualBasic;
using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            Car car1 = new Car();
            car1.Year = 2007;
            car1.Model = "VX1100 WAVERUNNER VX";
            car1.Make = "YAMAHA";
            car1.EngineNoise = "vroom vroom";
            car1.HonkNoise = "hOnk hoNk";
            car1.IsDriveable = false;
            car1.MakeEngineNoise(car1);

            Car car2 = new Car { Year = 2002, Model = "DS50", Make = "BOMBARDIER", EngineNoise = "sizzle", HonkNoise = "hoNk honK", IsDriveable = false };
            car1.MakeEngineNoise(car2);
            Car car3 = new Car()
            {
                Make = "RAM",
                Model = "4500",
                Year = 2014,
                EngineNoise = "engin noises",
                HonkNoise = "HONK honk",
                IsDriveable = false
            };

            car1.MakeEngineNoise(car3);




        }

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
    }
}

