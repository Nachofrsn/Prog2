using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Jugador
    {
        private string _nombre;
        private int _numero;

        public Jugador()
        {
            this.Nombre = "";
            this.Numero = 0;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string Auto
        {
            get { return _nombre + "," + _numero; }
        }
    }
}

