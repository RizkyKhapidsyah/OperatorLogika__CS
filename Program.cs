using System;

namespace OperatorLogika__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            int Umur = 25;
            double Uang = 900;
            bool Kawin = false;

            if (!(Umur > 25) || (Uang > 1000) && !Kawin) 
            {
                Console.WriteLine("Sukses");
            }
            else
            {
                Console.WriteLine("Gagal");
            }

            Console.ReadLine();
        }
    }
}
