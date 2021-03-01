using System;

namespace sinozicSebastianKlasaX
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaX a = new KlasaX();
            for (int i = 0; i < 100; i++) a.arr[i] = i;
            a.index = 50;
            Console.WriteLine(a.arr[a.index]);
            Console.ReadKey();
        }
    }
}