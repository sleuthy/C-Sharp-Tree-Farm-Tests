using System;
using System.Collections.Generic;

namespace TreeFarm
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class Tree
    {
        public double Height { get; set; } = 0;
        public string Location { get; set; } = "";
        public string Type { get; set; } = "";

        public string Move (string newLocation)
        {
            if (newLocation != this.Location)
            {
                this.Location = newLocation;
            }
            return this.Location;
        }

        public double Grow (double growth)
        {
            if (growth > 0.0)
            {
                this.Height += growth;
            }

            return this.Height;
        }
    }
}
