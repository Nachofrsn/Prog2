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
            */

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
            */
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
            Console.ReadKey();
        }
    }
}
