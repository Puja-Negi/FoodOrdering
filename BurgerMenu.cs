 using System;

namespace FactoryFood
 {
    public class BurgerMenu
    {
       public static void DisplayBurgerMenu()
        {
        Console.WriteLine("Great Choice! You have selected BurgerJoint.");
        Console.WriteLine("1. Classic Burger");
        Console.WriteLine("2. Chicken Spicy Burger");
        Console.WriteLine("3. Veggie Burger");
        Console.WriteLine("Enter your choice :");
        String burgerInput = Console.ReadLine();

        Console.WriteLine("Fantastic! You've ordered:");

        if (burgerInput == "1")
        {
            Console.WriteLine("Name: Classic Burger");
            Console.WriteLine("Ingredients: Yak Cheese, Onion, classic patty, Capsicum, Basil");
            Console.WriteLine("Price: NRs 450");
        }
        else if (burgerInput == "2")
        {
            Console.WriteLine("Name: Chicken Spicy Burger");
            Console.WriteLine("Ingredients: Pepperoni, Cheese, chicken patty, Tomato Sauce");
            Console.WriteLine("Price: 550"); 
        }
        else if (burgerInput == "3")
        {
            Console.WriteLine("Name: Veggie Burger");
            Console.WriteLine("Ingredients: Various Vegetables, veggie patty, Cheese");
            Console.WriteLine("Price: 350");
        }
        }
   }
 }