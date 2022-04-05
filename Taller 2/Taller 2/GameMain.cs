using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_2
{
    class GameMain
    {
        static void Main(string[] args)
        {
            Character p1, p2;
            Console.WriteLine("Hello Word");
            p1 = new Character();
            p1.ApplyValues();
            p2 = new Character();
            p2.ApplyValues();

            Console.WriteLine(p2.name);
        }       
    }
}
