using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InventoryManagement
{
     class Program
    {
       public static void Main(string[] args)
        {
            string Path = "C:\\Users\\SONALI MAHAPATRA\\237\\InventoryManagement\\InventoryManagement\\Inventory.json";
;           FetchInventoryDetails fetchInventoryDetails= new FetchInventoryDetails();
            Details data = fetchInventoryDetails.Read(Path);
            Console.WriteLine("Inventory Management");
            Console.WriteLine("Types of Rice:");
            
            

                Console.WriteLine(data.typesOfRice.name);
                Console.WriteLine(data.typesOfRice.Price);
                Console.WriteLine(data.typesOfRice.Weight);
            int CalculatePrice = data.typesOfRice.Price * data.typesOfRice.Weight;
            Console.WriteLine("The Price For " + data.typesOfRice.Weight + "kg is " + CalculatePrice);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Types of Wheat:");

            Console.WriteLine(data.typesOfWheat.name);
            Console.WriteLine(data.typesOfWheat.Price);
            Console.WriteLine(data.typesOfWheat.Weight);
            int CalculatePrice = data.typesOfWheat.Price * data.typesOfWheat.Weight;
            Console.WriteLine("The Price For " + data.typesOfWheat.Weight + "kg is " + CalculatePrice);
            Console.WriteLine("-------------------------");

            Console.WriteLine("Types of Pulses:");

            Console.WriteLine(data.typesOfPulses.name);
            Console.WriteLine(data.typesOfPulses.Price);
            Console.WriteLine(data.typesOfPulses.Weight);
            int CalculatePrice = data.typesOfPulses.Price * data.typesOfPulses.Weight;
            Console.WriteLine("The Price For " + data.typesOfPulses.Weight + "kg is " + CalculatePrice);
            Console.WriteLine("-------------------------");

            Console.Read();
            
            

        }
    }
}
