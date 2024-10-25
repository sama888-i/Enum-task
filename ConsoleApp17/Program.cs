using Core.Models;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        { bool f = false;
          string operation;
          Store store = new Store();
            int no;
            string name;
            double price;
            try
            {
                do
                {
                    Console.WriteLine("Choose Operation: 1.Mehsul elave et ,2. '_'-nomreli mehsulu sil,3.'_'-nomreli mehsulu elde et,4.Mehsulu adina gore filter etmek ucun sec,5.mehsullarin hamisini gormek ucun sec,6.Cixis etmek ucun sec");
                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "1":
                            Console.Clear();
                            bool s;
                            do
                            {
                                Console.WriteLine("Mehsulun nomresini daxil edin :");
                                s = int.TryParse(Console.ReadLine(), out no);


                            } while (!s);
                            Console.WriteLine("Mehsulun adini daxil edin:");
                            name = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Mehsulun qiymetini daxil edin:");
                                s = double.TryParse(Console.ReadLine(), out price);


                            } while (!s);
                            store.AddProduct();

                            break;
                        case "2":
                            Console.Clear();
                            s = false;
                            do
                            {

                                Console.WriteLine("Silmek istediyiniz Mehsulun nomresini daxil edin");
                                s = int.TryParse(Console.ReadLine(), out no);
                            } while (!s);
                            store.RemoveProductByNo(no);
                            break;
                        case "3":
                            Console.Clear();
                            s = false;
                            do
                            {

                                Console.WriteLine("Elde etmek istediyiniz mehsulun nomresini daxil edin");
                                s = int.TryParse(Console.ReadLine(), out no);
                            } while (!s);
                            store.GetProduct(no);
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Axtardiginiz mehsuun adini daxil edin");
                            name = Console.ReadLine();
                            store.FilterProductByName(name);
                            break;
                        case "5":

                            store.GetAllProducts();
                            break;












                        case "6":
                            f = true;
                            break;

                        default:
                            Console.WriteLine("Duzgun secim edin");
                            break;





                    }





                } while (!f);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
