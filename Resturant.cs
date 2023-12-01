using System;
namespace FactoryFood
{
    public interface IResturant
    {
        IFoodItem CreateFoodItem();
    }

    public class PizzaResturant : IResturant
    {
        public IFoodItem CreateFoodItem()
        {
            return new Pizza();
        }
    }

    public class BurgerJoint : IResturant
    {
        public IFoodItem CreateFoodItem()
        {
            return new Burger();
        }
    }
}