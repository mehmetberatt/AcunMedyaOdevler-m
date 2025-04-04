namespace odevlerım5
{
    public class Car
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double FuelConsumption { get; set; } // 100 km'de yakıt (litre)
        public double TotalDistance { get; set; }   // km

        public double CalculateTotalFuel()
        {
            return (TotalDistance / 100) * FuelConsumption;
        }
    }
}