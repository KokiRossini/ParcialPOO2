using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPOO2.Entidades
{
    public class Triangulo
    {
        private int LadoA, LadoB, LadoC;

        public Triangulo(int ladoA, int ladoB, int ladoC)
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }
        public Triangulo()
        {
            LadoA = 1;
            LadoB = 1;
            LadoC = 1;
        }

        public int MostrarLadoA()
        {
            return LadoA;
        }
        public int MostrarLadoB()
        {
            return LadoB;
        }

        public int MostrarLadoC()
        {
            return LadoC;
        }

        public bool Validar()
        {
            bool esValido = true;
            if (LadoA+LadoB>LadoC && LadoA+LadoC>LadoB && LadoB+LadoC>LadoA)
            {
                esValido = true;
            }
            else
            {
                esValido = false;
            }
            return esValido;
        }

        public string MostrarTipoTriangulo()
        {
            string TipoTriangulo=null;
            if (Math.Pow(LadoA,2)== Math.Pow(LadoB, 2)+ Math.Pow(LadoC, 2))
            {
                TipoTriangulo = "Triangulo rectangulo";
            }
            else if (Math.Pow(LadoA, 2) > Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2))
            {
                TipoTriangulo = "Triangulo obtusano";
            }
            else if (Math.Pow(LadoA, 2) < Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2))
            {
                TipoTriangulo = "Triangulo acutangulo";
            }
            return TipoTriangulo;
        }

        public double GetArea()
        {
            double p = 0;
            p = (LadoA + LadoB + LadoC) / 2;
            double Area = 0;
            Area = Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC));

            return Area;
        }

        public double GetPerimetro()
        {
            double Perimetro = 0;
            Perimetro = LadoA + LadoB + LadoC;

            return Perimetro;
        }

    }
}
