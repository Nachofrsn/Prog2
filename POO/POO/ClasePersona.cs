using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ClasePersona
    {
        //propiedades
        private string _Nombre;
        private string _Apellido;

        //Metodos de propiedad
        public ClasePersona()
        {
            this.Apellido = "Perez";
            this.Nombre = "Lujan";
        }

        public ClasePersona(string AP, string NOM)
        {
            this.Apellido = AP;
            this.Nombre = NOM;
        }

        public string Nombre
        {
            get { return this._Nombre; }
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

        public string Apelnom
        {
            get { return this.Apellido + "," + this.Nombre; }
        }
    }


}
