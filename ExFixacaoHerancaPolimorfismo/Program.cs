using ExFixacaoHerancaPolimorfismo.Entities;
using System.Globalization;

namespace ExFixacaoHerancaPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                switch (op)
                {
                    case 'c':
                        products.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture date (DD/MM/YYY): ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        products.Add(new UsedProduct(name, price, date));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        products.Add(new ImportedProduct(name, price, custom));
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}