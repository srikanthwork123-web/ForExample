using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             For Loop
For loop includes all three characteristics as initialization, condition and increment/decrement in a single line.

==========================================================
         for loop   Syntax:-
  =================
for (initialization; condition; increment or decrement)
{
Statements;
}
==============================================================

  while loopSyntax: -
 ===================
Initialization;
While (condition)
{
Statements;
Increment /decrement;
}


===============================================================
            */






            //for (initialization; condition; increment or decrement)
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("the value of i is :" + i);
            }
            Console.ReadLine();



        }
    }
}
