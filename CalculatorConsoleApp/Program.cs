using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Aplikasi Kakulator Konsol";

            //casting value a and b
            Console.Write("Inputkan Nilai A: ");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Inputkan Nilai B : ");
            int b= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); //add blank space

            Console.WriteLine("Hasil Tambah {0} dan {1} = {2}", a,b,Tambah(a, b ));
            Console.WriteLine("Hasil Kurang {0} dan {1} = {2}",a, b, Kurang(a, b));
            Console.WriteLine("Hasil Kali {0} dan {1} = {2}",a, b, Kali(a, b));
            Console.WriteLine("Hasil Bagi {0} dan {1} = {2}",a, b, Bagi(a, b));

            Console.ReadKey();//waiting for user button interaction
        }

        //adding function

        static int Tambah(int a, int b)
        {
            return a + b;
        }
        static int Kurang(int a, int b)
        {
            return a - b;
        }
        static int Kali(int a, int b)
        {
            return a * b;
        }
        static int Bagi(int a, int b)
        {
            return a / b;
        }
    }
}
