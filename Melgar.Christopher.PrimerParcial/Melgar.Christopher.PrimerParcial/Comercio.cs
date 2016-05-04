using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melgar.Christopher.PrimerParcial.A;
using Melgar.Christopher.PrimerParcial.V;
using Melgar.Christopher.PrimerParcial.C;

namespace Melgar.Christopher.PrimerParcial.C
{
    class Comercio
    {
        private string _dueño;
        private List<Articulo> _misArticulos;
        private List<Venta> _misVentas;

        public Comercio(string dueño)
        {
            this._dueño = dueño;
            this._misArticulos = new List<Articulo>();
            this._misVentas = new List<Venta>();
        }

        public static void MostrarArticulos(Comercio comercioAMostrar)
        {
            foreach (Articulo item in comercioAMostrar._misArticulos)
            {
                Console.WriteLine(item.NombreYcodigo);
            }
        }

        public static void MostrarGanancia(Comercio comercioParaResumen)
        {

            Console.WriteLine("La Ganancia obtenida es de: ");
        }

        public void VenderArticulo(Articulo articuloSolicitado, int cantidad)
        {
            foreach (Articulo item in this._misArticulos)
            {
                if (item==articuloSolicitado)
                {
                    if (item.HayStock(cantidad))
                    {
                       item.Stock = item - cantidad;
                    }
                }
            }

            //for (int i = 0; i < this._misArticulos.Count; i++)
            //{
            //    if ()
            //    {
                    
            //    }
            //}
        }

        public void ComprarArticulo(Articulo articuloComprado)
        {

            foreach (Articulo item in this._misArticulos)
            {
                if (item == articuloComprado)
                {
                    item.Stock = item + articuloComprado;
                    
                }
                
            }

            
            
            this._misArticulos.Add(articuloComprado);
              
        }
    }
}
