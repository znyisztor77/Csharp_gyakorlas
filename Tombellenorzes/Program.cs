using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombellenorzes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int keres = tomb[0];
            bool logic = false;
            int i;
            int j = 0;
            for (i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }

            while( j<tomb.Length-1 && !logic)
            {
                j++;
                if(keres == tomb[j])
                {
                    logic = true;   
                }
                else
                {
                   keres = tomb[j];
                }
            }
            if (logic)
            {
                Console.WriteLine("Van egyezés!");
            }
            else
            { 
                Console.WriteLine("Nincs egyezés!");
            }

            Console.ReadKey();
        }
    }
}
