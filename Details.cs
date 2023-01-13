using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace InventoryManagement
{
    public class Details
    {
        public TypesOfRice typesOfRice;
        public TypesOfWheat typesOfWheat;
        public TypesOfPulses typesOfPulses;
    }

    public class TypesOfRice
    {
        public string name;
        public int Weight;
        public int Price;
    }

    public class TypesOfWheat
    {
        public string name;
        public int Weight;
        public int Price;
    }

    public class TypesOfPulses
    {
        public string name;
        public int Weight;
        public int Price;
    }
}