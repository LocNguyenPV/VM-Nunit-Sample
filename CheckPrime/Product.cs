using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public float Price { get; set; }
        public float TotalPrice
        {
            get
            {
                return Amount * Price;
            }
        }

        public override string ToString()
        {
            return $@"Name: {Name} - Description: {Description}";
        }
    }
}
