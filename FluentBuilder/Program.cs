using System;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            var pizzeria = new Pizzeria();

            var pizzaA = pizzeria.Construct(new PizzaA());
            Console.WriteLine($"{pizzaA.Name} cheese: {pizzaA.Cheese} ham: {pizzaA.Ham}");

            var pizzaB = pizzeria.Construct(new PizzaB());
            Console.WriteLine($"{pizzaB.Name} cheese: {pizzaB.Cheese} ham: {pizzaB.Ham}");

            Console.ReadLine();

        }
    }
}
