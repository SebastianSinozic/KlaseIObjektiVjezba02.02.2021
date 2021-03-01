using System;
using System.Collections.Generic;
using System.Text;

namespace sinozicSebastianGeometrija
{
    class GeometrijskiLik
    {
        public int BrojStranica;
        public double[] Stranice = new double[10];
        public void UcitajStranice()
        {
            Console.WriteLine("Upišite veličinu stranica u centimetrima: ");
            for (int i = 0; i < BrojStranica; i++)
            {
                Stranice[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public double Opseg()
        {
            double opseg = 0;
            for (int i = 0; i < BrojStranica; i++)
            {
                opseg = opseg + Stranice[1];
            }
            return opseg;
        }
    }
}
