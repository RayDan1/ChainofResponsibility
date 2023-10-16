namespace ChainofResponsibility
{
    internal class JefePiso : IVenta
    {
        private IVenta _Siguiente;
        public JefePiso(IVenta siguiente)
        {
              _Siguiente = siguiente;
        }
        public double CalcularPrecioFinal( int _Cantidad, double _Precio)
        {
            Console.WriteLine( "El Jefe de Piso" );

            double total = _Cantidad * _Precio;
            if ( _Cantidad > 100 || total > 10000)
                total = _Siguiente.CalcularPrecioFinal( _Cantidad, _Precio );
            return total;
        }
    }
}
