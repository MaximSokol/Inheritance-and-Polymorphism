using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK  1

            //string str = "Hello World!";

            //Printer prt = new Printer();
            //DerrivedClass der = new DerrivedClass();

            //prt.OverrideMethod(str);

            //prt = der;
            //prt.OverrideMethod(str);


            // TASK 2

            //ClassRoom cRoom = new ClassRoom(new ExcellentPupil(), new GoodPupil());

            //cRoom.Study();
            //cRoom.Read();
            //cRoom.Write();
            //cRoom.Relax();


            // TASK 3

            //Ship ship = new Ship(1200, 120, new DateTime(2000,07,07), 245, "Minsk");
            //Car car = new Car(1400, 240, new DateTime(1997,12,14), "Purpure Black", 320);
            //Plane plane = new Plane(27000, 450, new DateTime(2019,07,17), 14, 320);

            //Vehicle vehicle = ship;
            //vehicle.PrintDate();

            //vehicle = car as Vehicle;
            //vehicle.PrintDate();

            //vehicle = plane as Vehicle;
            //vehicle.PrintDate();


            // TASK 4

            DocumentWorker dWorker = new DocumentWorker();
            string str = " ";

            do
            {
                Console.WriteLine("Enter version of a FileExplorer ->\t");
                str = Console.ReadLine();

                try
                {
                    if (str == "pro")
                    {
                        dWorker = new ProDocumentWorker();

                        dWorker.OpenDocument();
                        dWorker.EditDocument();
                        dWorker.SaveDocument();
                    }
                    else if (str == "exp")
                    {
                        dWorker = new ExpertDocumentWorker();

                        dWorker.OpenDocument();
                        dWorker.EditDocument();
                        dWorker.SaveDocument();
                    }
                    else
                    {
                        dWorker.OpenDocument();
                        dWorker.EditDocument();
                        dWorker.SaveDocument();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (str == "exit");
        }
    }
}
