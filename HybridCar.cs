namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IElectricCar, IThermalCar
    {

        public int FuelLevel
        {
            get;
            set;
        }

        public int BatteryLevel
        {
            get;
            set;
        }

        public HybridCar() : base()
        {
            FuelLevel = 100;
            BatteryLevel = 100;
        }

        public HybridCar(string Model, string Brand, string Color, int CurrentSpeed = 0) : base(Model, Brand, Color, CurrentSpeed)
        {
            FuelLevel = 100;
            BatteryLevel = 100;
        }

        public void FillUp()
        {
            FuelLevel = 100;
        }

        public int GetFuelLevel()
        {
            return FuelLevel;
        }

        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }

        public override string ToString()
        {
            string strTemplate = "{0} {1} {2}, Battery: {3}%, Fuel: {4}%";
            return string.Format(strTemplate, this.Color, this.Brand, this.Model, this.BatteryLevel, this.FuelLevel);
        }
    }
}