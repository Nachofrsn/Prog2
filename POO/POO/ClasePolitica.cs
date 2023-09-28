using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ClasePolitica
    {
        private string _milei;
        private string _massita;
        private string _pato;


        public string Casta
        {
            get { return this._massita + "," + this._pato; }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    this._massita = value;
                    this._pato = value;
                }
            }
        }

        public string Afueraa
        {
            get { return this._milei; }
        }

        public string elecciones
        {
            get { return this._milei; }
            set
            {
                if (value.Trim() != string.Empty)
                {
                    this._milei = value;
                }
            }
        }
    }


}
