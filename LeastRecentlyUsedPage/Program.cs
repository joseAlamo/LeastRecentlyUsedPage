using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeastRecentlyUsedPage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix;
            Console.Write("Type desired matrix size: ");
            int size = int.Parse(Console.ReadLine());
            matrix = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[size-1, size-1] = 0;
                    Console.Write("{0} ", 0);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Shall we begin?");
            string more;
            do
            {
                Console.Write("Please indicate the page you would like to use: ({0}-{1}): ", 0, size);
                int selection = int.Parse(Console.ReadLine());
                for (int j = 0; j < size; j++)
                    matrix[selection, j] = 1;
                for (int i = 0; i < size; i++)
                    matrix[i, selection] = 0;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("{0}", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.Write("Continue?(y/n): ");
                more = Console.ReadLine();
            } while (more == "y");
        }
    }
}
