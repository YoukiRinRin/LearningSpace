using System;
using System.Drawing;
using System.Windows.Forms;

namespace 練習コンソール
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int val_1 = 20;

            if(val_1 == 10)
            {
                System.Console.WriteLine("10です");
            }
            else if(val_1 == 20)
            {
                System.Console.WriteLine("20です");
            }
            else
            {
                System.Console.WriteLine("それ以外です");
            }
            int i;
            Console.Write("Enter a Number");
            i = int.Parse(Console.ReadLine());
            if(i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an odd Number");
                Console.Read();
            }
            int number;
            Console.Write("Enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("You Enterd :{0}", number);

             

            Console.Read();
        }
    }
}
