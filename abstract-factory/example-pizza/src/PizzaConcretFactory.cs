namespace example_pizza.src
{
    public class PizzaConcretFactory : AbstractFactory
    {
        public override Pizza CriarPizza(string sabor, Tamanho tamanho)
        {
            return PizzaCreator.Criar(tamanho, sabor);
        }
    }
}