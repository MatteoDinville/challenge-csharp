using System;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; }

        public Car() : base()
        {
            Brand = "Unknown";
        }

        public Car(string Color, string Brand, string Model, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            this.Model = Model;
        }
        public override string ToString()
        {
            string Template = "{0} {1} {2}";
            return string.Format(Template, this.Color, this.Brand, this.Model);
        }
    }
}
