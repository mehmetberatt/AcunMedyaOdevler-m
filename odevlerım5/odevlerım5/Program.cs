using System;
using System.Collections.Generic;

namespace odevlerım5

{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> arabalar = new List<Car>()
            {
                new Car { Marka = "Toyota", Model = "Corolla", FuelConsumption = 6.5, TotalDistance = 5000 },
                new Car { Marka = "BMW", Model = "X5", FuelConsumption = 9.0, TotalDistance = 5000 },
                new Car { Marka = "Mercedes", Model = "C200", FuelConsumption = 8.2, TotalDistance = 5000 }
            };

            foreach (var araba in arabalar)
            {
                double toplamTuketim = araba.CalculateTotalFuel();
                Console.WriteLine($"Marka: {araba.Marka}, Model: {araba.Model}, 100 km'de Yaktığı Yakıt: {araba.FuelConsumption} litre, Toplam Yakıt Tüketimi: {toplamTuketim} litre");
            }
        }
    }
}