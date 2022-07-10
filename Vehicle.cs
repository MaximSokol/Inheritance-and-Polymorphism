using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class Vehicle
    {
        protected double cost;
        protected int speed;
        protected DateTime date;
        //--------------------------

        public Vehicle() { }

        public Vehicle(double cost, int speed, DateTime date)
        {
            this.cost = cost;
            this.speed = speed;
            this.date = date;
        }
        //---------------------------------------------------------

        public virtual void PrintDate() { }
    }
}
