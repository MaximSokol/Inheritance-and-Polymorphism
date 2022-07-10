using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("The Document was opened");
        }

        public virtual void EditDocument()
        {
            Console.WriteLine("The possibility of editing the " +
                "document is possible in a ProDocument version!");
        }

        public virtual void SaveDocument()
        {
            Console.WriteLine("The saving a document is available" +
                " in a ProDocument version!");
        }
    }
}
