namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public int Tonnage { get; set; }

        public Truck() : base()
        {
            Tonnage = 0;
        }

        public Truck(int Tonnage, string Brand, string Color, int CurrentSpeed = 0) : base(Brand, Color, CurrentSpeed)
        {
            this.Tonnage = Tonnage;
        }

        public override string ToString()
        {
            string Template = "{0} {1} {2} + T Truck";
            return string.Format(Template, this.Color, this.Brand, this.Tonnage);
        }

        public override void Accelerate(int Speed)
        {
            if (CurrentSpeed + Speed <= 100)
            {
                CurrentSpeed += Speed;
            }
            else
            {
                CurrentSpeed = 100;
            }
        }

        public override void Brake(int BrakePower)
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
