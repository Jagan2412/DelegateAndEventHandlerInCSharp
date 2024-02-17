using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegates_EvenHandler.Program;

namespace Delegates_EventHandler
{
    internal class Calculators
    {
        public event MyDelegateCalculator MyEventCalculator;

        public void Addition(int a, int b)
        {
            int add = a + b;
            if(MyEventCalculator != null)
            {
                MyEventCalculator(add);
            }
        }

        public void Subtraction(int a, int b)
        {
            int sub = a - b;
            if (MyEventCalculator != null)
            {
                MyEventCalculator(sub);
            }
        }

        public void Multiplication(int a, int b)
        {
            int multiply = a * b;
            if (MyEventCalculator != null)
            {
                MyEventCalculator(multiply);
            }
        }
    }
}
