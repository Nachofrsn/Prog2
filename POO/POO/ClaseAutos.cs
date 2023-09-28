using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ClaseAutos
    {
        private string _Patente;
        private string _Motor;

        public ClaseAutos()
        {
            this.Patente = "";
            this.Motor = "";
        }

        public string Patente
        {
            get { return _Patente; }
            set { _Patente = value; }
        }
        public string Motor
        {
            get { return _Motor; }
            set { _Motor = value; }
        }
        public string Auto
        {
            get { return _Patente + "," + _Motor; }
        }
    }
}

