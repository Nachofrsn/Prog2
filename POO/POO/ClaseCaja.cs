﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{

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
}



