namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente();
            JefePiso jefePiso = new JefePiso(gerente);
            Vendedor vendedor = new Vendedor(jefePiso);

            int cantidad = 10;
            double precio = 1000;
            double total = 0;

            total = vendedor.CalcularPrecioFinal(cantidad, precio);
            Console.WriteLine("El precio final es: " + total);
        }
    }
}