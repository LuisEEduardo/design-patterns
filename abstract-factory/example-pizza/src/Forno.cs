namespace example_pizza.src
{
    // Client Class
    public class Forno
    {
        private readonly Pizza _pizza;

        public Forno(PizzaConcretFactory factory, string sabor, Tamanho tamanho)
        {
            _pizza = factory.CriarPizza(sabor, tamanho);
        }

        public void PizzaPronta()
        {
            _pizza.DescreverPizza();
        }

        public static Forno CriarPizza(string sabor, Tamanho tamanho)
        {
            return new Forno(new PizzaConcretFactory(), sabor, tamanho);
        }
    }
}