using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Study Good");
        }

        public override void Read()
        {
            Console.WriteLine("Read Good");
        }

        public override void Write()
        {
            Console.WriteLine("Write Good");
        }

        public override void Relax()
        {
            Console.WriteLine("Relax Good");
            Console.WriteLine();
        }
    }
}
