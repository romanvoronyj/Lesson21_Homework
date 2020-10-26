using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson21_Homework_Task1
{
    /*Використовуючи Visual Studio 2010 створіть проект за шаблоном Console Application.
      Напишіть програму, в якій метод буде викликатися рекурсивно. Кожен новий виклик методу виконується в окремому потоці.
    */
   class Program
    {
        static void Recursion(object num)
        {
            int n = (int)num;
            if (n <= 0)
                return;
            Thread t = new Thread(Recursion);
            t.Name = "Thread" + n;
            t.Start(n - 1);
            Console.WriteLine(t.Name);
        }

        static void Main(string[] args)
        {
            Recursion(10);

            Console.ReadKey();
        }
    }
}
