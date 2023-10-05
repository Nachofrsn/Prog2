using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia.cs
{
    abstract class Figura
    {
        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public abstract int CantLados
        {
            get;
        }

        public abstract int Pm
        {
            get;
        }

        public abstract void Info();
    }
}
