using System;
namespace SampleSolution_CmdLineShop_3BHEL
{
	public class Cart
	{
		public List<Product> Products { get; set; }

		public Cart()
		{
			Products = new List<Product>();
		}

		public void AddProduct(Product p)
		{
			Products.Add(p);
		}


        public double CalculateTotalAmount()
		{
			double sum = 0;

			foreach (Product p in Products)
			{
				sum += p.Price;
			}

			return sum;
		}

		public double CalculateTotalTax()
		{
			double sum = 0;

			foreach (Product p in Products)
			{
				sum += p.GetTaxAmount();
			}

			return sum;
		}
	}
}

