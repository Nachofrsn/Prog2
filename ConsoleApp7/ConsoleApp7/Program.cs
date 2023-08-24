using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream archivo;
            StreamWriter grabador;
            StreamReader lector;

            Console.WriteLine("ingrese una opcion");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:

                    archivo = new FileStream("IngresoUsuario.csv", FileMode.Append);
                    grabador = new StreamWriter(archivo);

                    Entradas(out int edad, out string nombre, out string apellido, out string direccion, out DateTime fecha, out int sueldo);

                    string ingreso = $"{edad};{nombre};{apellido};{direccion};{fecha};{sueldo}";
                    grabador.WriteLine(ingreso);
                    grabador.Close();
                    archivo.Close();
                    break;
                case 2:
                    archivo = new FileStream("IngresoUsuario.csv", FileMode.Open);
                    lector = new StreamReader(archivo);

                    while (lector.EndOfStream == false)
                    {
                        //LEER RENGLON POR RENGLON
                        string renglon = lector.ReadLine();
                        //SEPARAR VALORES DENTRO DEL RENGLON
                        string[] vector = renglon.Split(';');
                        //FORMATEAR EL RENGLON
                        string RenglonFormateado = "";
                        foreach(string s in vector)
                        {
                            RenglonFormateado += $"{s.PadLeft(10)}|";
                        }
                        //IMPRIMIR EL RENGLON
                        Console.WriteLine(RenglonFormateado);
                    }
                    break;
            }          
            Console.ReadKey();
        }
        static void Entradas(out int edad, out string nombre, out string apellido, out string direccion, out DateTime fecha, out int sueldo)
        {
            Console.WriteLine("Ingrese edad");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese direccion");
            direccion = Console.ReadLine();

            Console.WriteLine("Ingrese fecha");
            fecha = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sueldo");
            sueldo = int.Parse(Console.ReadLine());
        }
    }
}
