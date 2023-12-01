using System;

namespace FactoryFood
{
    class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Welcome to the Online Food Ordering System!\n 1. Pizza Restrorant \n 2. BurgerJoint");
            Console.WriteLine("Enter your choice :");
            String userInput = Console.ReadLine();

            if(userInput == "1")
            {
                IResturant resturantA = new PizzaResturant();
                IFoodItem foodItemA = resturantA.CreateFoodItem();
                foodItemA.DisplayDetails();
            }
            else if(userInput == "2")
            {
                IResturant resturantB = new BurgerJoint();
                IFoodItem foodItemB = resturantB.CreateFoodItem();
                foodItemB.DisplayDetails();
            }
            else
            {
                Console.WriteLine("OOPS! You choose the INVALID option.");
            }
        }
    }
}