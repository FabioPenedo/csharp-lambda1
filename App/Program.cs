using App.Entities;

namespace App // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = [];
            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort();

            foreach (Product item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}