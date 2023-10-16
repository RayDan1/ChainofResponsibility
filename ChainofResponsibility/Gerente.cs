namespace ChainofResponsibility
{
    internal class Gerente : IVenta
    {
        public double CalcularPrecioFinal( int _Cantidad, double _Precio)
        {
            Console.WriteLine( "El Gerente" );
            return _Cantidad * _Precio;
        }
    }
}
