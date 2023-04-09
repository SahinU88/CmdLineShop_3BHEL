using System;
namespace SampleSolution_CmdLineShop_3BHEL
{
	public class Customer
	{
        public string Name { get; private set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public Customer(string name)
        {
            Name = name;
        }
    }
}

