using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Persona 
    {
        //propiedades
        private string _Nombre;
        private string _Apellido;

        //Metodos de propiedad
        public string Nombre
        {
            get { return this._Nombre;}
            set { this._Nombre = value; }
        }
        public string Apellido
        {
            get { return this._Apellido; }
            set
            {
                //trim() es para sacar espacios, es decir, deberia quedar todo texto
                if (value.Trim() != string.Empty)
                {
                    this._Apellido = value;
                }
            }
        }
    }
}
