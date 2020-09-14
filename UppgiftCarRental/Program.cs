using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftCarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            //Repository
            List<Car> CarsInStock = new List<Car>();

            CarsInStock.Add(new Car() { Make = "Volvo", Milage = 100 });
            CarsInStock.Add(new Car() { Make = "Volvo", Milage = 300 });
            CarsInStock.Add(new Car() { Make = "Audi", Milage = 50 });
            CarsInStock.Add(new Car() { Make = "Volvo", Milage = 75 });
            CarsInStock.Add(new Car() { Make = "Audi", Milage = 100 });

            Console.WriteLine("Det finns " + CarsInStock.Count());

            foreach (Car item in CarsInStock)
            {
                //Console.WriteLine($"{item.Make} {item.Milage} mil");
                Console.WriteLine(item);
            }


            Console.WriteLine("Make");
            string make = Console.ReadLine();
            string milage = Console.ReadLine();
            //

            CarsInStock.Add(new Car()
            {
                Make = make,
                Milage = int.Parse(milage)
            });

            foreach (Car item in CarsInStock)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Vi har {CarsInStock.Count} bilar i lager just nu");


            foreach (Car item in CarsInStock.OrderByDescending(x => x.Milage))
            {
                Console.WriteLine(item);
            }

            //LINQ, Lambda (Arrow-syntax)
            // => uttalas "goes to.."
            // x => x.Milage uttalas givet x ger det (goes det) orderbydesc baserat på milage
            // => innebär att vi syftar på kod i koden
            // LINQ get automatiskt en foreach av varje element, medlem i array, listan

            //CarsInStock detta är ett exempel på en SOURCE, i detta fall en lista av Car
            // => gör att vi automatiskt går igenom varje CAR i turordning i listan
            // vad som ska ske med Car bestämmer metoden och uttrycket efter =>
            // vi behöver kalla Car för något när vi loopas, det är valfritt, men brukar vara X

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(CarsInStock.Max(x => x.Milage));
            Console.WriteLine(CarsInStock.Min(x => x.Milage));
            Console.WriteLine(CarsInStock.Average(x => x.Milage));

            Console.WriteLine(CarsInStock.Find(x => x.Make == "BMW"));

            Console.WriteLine(CarsInStock.FindAll(x => x.Make=="Volvo").Count);
            List<Car> myVolvos = CarsInStock.FindAll(x => x.Make == "Volvo");
            Console.WriteLine(myVolvos.Count);

            Console.WriteLine(myVolvos.Average(x => x.Milage));
            Console.WriteLine(CarsInStock.Where(x => x.Make == "Volvo").Count());
        }
    }

    class Car
    {
        public string Make { get; set; }
        public int Milage { get; set; }

        public override string ToString()
        {
            return $"{Make} ({Milage} mil)";
        }
    }
}
