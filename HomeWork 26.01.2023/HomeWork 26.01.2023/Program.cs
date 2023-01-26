 using System;

namespace HomeWork_26._01._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            check: Console.WriteLine("Enter Level");
            var user = Console.ReadLine();

            if (user == "basic")
            {
                var basic = new DocumentProgram();
                basic.level = "Basic";
                basic.OpenDocument();
                basic.EditDocument();
                basic.SaveDocument();
            }
            else if (user == "Pro")
            {
                var pro = new ProDocumentProgram();
                pro.level = "pro";
                pro.OpenDocument();
                pro.EditDocument();
                pro.SaveDocument();

            }
            else if (user == "Expert")
            {
                var expert = new ExpertDocumentProgram();
                expert.level = "expert";
                expert.OpenDocument();
                expert.EditDocument();
                expert.SaveDocument();
            }
            else
            {
                Console.WriteLine("Level not exsist");
                goto check;
            }
        }
    }
}
