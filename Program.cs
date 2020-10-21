using School;
using System;
using System.Linq;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Function: XXX 
             * Input : x,y,z
             * Output: console: hello */

            Console.WriteLine("Hello , C#!");

            int i = 10;
            int a = i++;
            i = 10;
            int b = ++i;

            i += 5;
            i /= 4;
            i = (int)2.7;

            int[] arr = new int[3];
            arr.Contains(i);

            if ( i > 4 || i < 10 )
            {

            }

            int x = 20;
            int y = 18;

            bool greater = x > y; 
            if ( x > y)
            {
                Console.WriteLine("x is greater than y ");
            }
            else
            {
                Console.WriteLine("y is greater x ");

            }

            // School.ClassA.say();





            Console.ReadKey();
        }
    }
}


namespace School

{
    class ClassA
    {
        public static void  say()  // static 静态方法只能通过类调用
        {
            Console.WriteLine("I'm in ClassA");
        }

    }
}