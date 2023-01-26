using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_26._01._2023
{
    class ProDocumentProgram : DocumentProgram
    {
        public override void EditDocument()
        {
            Console.WriteLine("DocumentEdited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
