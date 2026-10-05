using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_hub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Tova e purvi test s GitHub");
             int name = 10;
              name = int.Parse(Console.ReadLine());*/

            Console.WriteLine(" koefic A ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(" koefic B ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(" koefic C ");
            int c = int.Parse(Console.ReadLine());

            double D = (b * b) - (4 * a * c);
            Console.WriteLine("Diskriminantata e: " + D);

            double disk = Math.Sqrt(D);

            double x1 = -b + Math.Sqrt(disk) / (2 * a);

            double x2 = -b - Math.Sqrt(disk) / (2 * a);
            Console.WriteLine("Korena na uravnenieto sa: " + x1 + " i " + x2);

        }
    }
}
