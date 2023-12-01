using System;
namespace FactoryFood
{
    public interface IFoodItem
    {
        void DisplayDetails();
    }

    public class Pizza : IFoodItem
    {
        public void DisplayDetails()
        {
           PizzaMenu.DisplayPizzaMenu();
        }
    }
    public class Burger : IFoodItem
    {
        public void DisplayDetails()
        {
         BurgerMenu.DisplayBurgerMenu();
        }
    }
}