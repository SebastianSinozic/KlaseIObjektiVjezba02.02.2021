using System;

namespace sinozicSebastianGeometrija
{
    class Program
    {
        static void Main(string[] args)
        {
            
         Cetverokut cetverokut = new Cetverokut();
         cetverokut.UcitajStranice();
         double OpCetverokut = cetverokut.Opseg();
         Console.WriteLine("Opseg zadanog cetverokuta je: " + OpCetverokut);
        
         
         Trokut trokut = new Trokut();
         trokut.UcitajStranice();
         double OpTrokut = trokut.Opseg();
         Console.WriteLine("Opseg zadanog trokuta je: " + OpTrokut);

         Console.ReadKey();

        }
    }
}
