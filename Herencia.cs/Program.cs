using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rec = new Rectangulo();
            rec.Color = "azul";
            rec.LadoA = 10;
            rec.LadoB = 5;
            Console.WriteLine(rec.Color);
            Console.WriteLine(rec.Pm);

            Triangulo Escaleno = new Triangulo();
            Escaleno.Color = "celeste";
            Escaleno.LadoA = 5;
            Escaleno.LadoB = 7;
            Escaleno.LadoC = 9;
            Console.WriteLine(Escaleno.Pm);
            Escaleno.Info();
            rec.Info();

            rec.Listar(); //PROPIEDAD VIRTUAL
            Console.ReadKey();
        }
    }
}
