using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* TestHello
namespace Learning1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            Console.ReadKey();
        }
    }
}
*/
 


namespace YichangLearning
{
    class TestYichang
    {
        public int result;
        public TestYichang()
        {
            result = 0;
        }

        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(string[] args)
        {
            TestYichang app = new TestYichang();
            app.division(25, 0);
            Console.ReadLine();
        }
    }
}