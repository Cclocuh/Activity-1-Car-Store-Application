using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassLibrary
{
    public class Program
    {
        static Store CarStore = new Store();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store. First you must create some cars " +
                "and put them into the store inventory. Then you may add cars to the cart." +
                " Finally, you may checkout, which will calculate your total bill");

            int action = chooseAction();
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        // You chose add a car
                        Console.Out.WriteLine("You chose to add a new car to the store");

                        // ask for three property details
                        String carMake = "";
                        String carModel = "";
                        Decimal carPrice = 0;
                        String carColor = "";
                        int carYear = 0;

                        Console.Out.Write("What is the car make? Ford, GM, Toyota ect ");
                        carMake = Console.ReadLine();

                        Console.Out.Write("What is the car model? corvette, Focus, Ranger ");
                        carModel = Console.ReadLine();

                        Console.Out.Write("What is the car price? Only numbers please ");
                        carPrice = int.Parse(Console.ReadLine());

                        Console.Out.Write("What is the car color? Red, Yellow, Black ect ");
                        carColor = Console.ReadLine();

                        Console.Out.Write("What is the car year? Only numbers please ");
                        carYear = int.Parse(Console.ReadLine());

                        // crreate a new car object and add it to the list
                        Car newCar = new Car();
                        newCar.Make = carMake;
                        newCar.Model = carModel;
                        newCar.Price = carPrice;
                        newCar.Color = carColor;
                        newCar.Year = carYear;
                        CarStore.CarList.Add(newCar);
                        printStoreInventory(CarStore);
                        break;

                    case 2:
                        // You chose buy a car

                        // display the list cars in inventory
                        printStoreInventory(CarStore);

                        // ask for a car number to purchase
                        int choice = 0;
                        Console.Out.Write("Which car would you like to add to the cart? (number) ");
                        choice = int.Parse(Console.ReadLine());

                        // add the car to the shopping cart
                        CarStore.ShoppingList.Add(CarStore.CarList[choice]);

                        printShoppingCart(CarStore);
                        break;

                    case 3:
                        // checkout
                        printShoppingCart(CarStore);
                        Console.Out.WriteLine("Your total cost is $(0)", CarStore.checkout());

                        break;

                    default:
                        break;

                }
                // add case statments and actions here
                action = chooseAction();
            }
            action = chooseAction();
        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.Out.Write("Choose an action (0) quite (1) add a car (2) add item to cart (3) checkout ");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static public void printStoreInventory(Store CarStore)
        {
            Console.Out.WriteLine("These are the cars in the store inventory:");
            int i = 0;
            foreach (var c in CarStore.CarList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
                i++;
            }
        }

        static public void printShoppingCart(Store CarStore)
        {
            Console.Out.WriteLine("These are the cars in your shopping cart:");
            int i = 0;
            foreach (var c in CarStore.ShoppingList)
            {
                Console.Out.WriteLine(String.Format("Car # = {0} {1} ", i, c.Display));
                i++;
            }
        }
    }
}
