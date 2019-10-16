using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
        int students;

        students = Convert.ToInt32(Console.ReadLine());

         //declaring variables
         int[] grades = new int[students];
         string[] names = new string[students];
             
        for(int x = 0; x < students; x++)
            {
                Console.WriteLine("Please enter Name {0}", x);
                names[x] = Console.ReadLine();
            }
        }
    }
}
