// See https://aka.ms/new-console-template for more information
using DotNetAutomationBinding;

Console.WriteLine("Hello, World!");
namespace DotNetAutomationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World from DotNetAutomationConsoleApp!");

            Session theSession = Session.GetSession;

            Part thePart = theSession.MakePart("SomePart.prt");

            Session theSession = Session.GetSession;

            Part thePart = theSession.MakePart("SomePart.prt");

            thePart.Save();
            thePart.Save();
            Console.WriteLine("Part saved");
        }
    }
}
