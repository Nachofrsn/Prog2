using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public class Pintura
    {
        //ES_LATEX, ES_SECADO_RAPIDO, CAPACIDAD_COBERTURA 
        private bool _secadoRapido;
        private bool _esLatex;
        private int _capacidadCobertura;
        private bool _esLavable;
        public Pintura()
        {
            SecadoRapido = false;
            Es_Latex = false;
            CapacidadCobertura = 0;
        }

        public bool SecadoRapido
        {
            get { return _secadoRapido; }
            set { _secadoRapido = value;}
        }

        public bool Es_Latex
        {
            get { return _esLatex; }    
            set { _esLatex = value;}
        }

        public int CapacidadCobertura
        {
            get { return _capacidadCobertura; }
            set { _capacidadCobertura = value;}
        }
    }
}
