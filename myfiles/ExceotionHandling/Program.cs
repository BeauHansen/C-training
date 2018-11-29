using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // excpetions are runtime errors that we can potentially handle
            // excpetions are objects and defined by classes like anything else.
            
            try
            {
                // try goes around code that is expected i.e. the 
                // code that we are going to try to handle
            var x = 4;
            var y = x / 0;
            }
            catch (DivideByZeroException e)
            {
                // handle the excpetion in catch block
                Console.WriteLine("Divide by Zero. Moving on.");
                // at the end of catch, we move on with our business
            }
            BadCode();


            Console.WriteLine("The program continues");
        }
        static void BadCode()
        {
            object o = true;
            string s = (string)o;
        }
    }
}
