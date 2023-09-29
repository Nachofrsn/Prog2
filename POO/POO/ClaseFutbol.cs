﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class ClaseFutbol
    {
        private List<ClaseFutbol> _equiposFutbol;
        private int _jugadores;
        private string _nombre;

        public ClaseFutbol(int jugadores, string nombre)
        {
            this.Jugadores = jugadores;
            this.Nombre = nombre;
            this._equiposFutbol = new List<ClaseFutbol>();
        }
        public int Jugadores
        {
            get { return _jugadores; }
            set { _jugadores = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Equipo
        {
            get { return _nombre + "," + _jugadores; }
        }
        public int CantidadEquipos
        {
           get 
           {
               int cantEquipos = 0;
               foreach (ClaseFutbol equipoAux in _equiposFutbol)
               {
                    cantEquipos++;
               } 
               return cantEquipos;
           }
        }
        public bool AgregarEquipo (ClaseFutbol nuevoEquipo)
        {
            this._equiposFutbol.Add(nuevoEquipo);
            return true;
        }
        public bool AgregarCapitan (string equipo, string capitan)
        {
            for (int a = 0; a < CantidadEquipos; a++)
            {
                if (equipo == this._equiposFutbol[a].Nombre) 
                { 
                    
                }
            }
        }
    }
}
