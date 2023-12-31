﻿using System.Reflection.Metadata.Ecma335;

namespace ChainofResponsibility
{
    internal class Vendedor : IVenta
    {
        private IVenta _Siguiente;
        public Vendedor(IVenta siguiente)
        {
              _Siguiente = siguiente;
        }
        public double CalcularPrecioFinal( int _Cantidad, double _Precio)
        {
            Console.WriteLine( "El Vendedor" );

            double total = _Cantidad * _Precio;
            if ( _Cantidad > 10 || total > 1000)
                total = _Siguiente.CalcularPrecioFinal( _Cantidad, _Precio );
            return total;
        }   
        
    }
}
