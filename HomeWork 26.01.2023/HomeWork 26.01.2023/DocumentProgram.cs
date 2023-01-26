using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_26._01._2023
{
    class DocumentProgram
    {
        public string level = "";

        public void OpenDocument()
        {
            Console.WriteLine("Document Opened");
        }


        public virtual void EditDocument()
        {
            Console.WriteLine("Can Edit in Pro and Expert versions");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Can Save in Pro and Expert versions");
        }
    }

    //public  static void OpenDocument()
    //{
    //    Console.WriteLine("Document Opened");
    //}
    //public  static void EditDocument()
    //{
    //    Console.WriteLine("Can Edit in Pro and Expert versions");
    //}
    //public  static void SaveDocument()
    //{
    //    Console.WriteLine("Can Save in Pro and Expert versions");
    //}


}
