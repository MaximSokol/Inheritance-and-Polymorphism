using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class Plane : Vehicle
    {
        double hight;
        int amoungtOfOccupants;
        //------------------------

       public Plane(double cost, int speed, DateTime date, double hight, 
            int amoungtOfOccupants) : base(cost, speed, date)
        {
            this.hight = hight;
            this.amoungtOfOccupants = amoungtOfOccupants;
        }
        //------------------------------------------------------------

        public override void PrintDate()
        {
            Console.WriteLine($"Cost:\t{cost}\n" +
                $"Speed:\t{speed}\n" +
                $"DateOfGraduate:\t{date}\n" +
                $"Hight:\t{hight}\n" +
                $"AmoungOfOccupants:\t{amoungtOfOccupants}\n");
        }
        //------------------------------------
    }
}
