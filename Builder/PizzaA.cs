using Builder.Models;
using System;

namespace Builder
{
    public class PizzaA : PizzaBuilder
    {

        public PizzaA()
        {
            Pizza = new Pizza();
        }

        public override void AddCheese()
        {
            Pizza.Cheese = false;
        }

        public override void AddHam()
        {
            Pizza.Ham = true;
        }

        public override void Bake()
        {
            Pizza.Baked = true;
        }

        public override void GetPizza()
        {
            Console.WriteLine($"{Pizza.Name} cheese: {Pizza.Cheese} ham: {Pizza.Ham}");
        }

        public override void SetName()
        {
            Pizza.Name = "Capricosa";
        }
    }
}
