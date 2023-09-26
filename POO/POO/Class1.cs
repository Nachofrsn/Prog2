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
        public Persona()
        {
            this.Apellido = "Perez";
            this.Nombre = "Lujan";
        }

        public Persona(string AP, string NOM)
        {
            this.Apellido = AP;
            this.Nombre = NOM;
        }
            
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

        public string Apelnom
        {
            get { return this.Apellido + "," + this.Nombre; }
        }
    }

    class Politica
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
    class ClaseCaja
    {
        private string P_CodigoInterno;
        private string P_Contenido;
        private float P_AltoCM;
        private float P_LargoCM;
        private float P_AnchoCM;
        private float P_PesoKG;
        private string P_Material;
        public ClaseCaja()
        {
            //Constructor
            this.CodigoInterno = "";
            this.Contenido = "";
            this.AltoCM = 0;
            this.LargoCM = 0;
            this.AnchoCM = 0;
            this.PesoKG = 0;
            this.Material = "";
        }

        public ClaseCaja(string N_CodigoInterno, string N_Contenido, float N_AltoCM, float N_LargoCM, float N_AnchoCM, float N_PesoKG, string N_Material)
        {
            //Constructor
            this.CodigoInterno = N_CodigoInterno;
            this.Contenido = N_Contenido;
            this.AltoCM = N_AltoCM;
            this.LargoCM = N_LargoCM;
            this.AnchoCM = N_AnchoCM;
            this.PesoKG = N_PesoKG;
            this.Material = N_Material;
        }
        public ClaseCaja(float N_AltoCM, float N_PesoKG, string N_Contenido, string N_CodigoInterno)
        {
            this.AltoCM = N_AltoCM;
            this.PesoKG = N_PesoKG;
            this.Contenido = N_Contenido;
            this.CodigoInterno = N_CodigoInterno;
        }
        public string CodigoInterno
        {
            get
            {
                return P_CodigoInterno;
            }
            set

            {
                P_CodigoInterno = value;

            }

        }
        public string Contenido

        {
            get

            {
                return P_Contenido;

            }
            set

            {
                P_Contenido = value;
            }

        }
        public float AltoCM

        {
            get

            {
                return P_AltoCM;

            }
            set

            {
                P_AltoCM = value;
            }

        }
        public float AnchoCM
        {
            get
            {
                return P_AnchoCM;
            }
            set
            {
                P_AnchoCM = value;
            }
        }
        public float LargoCM
        {
            get
            {
                return P_LargoCM;
            }
            set
            {
                P_LargoCM = value;
            }
        }
        public float PesoKG
        {
            get
            {
                return P_PesoKG;
            }
            set
            {
                P_PesoKG = value;
            }
        }
        public string Material
        {
            get
            {
                return P_Material;
            }
            set
            {
                P_Material = value;
            }
        }
        public float VolumenCM3
        {
            //propiedad de solo lectura
            get
            {
                return this.AltoCM * this.AnchoCM * this.LargoCM;
            }
        }
        ~ClaseCaja()
        {
            //destructor
        }
    }

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
                if (a == )
            }
        }
        }
 ~ClaseCamion()
        {
            //destructor
        }
    }
}
