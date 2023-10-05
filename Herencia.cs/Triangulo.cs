using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.cs
{
    class Triangulo : Figura
    {
        private int _ladoA;
        private int _ladoB;
        private int _ladoC;

        public Triangulo()
        {
            Color = "verde";
        }

        public int LadoA
        {
            get { return _ladoA; }
            set { _ladoA = value; }
        }


        public int LadoB
        {
            get { return _ladoB; }
            set { _ladoB = value; }
        }


        public int LadoC
        {
            get { return _ladoC; }
            set { _ladoC = value; }
        }

        public override int CantLados
        {
            get { return 3; }
        }

        public override int Pm 
        {
            get { return LadoA + LadoB + LadoC; }
        }

        public override void Info()
        {
            Console.WriteLine($"Lado a: {LadoA} + lado b: {LadoB} + lado c: {LadoC} + perimetro: {Pm} + color: {Color} + cantidad de lados: {CantLados}");
        }


    }
}
