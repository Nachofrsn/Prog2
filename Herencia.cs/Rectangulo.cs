using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.cs
{
    class Rectangulo : Figura
    {
        private int _ladoA;
        private int _ladoB;

        public Rectangulo()
        {
            this.Color = "blanco";
            this.LadoA = 0;
            this.LadoB = 0;
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

        public override int CantLados
        {
            get { return 4; }
        }

        public override int Pm
        {
            get { return this.LadoA * 2 + this.LadoB * 2; }
        }

        public override void Info()
        {
            Console.WriteLine($"Lado a: {LadoA} + lado b: {LadoB} + perimetro: {Pm} + color: {Color} + cantidad de lados: {CantLados}");
        }
    }
}
