using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Task
{
    class Car:Vehicle
    {
        public string Brend;
        public string Model;
        public int FuelCapacity;
        public int FuelFor1Km;
        public int CurrentFuel;
        public Car(string Brend,string Color, string Model,int Year, int FuelCapacity,int FuelFor1Km,int CurrentFuel)
        {
            this.Brend = Brend;
            this.Color = Color;
            this.Model = Model;
            this.Year = Year;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
            this.CurrentFuel = CurrentFuel;
            
                
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{Brend} {Color} {Model} {Year} {FuelCapacity} {FuelFor1Km} {CurrentFuel} ");
        }
        public int Drive(int way)
        {    
            CurrentFuel = FuelCapacity - (FuelFor1Km * way);
            return CurrentFuel;
        }
    }
}
