 using System;

namespace FactoryFood
 {
    public class PizzaMenu
    {
       public static void DisplayPizzaMenu()
        {
        Console.WriteLine("Great Choice! You have selected Pizza Restaurant.");
        Console.WriteLine("1. Margherita");
        Console.WriteLine("2. Pepperoni");
        Console.WriteLine("3. Veggie");

        Console.WriteLine("Enter your choice :");
        String pizzaInput = Console.ReadLine();

        Console.WriteLine("Fantastic! You've ordered:");

        if (pizzaInput == "1")
        {
            Console.WriteLine("Name: Margherita Pizza");
            Console.WriteLine("Ingredients: Yak Cheese, Onion, Capsicum, Basil");
            Console.WriteLine("Price: NRs 450");
        }
        else if (pizzaInput == "2")
        {
            Console.WriteLine("Name: Pepperoni Pizza");
            Console.WriteLine("Ingredients: Pepperoni, Cheese, Tomato Sauce");
            Console.WriteLine("Price: 550"); 
        }
        else if (pizzaInput == "3")
        {
            Console.WriteLine("Name: Veggie Pizza");
            Console.WriteLine("Ingredients: Various Vegetables, Cheese");
            Console.WriteLine("Price: 350");
        }
        }
   }
 }
