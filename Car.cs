﻿using System;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; }

        public Car() : base()
        {
            Brand = "Unknown";
            this.Model = "Unknown";
        }

        public Car(string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Color, Brand, CurrentSpeed)
        {
            this.Model = Model;
            this.Color = Color;
            this.Brand = Brand;
            this.CurrentSpeed = CurrentSpeed;
        }
        public override string ToString()
        {
            string Template = "{0} {1} {2}";
            return string.Format(Template, this.Color, this.Brand, this.Model);
        }
        public void Accelerate(int Speed)
        {
            if (CurrentSpeed + Speed <= 180)
            {
                CurrentSpeed += Speed;
            }
            else
            {
                CurrentSpeed = 180;
            }
        }
        public   void Brake(int BrakePower)
        {
            if (CurrentSpeed - BrakePower >= 0)
            {
                CurrentSpeed -= BrakePower;
            }
            else
            {
                CurrentSpeed = 0;
            }

        }
    }
}