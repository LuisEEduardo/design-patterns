namespace example_pizza.src
{
    public class PizzaGrande : Pizza
    {
        public PizzaGrande(string sabor, Tamanho tamanho) : base(sabor, tamanho)
        {
        }

        public override void DescreverPizza()
        {
            System.Console.WriteLine($"Pizza => {Sabor} | Tamanho: grande");
        }
    }
}