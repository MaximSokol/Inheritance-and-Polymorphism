using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class ProDocumentWorker : DocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            Console.WriteLine("The document was edited!");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The saving a document is " +
                "available in a ExpertDocument version!");
        }
    }
}
