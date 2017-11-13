using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder pizzaBuilder;

            var pizzeria = new Pizzeria();

            pizzaBuilder = new PizzaA();
            pizzeria.Construct(pizzaBuilder);

            pizzaBuilder = new PizzaB();
            pizzeria.Construct(pizzaBuilder);

            Console.ReadLine();
        }
    }
}
