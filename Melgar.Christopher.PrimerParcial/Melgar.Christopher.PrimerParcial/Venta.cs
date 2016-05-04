using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melgar.Christopher.PrimerParcial.A;
using Melgar.Christopher.PrimerParcial.C;
using Melgar.Christopher.PrimerParcial.V;


namespace Melgar.Christopher.PrimerParcial.V
{
    class Venta
    {
        private Articulo _articuloVendido;
        private int _cantidad;

        public Venta(Articulo articuloVendido, int cantidad)
        {
            this._articuloVendido = articuloVendido;
            this._cantidad = cantidad;
        }

        public float RetornarGanancia()
        {
            float ganancia;

            ganancia = _articuloVendido.PrecioVenta * _cantidad;

            return ganancia;
        }


    }
}
