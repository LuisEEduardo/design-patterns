namespace example_pizza.src
{
    public class PizzaCreator
    {
        public static Pizza Criar(Tamanho tamanho, string sabor)
        {
            switch (tamanho)
            {
                case Tamanho.Pequena:
                    return new PizzaPequena(sabor, Tamanho.Pequena);
                case Tamanho.Media:
                    return new PizzaMedia(sabor, Tamanho.Media);
                case Tamanho.Grande:
                    return new PizzaGrande(sabor, Tamanho.Grande);
                default:
                    throw new ApplicationException("Pizza desconhecida");
            }
        }
    }
}