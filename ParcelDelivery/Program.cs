using System;
using ParcelDelivery.Domain;

namespace ParcelDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var weight = Console.ReadLine();
            var parcel = new Parcel(Int32.Parse(value), Int32.Parse(weight));
            // A Factory gives me the right implementation of IDepartment for this parcel 
            //and I call handle method of it
        }
    }
}
