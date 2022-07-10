using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_Inheritance_and_Polymorphism
{
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void OpenDocument()
        {
            base.OpenDocument();
        }

        public override void EditDocument()
        {
            base.EditDocument();
        }

        public override void SaveDocument()
        {
            Console.WriteLine("The document was saved in a new format!");
        }
    }
}
