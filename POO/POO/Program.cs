using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Persona A;
            A = new Persona();
            A.Nombre = "Pepe";
            A.Apellido = "Gomez";
            A.Apellido = " ";
            Console.WriteLine(A.Apelnom);

            Politica B;
            B = new Politica();
            B.elecciones = "Aaafueraaa";
            B.Casta = "casta";
            Console.WriteLine(B.Afueraa);
            

            Persona A, B;
            A = new Persona();
            B = new Persona("Rosas", "Andrea");

            Console.WriteLine(A.Apelnom);
            A.Apellido = "gomez";
            A.Nombre = "lucas";
            Console.WriteLine(A.Apelnom);
            Console.WriteLine(B.Apelnom);
            
            
            ClaseCaja cajita;
            cajita = new ClaseCaja();
            cajita.AltoCM = 10;
            cajita.AnchoCM = 10;
            cajita.Material = "carton";
            cajita.PesoKG = 20;
            cajita.CodigoInterno = "0bjklm";
            cajita.Contenido = "un lapiz";
            cajita.LargoCM = 10;
            Console.WriteLine(cajita.VolumenCM3);

            List<ClaseCaja> deposito;
            deposito = new List<ClaseCaja>();
            ClaseCaja A = new ClaseCaja(10,20,"lapicera","Caja1");
            ClaseCaja B = new ClaseCaja(20,10,"fibron","Caja2");
            ClaseCaja C = new ClaseCaja(30,40,"lapiz","Caja3");
            ClaseCaja D = new ClaseCaja(5,10,"goma","Caja4");
            deposito.Add(A);
            deposito.Add(B);
            deposito.Add(C);
            deposito.Add(D);
            float peso = 0;
            string cajapesada = "";
            /*
            for (int i = 0; i < deposito.Count(); i++)
            {
                Console.WriteLine($"{deposito[i].AltoCM}-{deposito[i].PesoKG}-{deposito[i].Contenido}-{deposito[i].CodigoInterno}");
            }
            
            foreach(ClaseCaja aux in deposito)
            {
                Console.WriteLine($"{aux.AltoCM}-{aux.PesoKG}-{aux.Contenido}-{aux.CodigoInterno}");
                if (aux.PesoKG > peso)
                {
                    peso = aux.PesoKG;
                    cajapesada = aux.CodigoInterno;
                } 
            }
            Console.WriteLine($"{cajapesada}");
            */

            /*
            ClaseCaja aux = new ClaseCaja();
            ClaseCamion camion = new ClaseCamion("A-101","Garcia", 20);
            ClaseCaja A = new ClaseCaja("102", "manzanas", 10, 20, 5, 10, "madera");
            if (camion.AgregarCaja(A) == true)
            {
                Console.WriteLine("caja agregada con exito");
            }
            else
            {
                Console.WriteLine("caja excede peso disponible");
            }

            ClaseCaja B = new ClaseCaja("101", "manzanas", 10, 20, 5, 10, "madera");
            if (camion.AgregarCaja(A) == true)
            {
                Console.WriteLine("caja agregada con exito");
            }
            else
            {
                Console.WriteLine("caja excede peso disponible");
            }

            camion.RecuperarDatosCaja(1, out aux);
            Console.WriteLine(aux.CodigoInterno);
            */

            ClaseAutos Ferrari = new ClaseAutos();
            Ferrari.Motor = "V8";
            Ferrari.Patente = "00058";
            Console.WriteLine(Ferrari.Auto);

            ClaseFutbol A = new ClaseFutbol(20, "Boca");
            ClaseFutbol B = new ClaseFutbol(21, "River");
            ClaseFutbol C = new ClaseFutbol(20, "Racing");
            ClaseFutbol D = new ClaseFutbol(22, "Independiente");

            List<ClaseFutbol> claseFutbol = new List<ClaseFutbol>();
            claseFutbol.Add(A);
            claseFutbol.Add(B);
            claseFutbol.Add(C);
            claseFutbol.Add(D);
            for (int a = 0; a < claseFutbol.Count; a++)
            {
                Console.WriteLine(claseFutbol[a].Jugadores + " " + claseFutbol[a].Nombre);
            }
            if (A.AgregarCapitan("Boca", "Tevez"))
            {
                Console.WriteLine(A.Capitan);
            }
            Console.ReadKey();
        }
    }
}
