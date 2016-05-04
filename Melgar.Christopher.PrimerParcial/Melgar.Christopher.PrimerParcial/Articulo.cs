using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Melgar.Christopher.PrimerParcial.C;
using Melgar.Christopher.PrimerParcial.A;
using Melgar.Christopher.PrimerParcial.V;


namespace Melgar.Christopher.PrimerParcial.A
{
    class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precioCosto = precioCosto;
            this._stock = cantidad;
        }

        public string NombreYcodigo
        {
            get
          {
              return this._nombre+this._codigo;
          }

        }

        public float PrecioVenta
        {
            get
            {
                return this._precioVenta;
            }
        }

        public int Stock
        {     
            //get
            //{
            //    return this._stock;
            //}
            set
            {
                this._stock++;           
            }

            //No vine a la clase de Propiedades no sabia que entraba en el parcial u_u.
        }

        public bool HayStock(int cantidad)
        {
            bool siHay = false;

            if (this._stock >= cantidad)
            {
                siHay = true;
            }

            return siHay;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            bool comparacion = false;

            if (articuloUno._nombre == articuloDos._nombre && articuloUno._codigo == articuloDos._codigo)
	        {
		        comparacion = true;
	        }

            return comparacion;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno == articuloDos);
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            int sumaDeStock = 0;

            sumaDeStock = articuloUno._stock + articuloDos._stock;

            //articuloUno._stock = articuloUno._stock + articuloDos._stock;

            return sumaDeStock;
        }

        public static int operator -(Articulo articuloUno, int cantidad)
        {
            int stockActual = 0;

            stockActual = articuloUno._stock - cantidad;

            return stockActual;
        }

    }
}
