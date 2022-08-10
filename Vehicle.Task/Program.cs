using System;

namespace Vehicle.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("bmw", "black", "X5", 2011, 50, 3, 40);
            bmw.ShowInfo();
            bmw.Drive(5);
        }
    }
}
