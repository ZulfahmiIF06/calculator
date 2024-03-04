using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int a = 10;
            ////int b = 6;


            Console.Write("inputkan nilai = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("inputkan nilai = ");
            int b = Convert.ToInt32((Console.ReadLine()));


            Console.WriteLine("Pilih mau mana : \n 1. Penambahan \n 2. Pengurangan \n 3. Perkalian \n 4. Pembagian");
            Console.Write("Pilihan = ");

            int chose = Convert.ToInt32(Console.ReadLine());



            switch (chose)
            {
                case 1:  Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Penambahan(a, b));
                    break;
                case 2:  Console.WriteLine("Hasil pengrurangan   {0} - {1} = {2}", a, b, Pengurangan(a, b));    
                        break;
                case 3: Console.WriteLine("Hasil perkalian  {0} * {1} = {2}", a, b, Perkalian(a, b));
                        break;
                case 4:    Console.WriteLine("hasil pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));
                        break;

                default: Console.WriteLine("pilihan anda tak tersedia");
                    break;
            }

         Console.ReadKey();


        }
        static float Penambahan(int a, int b)
        {
            return a + b;

        }
        static float Pengurangan(int a, int b)
        {
            return a - b;

        }

        static float Perkalian(int a, int b)
        {
            return a * b;

        }
        static double Pembagian(double a, double b)
        {
            return a / b ;

        }
       
    }
}


