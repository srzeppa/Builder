using Builder.Models;

namespace Builder
{
    public abstract class PizzaBuilder
    {
        protected Pizza Pizza { get; set; }

        public abstract void GetPizza();
        public abstract void AddCheese();
        public abstract void AddHam();
        public abstract void Bake();
        public abstract void SetName();

    }
}
