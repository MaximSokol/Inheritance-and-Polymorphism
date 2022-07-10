using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class DerrivedClass : Printer
    {

        public DerrivedClass()
        {
            string str = "Hello World!";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(str);
        }

        public override void OverrideMethod(string str)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(str);
        }
        //---------------------------------------------------
    }
}
