namespace example_pizza.src
{
    // Abstract factory
    public abstract class Pizza
    {
        protected Pizza(string sabor, Tamanho tamanho)
        {
            Sabor = sabor;
            Tamanho = tamanho;
        }

        public string Sabor { get; set; }
        public Tamanho Tamanho { get; set; }

        public abstract void DescreverPizza();        

    }
}