using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class HerramientaInalambrica : Articulo
    {
        //VOLTAJE, ENCENDER, APAGAR, INCLUYE_BATERIA
        private bool _incluyeBateria;
        private int _voltaje;

        public HerramientaInalambrica(bool incluyeBateria, int voltaje)
        {
            IncluyeBateria = incluyeBateria;
            Voltaje = voltaje;
        }

        public bool IncluyeBateria
        {
            get { return _incluyeBateria;}
            set { _incluyeBateria = value; }
        }

        public int Voltaje
        {
            get { return this._voltaje; }
            set { this._voltaje = value;}
        }

        public bool Encender()
        {
            return true;
        }

        public bool Apagar()
        {
            return false;
        }
    }
}
