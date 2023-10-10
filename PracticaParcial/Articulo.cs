using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public abstract class Articulo
    {
        //DESCRIPCION, CODIGOBARRA, STOCK, MARCA, MODELO, COSTO, PRECIO, ES_LAVABLE
        private string _codigoBarra;
        private string _modelo;
        private int _stock;
        private int _precio;
        private string _descripcion;
        private int _costo;
        private string _marca;

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public int Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion;}
            set { _descripcion = value;}
        }

        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        public string CodigoBarra
        {
            get { return _codigoBarra; }
            set { _codigoBarra = value;}
        }
    }
}
