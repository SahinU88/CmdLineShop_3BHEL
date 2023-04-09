using System;
namespace SampleSolution_CmdLineShop_3BHEL
{
	public class Product
	{
        public string SKU { get; private set; }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public Product(string sku, string name, double price)
        {
            SKU = sku;
            Name = name;
            Price = price;
        }

        public double GetTaxAmount()
        {
            return Price * 0.2;
        }
    }
}

