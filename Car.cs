using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class Car : Vehicle
    {
        string color;
        int maxSpeed;
        //--------------

        public Car (double cost, int speed, DateTime date,
           string color, int maxSpeed) : base(cost, speed, date)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        //------------------------------------------------------------

        public override void PrintDate()
        {
            Console.WriteLine($"Cost:\t{cost}\n" +
                $"Speed:\t{speed}\n" +
                $"DateOfGraduate:\t{date}\n" +
                $"Color:\t{color}\n" +
                $"Maximal Speed:\t{maxSpeed}\n");
        }
        //------------------------------------
    }
}
