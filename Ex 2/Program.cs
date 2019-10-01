﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    public class Car
    {
        private string make;
        public string Make
        {
            get { return this.make; }
            set { this.make = value;  }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private double engineSize;

            public double EngineSize
        {
            get { return EngineSize; }
            set { engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Current Speed: {CurrentSpeed} k/mh");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }

        public override string ToString()
        {
            return
                string.Format($"Car Make: {Make}" +
                              $"\nCar Model: {Model}" +
                              $"\nCurrent Speed: {CurrentSpeed}" +
                              $"\nEngine Size: {EngineSize}");
        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current Speed is {CurrentSpeed}");
        }
    }
}
