using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Core.Helpers.Enum;
namespace Core.Models
{
    public class Store
    {
        Product[] Products;
        public Store()
        {
            Products = new Product[0];
        }
        public void AddProduct(params Product[] newProduct)
        {
            int oldLength = Products.Length;
            Array.Resize(ref Products, Products.Length + newProduct.Length);
            for(int i=0;i<newProduct .Length; i++)
            {
                Products[oldLength + i] = newProduct[i];
            }
        }
        public Product[] RemoveProductByNo(int no)
        {
             
            for(int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Products[i] = null;
                    Console.WriteLine(Products[i] + "-siyahidan silindi");
                    
                }
                else 
                {
                    
                    Console.WriteLine("bu nomrede bir  mehsul siyahida yoxdur");
                    
                }
                
            }
            return Products;


        }
        public Product GetProduct (int no)
        {
           Product foundProduct = null;
            for(int i=0; i<Products .Length; i++)
            {if(Products[i].No == no)
                {
                    foundProduct = Products[i];
                    return foundProduct;

                }
                               
            }
            return foundProduct;
        }
        public void FilterProductsByType(Types type)
        {
            foreach (var Product in Products)
            {
                if (Product.Type.ToString().Contains(type.ToString()))
                {
                    Console.WriteLine($"No{Product.No},Name{Product.Name},Price:{Product.Price},Type:{Product.Type}");
                }
                else
                {
                    Console.WriteLine("Bu tipde Mehsul Yoxdur");
                }

            }
        }
              

           
        public void FilterProductByName(string name)
        {foreach(var Product in Products)
            {if(Product.Name.ToLower().Contains(name.ToLower ()))
                {
                    Console.WriteLine($"No{Product.No},Name{Product.Name},Price:{Product.Price},Type:{Product.Type}");
                }
                else
                {
                    Console.WriteLine("bu adda mehsul yoxur");
                }

            }

        }
        public void GetAllProducts()
        {foreach (var Product in Products)
            {
                Product.ShowInfo();
            }

        }




        
        

    }
}
