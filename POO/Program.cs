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
            */

            Persona A, B;
            A = new Persona();
            B = new Persona("Rosas", "Andrea");

            Console.WriteLine(A.Apelnom);
            A.Apellido = "gomez";
            A.Nombre = "lucas";
            Console.WriteLine(A.Apelnom);
            Console.WriteLine(B.Apelnom);
            Console.ReadKey();
        }
    }
}
