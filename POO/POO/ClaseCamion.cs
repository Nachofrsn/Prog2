using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

    class ClaseCamion
    {
        private string P_Patente;
        private string P_Chofer;
        private float P_MaxCargaKG;
        private List<ClaseCaja> P_Mercaderia;
        public ClaseCamion()
        {
            //Constructor
            this.Patente = "";
            this.Chofer = "";
            this.MaxCargaKG = 0;
            this.P_Mercaderia = new List<ClaseCaja>();
        }

        public ClaseCamion(string N_Patente, string N_Chofer, float N_MaxCargaKG)
        {
            //Constructor
            this.Patente = N_Patente;
            this.Chofer = N_Chofer;
            this.MaxCargaKG = N_MaxCargaKG;
            this.P_Mercaderia = new List<ClaseCaja>();
        }

        public string Patente
        {
            get
            {
                return P_Patente;
            }
            set
            {
                P_Patente = value;
            }
        }
        public string Chofer
        {
            get
            {
                return P_Chofer;
            }
            set
            {
                P_Chofer = value;
            }
        }
        public float MaxCargaKG
        {
            get
            {
                return P_MaxCargaKG;
            }
            set
            {
                P_MaxCargaKG = value;
            }
        }
        public int CantCajasCargadas
        {
            //propiedad de solo lectura
            get
            {
                return this.P_Mercaderia.Count;
            }
        }
        public float PesoKGMercaderia
        {
            //propiedad de solo lectura
            get
            {
                float TotalCargaKG;
                TotalCargaKG = 0;
                foreach (ClaseCaja CajaAux in this.P_Mercaderia)
                {
                    TotalCargaKG = TotalCargaKG + CajaAux.PesoKG;
                }
                return TotalCargaKG;
            }
        }
        public float PesoKGDisponible
        {
            //propiedad de solo lectura
            get
            {
                return this.MaxCargaKG - this.PesoKGMercaderia;
            }
        }
        public bool AgregarCaja(ClaseCaja N_Caja)
        {
            if (N_Caja.PesoKG <= this.PesoKGDisponible)
            {
                this.P_Mercaderia.Add(N_Caja);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool QuitarCaja(int PosCaja)
        {
            if (PosCaja >= 0 && PosCaja < this.CantCajasCargadas)
            {
                this.P_Mercaderia.RemoveAt(PosCaja);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RecuperarDatosCaja(int PosCaja, out ClaseCaja CajaRecuperada)
        {
            CajaRecuperada = null;
            if (PosCaja >= 0 && PosCaja < this.CantCajasCargadas)
            {
                CajaRecuperada = this.P_Mercaderia[PosCaja];
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RecuperarCajaCodigo(string codigo, out ClaseCaja cajaRecuperada)
        {
            cajaRecuperada = null;
            for (int a = 0; a < CantCajasCargadas; a++)
            {
                if (codigo == P_Mercaderia[a].CodigoInterno)
                {
                    cajaRecuperada = P_Mercaderia[a];
                    return true;
                }
            }
            return false;
        }
        ~ClaseCamion()
        {
            //destructor
        }
    }
}
