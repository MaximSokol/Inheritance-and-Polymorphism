using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
   public class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study Excellent");
        }

        public override void Read()
        {
            Console.WriteLine("Read Excellent");
        }

        public override void Write()
        {
            Console.WriteLine("Write Excellent");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax Excellent");
            Console.WriteLine();
        }
    }
}
