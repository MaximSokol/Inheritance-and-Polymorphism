using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class Ship : Vehicle
    {
        int amoungOfOccupants;
        string theStationOfRegistration;
        //---------------------------------

        public Ship(double cost, int speed, DateTime date,
           int amoungOfOccupants, string theStationOfRegistration) : base(cost, speed, date)
        {
            this.amoungOfOccupants = amoungOfOccupants;
            this.theStationOfRegistration = theStationOfRegistration;
        }
        //------------------------------------------------------------
        public override void PrintDate()
        {
            Console.WriteLine($"Cost:\t{cost}\n" +
                $"Speed:\t{speed}\n" +
                $"DateOfGraduate:\t{date}\n" +
                $"Amoung of occupants:\t{amoungOfOccupants}\n" +
                $"StationOfRegistration:\t{theStationOfRegistration}\n");
        }
        //------------------------------------

    }
}
