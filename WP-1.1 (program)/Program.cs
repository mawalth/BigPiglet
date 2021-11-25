using System;

namespace WP_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 5; 
            b = 2; // Входные данные (1 точка)

            Console.Write("Входные данные: ");
            Console.Write("A = 0, B= 0"); // Пользовательский интерфейс
            Console.WriteLine();
            
            c = (a + 2 * b) * (a - 2 * b); // Выходные данные (2 точка)
            Console.Write("Выходные данные: " + c); 
            Console.ReadKey();
        }
    }
}
