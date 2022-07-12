using ParcialPOO2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO2.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(3,4,5);
            if (t.Validar())
            {
                Console.WriteLine(t.MostrarTipoTriangulo());
                Console.WriteLine(t.GetArea());
                Console.WriteLine(t.GetPerimetro());

            }
            else
            {
                Console.WriteLine("Triangulo no valido");
            }

            Console.ReadLine();
        }
    }
}
