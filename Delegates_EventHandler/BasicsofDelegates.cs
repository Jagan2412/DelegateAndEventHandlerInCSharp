using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_EventHandler
{
    internal class BasicsofDelegates
    {
        public delegate void MyPrintDelegate(string message);
        public delegate void MyPrintNumber(int a, int b);

        //static void Main(string[] args)
        //{
        //    MyPrintDelegate myPrint = new MyPrintDelegate(PrintMessage);
        //    myPrint += PrintSplitMessage;

        //    MyPrintNumber mynumberPrint = new MyPrintNumber(PrintNumber);
        //    mynumberPrint(2, 3);

        //    myPrint("Hello World to My Delegate");
        //}

        public static void PrintNumber(int a, int b)
        {
            Console.WriteLine(a + ", " + b);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static void PrintSplitMessage(string message)
        {
            string[] splitMessage = message.Split(' ');
            Console.WriteLine(splitMessage[1]);
        }

        public static void PrintSliceMessage(string message)
        {
            string[] splitMessage = message.Split(' ');
            Console.WriteLine(splitMessage[2]);
        }
    }
}
