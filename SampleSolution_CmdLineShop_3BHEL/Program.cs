namespace SampleSolution_CmdLineShop_3BHEL;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of products for our Shop
        List<Product> products = new List<Product>();
        products.Add(new Product("12345", "Iron Man Action Figure", 149.99));
        products.Add(new Product("23456", "Thor Action Figure", 129.99));
        products.Add(new Product("34567", "Black Widow Action Figure", 199.99));
        products.Add(new Product("45678", "Captain Marvel Action Figure", 249.99));

        // Create the shop and add products to the shop
        Shop CmdLineShop = new Shop("Welcome to the Avengers Store!");
        CmdLineShop.Products = products;

        string action = "";
        bool exitShop = false;

        while (!exitShop)
        {
            // show menu
            CmdLineShop.ShowMenu();
            Console.WriteLine();

            // action for product-overview
            if (action == "p")
            {
                CmdLineShop.ShowProducts();
                Console.WriteLine();
            }

            // action for adding a product
            if (action == "a")
            {
                CmdLineShop.ShowProducts();
                Console.WriteLine();
                Console.WriteLine("Please Enter the sku:");
                string sku = Console.ReadLine();

                CmdLineShop.AddProductToCart(sku);
                Console.WriteLine();
            }

            // show cart
            if (action == "sc")
            {
                CmdLineShop.ShowProductsInCart();
                Console.WriteLine();
            }

            // get the desired action
            Console.WriteLine("Enter your option:");
            action = Console.ReadLine();
            exitShop = action == "c";

            Console.Clear();
        }

        if (action == "c")
        {
            Console.WriteLine("Checking out:");
            Console.WriteLine();

            CmdLineShop.ShowProductsInCart();
            Console.WriteLine(new String('-', 46));
            Console.WriteLine(String.Format("{0, -37} {1, 8:C}", "Total tax", CmdLineShop.ShopCart.CalculateTotalTax()));
            Console.WriteLine(String.Format("{0, -37} {1, 8:C}", "Total amount", CmdLineShop.ShopCart.CalculateTotalAmount()));
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for your visit!");
    }
}

