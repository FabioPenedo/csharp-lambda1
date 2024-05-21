using System.Globalization;

namespace App.Entities
{
    internal class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(Product? obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing error: argument is not an Product");
            }
   
            return Name.ToUpper().CompareTo(obj.Name.ToUpper());
        }
    }
}
