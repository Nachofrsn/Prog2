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
        {
            Persona A;
            A = new Persona();
            A.Nombre = "Pepe";
            A.Apellido = "Gomez";
            A.Apellido = " ";
            Console.WriteLine(A.Apellido);
            Console.ReadKey();
        }
    }
}
