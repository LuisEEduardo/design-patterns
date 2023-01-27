namespace example_pizza.src
{
    public abstract class AbstractFactory
    {
        public abstract Pizza CriarPizza(string sabor, Tamanho tamanho);
    }
}