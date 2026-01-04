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
            /*
             *For loop Execution Flow.
            1.Initialization
            2.Condition.
            3.Statements.
            4.Inc or dec.
            5.Condition
            6.Statements.
            7.Inc or dec.
            8.It will repeat until condition fails and then loop will terminate(close).

            */
            Console.WriteLine("the value of i is :" + 0);
            Console.WriteLine("the value of i is :" + 1);
            Console.WriteLine("the value of i is :" + 1);
            Console.WriteLine("the value of i is :" + 2);
            Console.WriteLine("the value of i is :" + 3);
            Console.WriteLine("the value of i is :" + 4);
            Console.WriteLine("the value of i is :" + 5);
            Console.WriteLine("the value of i is :" + 6);
            Console.WriteLine("the value of i is :" + 7);
            Console.WriteLine("the value of i is :" + 8);
            Console.WriteLine("the value of i is :" + 9);
            Console.WriteLine("the value of i is :" + 10);
            Console.WriteLine("==========================");
            // int for= 10;//don't use reversed keywords in variable creation .if you use any reserverd keyword as variablename it will throw compileerror.
            int a = 10;//don't create variable unnessary.without usage if you create variable it will impact on the perfomance.

            //for (initialization; condition; increment or decrement)
            for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("the value of i is :" + i);
                }
            Console.ReadLine();



        }
    }
}
