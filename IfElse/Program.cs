using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütden bir sayi giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if(number == 10)
            {
                Console.WriteLine("Girilen sayi 10'a eşittir.");
            }
            else if(number > 10)
            {
                Console.WriteLine("Girilen sayi 10 'dan büyüktür.");
            }
            else
            {
               Console.WriteLine("Girilen sayi 10'dan küçüktür.");
            
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Girilen sayi çifttir");
            }
            else
            {
               Console.WriteLine("Girilen sayi tektir");
            }

        }
    }
}
