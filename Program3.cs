using System;
using System.Collections.Generic;

namespace ConsoleApp14
{
    class Program3
    {
        static void Main(string[] args)
        {
            string decide = "y";
            string selectFlower;
            FlowerStore flowerStore = new FlowerStore();
            PrintMyFlower(decide, flowerStore);
            Console.ReadLine();

            static void PrintMyFlower(string decide, FlowerStore flowerStore)
            {
                string selectFlower;

                Console.WriteLine("Select number for buy flower :");
                foreach (string i in flowerStore.flowerList)
                {
                    Console.Write((flowerStore.flowerList.IndexOf(i) + 1) + " ");
                    Console.WriteLine(i);
                }
                selectFlower = Console.ReadLine();
            {
              
                }
                selectFlower = Console.ReadLine();
                switch (selectFlower)
                {
                    case "1":
                        flowerStore.addToCart(flowerStore.flowerList[0]);
                        Console.WriteLine("Added " + flowerStore.flowerList[0]);
                        break;
                    case "2":
                        flowerStore.addToCart(flowerStore.flowerList[1]);
                        Console.WriteLine("Added " + flowerStore.flowerList[1]);
                        break;
                    default:
                        Console.WriteLine("Not Added to cart. found select number of flower");
                        break;
                }

                Console.WriteLine("You can stop this progress ? exit for >> exit << progress and press any key for continue");
                decide = Console.ReadLine();
                if (decide == "exit")
                {
                Console.Write("Current my cart");
                flowerStore.showCart();
                }
            }
        }
    }
    class FlowerStore
    {
        public List<string> flowerList = new List<string>();
        List<string> cart = new List<string>();
        public FlowerStore()
        {
            flowerList.Add("Rose");
            flowerList.Add("Lotus");
        }
        public void addToCart(string name)
        {
            cart.Add(name);
        }

        public void showCart()
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty");
            }
            else
            {
                Console.WriteLine("My Cart :");
                foreach (string i in cart)
            {
                Console.WriteLine(i);
            }
        }
    }
}
}
