
using Delegates_EventHandler;

namespace Delegates_EvenHandler
{
    public class Program
    {
        public delegate void MyDelegateCalculator(int data);
        static void Main(string[] args)
        {

            Calculators calculators = new Calculators();

            MyEventSubscriber myEventSubscriber = new MyEventSubscriber();

            calculators.MyEventCalculator += myEventSubscriber.DisplayData;

            //string myInput = Console.ReadLine();

            calculators.Addition(5, 4);
            calculators.Subtraction(5, 4);
            calculators.Multiplication(5, 4);

            //switch (myInput)
            //{

            //    case ("Add"):
            //        myOutput = calculators.Addition(5, 4);
            //        break;
            //    case ("Sub"):
            //        myOutput = calculators.Subtraction(5, 4);
            //        break;
            //    case ("Multiple"):
            //        myOutput = calculators.Multiplication(5, 4);
            //        break;
            //    default:
            //        break;
            //}


        }

    }
}