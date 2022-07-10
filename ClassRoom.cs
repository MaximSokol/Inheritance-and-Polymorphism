using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class ClassRoom
    {
        Random rand = new Random();
        Pupil[] arr = new Pupil[4];
        //---------------------------

        public ClassRoom(Pupil p1, Pupil p2)
        {
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = RandMethod();
            arr[3] = RandMethod();
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3)
        {
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = p3;
            arr[3] = RandMethod();
        }

        public ClassRoom(Pupil p1, Pupil p2, Pupil p3, Pupil p4)
        {
            arr[0] = p1;
            arr[1] = p2;
            arr[2] = p3;
            arr[3] = p4;
        }
        //----------------------------------------------------------

        public Pupil RandMethod()
        {
            int num = rand.Next(1, 4);

            switch (num)
            {
                case 1: return new ExcellentPupil();
                case 2: return new GoodPupil();
                case 3: return new BadPupil();
            }
            return new BadPupil();
        } 
        //-------------------------------------------------

        public void Study()
        {
            foreach(Pupil p in arr)
            {
                p.Study();
            }
        }

        public void Read()
        {
            foreach(Pupil p in arr)
            {
                p.Read();
            }
        }

        public void Write()
        {
            foreach(Pupil p in arr)
            {
                p.Write();
            }
        }

        public void Relax()
        {
            foreach (Pupil p in arr)
            {
                p.Relax();
            }
         }
    }
}
