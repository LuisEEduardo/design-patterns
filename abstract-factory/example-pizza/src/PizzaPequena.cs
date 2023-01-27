namespace example_pizza.src
{
    public class PizzaPequena : Pizza
    {
        public PizzaPequena(string sabor, Tamanho tamanho) : base(sabor, tamanho)
        {
        }

        public override void DescreverPizza()
        {
            System.Console.WriteLine($"Pizza => {Sabor} | Tamanho: pequena");
        }
    }
}