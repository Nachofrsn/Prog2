using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Futbol
    {
        private List<Jugador> _equiposFutbol; //Relacion de ensamble (contiene y utiliza)
        private string _tecnico;
        private int _cantJugadores;

        public Futbol(int jugadores, string tecnico)
        {
            this.CantJugadores = jugadores;
            this.Tecnico = tecnico;
            this._equiposFutbol = new List<Jugador>();
        }

        public int CantJugadores
        {
            get { return _cantJugadores; }
            set { _cantJugadores = value; }
        }

        public string Tecnico
        {
            get { return _tecnico; }
            set { _tecnico = value; }
        }

        public string Equipo
        {
            get { return "tecnico:" + Tecnico + "," + "cantidad de jugadores:" + CantJugadores; }
        }

        public Jugador NumeroMenor
        {
            get
            {
                Jugador x = null;
                foreach(Jugador j in _equiposFutbol)
                {
                    if (x == null) x = j;
                    else
                    {
                        if (j.Numero > x.Numero) x = j;
                    }
                }
                return x;
            }
        }

        public bool AgregarJugador(Jugador nuevoJugador)
        {
            if (this._equiposFutbol.Count <= CantJugadores)
            {
                this._equiposFutbol.Add(nuevoJugador);
                return true;
            }
            else
            {
                Console.WriteLine("Limite maximo de jugadores agregados alcanzado");
                return false;
            }
        }

        public bool BuscarJugador (string nombre)
        {
            for (int a = 0; a < _equiposFutbol.Count; a++)
            {
                if (_equiposFutbol[a].Nombre == nombre)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

