using Core.Helpers.Enum;
using Core.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Product
    {
        static int _no;
        public string Name;
        public double _price;
        public int No { get; set; }
        public Types Type { get; set; }
        public Product(string name,double price)
        {
            _no++;
            No = _no;
            Name = name;
            Price = price;

            
        }
        public double Price
        {
            get
            {
                return _price;

            }
            set
            {if(_price < 0)
                {
                    throw new PriceMustBeGratherThanZeroException(" 0 dan yuksek eded daxil edin");
                }
                else
                {
                    _price = value;
                }

            }
        
        }

        public void ShowInfo()
        {
            Console.WriteLine($"No:{No},Name:{Name},Price:{Price},Type:{Type}");
        }

    }
}
