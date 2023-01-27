namespace example_pizza.src
{
    public class PizzaMedia : Pizza
    {
        public PizzaMedia(string sabor, Tamanho tamanho) : base(sabor, tamanho)
        {
        }

        public override void DescreverPizza()
        {
            System.Console.WriteLine($"Pizza => {Sabor} | Tamanho: médio");
        }
    }
}