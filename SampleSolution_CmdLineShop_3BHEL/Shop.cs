using System;

namespace SampleSolution_CmdLineShop_3BHEL
{
	public class Shop
	{
		public String Name { get; set; }

		public Cart ShopCart { get; set; }

		public List<Product> Products { get; set; }

		public List<Customer> Customers { get; set; }

		public Shop(string name)
		{
			Name = name;
			ShopCart = new Cart();
			Products = new List<Product>();
            Customers = new List<Customer>();
		}

		public void ShowMenu()
		{
			Console.WriteLine("To navigate the shop:");
			Console.WriteLine("'p' - Show all products");
			Console.WriteLine("'a' - Add product to cart");
			Console.WriteLine("'sc' - Show your cart");
			Console.WriteLine("'c' - Checkout");
		}


        public void ShowProducts()
		{
			Console.WriteLine("Our products:");
			Console.WriteLine();

			PrintProducts(Products);
		}

		public void ShowProductsInCart()
		{

            Console.WriteLine("Your current cart:");
            Console.WriteLine();

            PrintProducts(ShopCart.Products);
        }


        public void AddProductToCart(string sku)
		{
			// search for the sku and check if it's valid
			// if yes, add it to the cart
			// if not, show the user a warning

			Product productToAdd = Products.Find(p => p.SKU == sku); // advanced version of a search in a list

            // we can also just use a loop here
            // foreach (Product p in Products)
            // {
            //     if (p.SKU == sku)
            //     {
            //         productToAdd = p;
            //     }
            // }

            if (productToAdd != null)
			{
                ShopCart.AddProduct(productToAdd);

				Console.WriteLine("Product added to your cart!");
            } else
			{
				Console.WriteLine("The product with the given sku was not found.");
			}
		}


        private void PrintProducts(List<Product> products)
		{
			// Header row
			Console.WriteLine(String.Format("|{0, -5}|{1, -30}|{2, 8:C}", "SKU", "Name", "Price"));
			Console.WriteLine(new String('-', 46));

            foreach (Product p in products)
            {
                Console.WriteLine(String.Format("|{0, 5}|{1, -30}|{2, 8:C}", p.SKU, p.Name, p.Price));
            }
        }
    }
}

