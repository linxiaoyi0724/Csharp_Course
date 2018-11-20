#define RELEASE
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


/*  YichangLearning1
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
*/


/* //zi ding yi yi chang
namespace YichangLearning2
{
    public class TempZeroException : ApplicationException
    {
        public TempZeroException(string message): base(message)
        {

        }
    }
    public class Temperature
    {
        int temperture = 0;
        public void showTemp()
        {
            if(temperture == 0)
            {
                throw (new TempZeroException("Zero Temperture found"));
            }
            else
            {
                Console.WriteLine("Temperature: {0}", temperture);
            }
        }
    }
    class TestApp
    {
        static void Main(string[] args)
        {
            Temperature app = new Temperature();
            try
            {
                app.showTemp();
            }
            catch(TempZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadLine();
        }
    }
}
*/


/* //Te xing
using System.Diagnostics;
namespace TexingLearning
{
    class TestTexing
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class TestApp
    {
        public static void function1()
        {
            Console.WriteLine("In Function 1");
            function2();
        }
        public static void function2()
        {
            Console.WriteLine("In Function 2");
        }

        static void Main(string[] args)
        {
            TestTexing.Message("In Main function");
            function1();
            Console.ReadKey();
        }
    }
}
*/



/*  //Shu xing 
namespace ShuxingLearing
{
    class Student
    {
        private string code = "N.A";
        private string name = "Not known";
        private int age = 0;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + Code + "Name = " + Name + "Age = " + Age;
        }

    }

    class TestAPP
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "Zara";
            s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);
            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadLine();
        }    
    }
}
*/




/*  //chou xiang shu xing
namespace AnstactShuxing
{
    public abstract class person
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract int Age
        {
            get;
            set;
        }
    }

    class Student : person
    {
        private string name;
        private string code;
        private int age;

        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public override string Name
        {
            get
            {
                return name;

            }

            set
            {
                name = value;
            }
        }

        public override int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;

            }
        }

        public override string ToString()
        {
            return "Code = " + code + ",Name = " + name + ",Age = " + age;
        }

    }


    class Testapp
    {
        static void Main(string [] ages)
        {
            Student s = new Student();
            s.Code = "001";
            s.Name = "xiaoyi";
            s.Age = 23;
            Console.WriteLine("Student Info: {0}", s);

            s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadLine();
        }
    }
}
*/


/*    //delegate
delegate int NomChanger(int n);
namespace DelegateLearning
{
    class TestDelegate
    {
        static int num = 25;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNUM(int p)
        {
            num *= p;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            NomChanger nc1 = new NomChanger(AddNum);
            NomChanger nc2 = new NomChanger(MulNUM);

            nc1(10);
            Console.WriteLine("Value of Num: {0} ", getNum());
            nc2(5);
            Console.WriteLine("Value of Num: {0}", getNum());
            Console.ReadLine();
        }
    }
}
*/

/*   duo delegate
delegate int Numchanger(int n);
namespace DelegateLearning
{
    class TestDelegate {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MulNum(int p)
        {
            num *= p;
            return num;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class TestAPP
    {
        static void Main(string[] args)
        {
            Numchanger nc;
            Numchanger nc1 = new Numchanger(TestDelegate.AddNum);
            Numchanger nc2 = new Numchanger(TestDelegate.MulNum);
            nc = nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine("Value of Num: {0}", TestDelegate.getNum());
            Console.ReadKey();
        }
    } 
}
*/

/*  // Learning event
namespace EventLearning
{
    class TestEvent
    {
        private int value;
        public delegate void NumMain();
        public event NumMain ChangeNum;

        protected virtual void OnNumChanged()
        {
            if (ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("event is not fire");
                Console.ReadKey();
            }
        }

        public TestEvent()
        {
            int n = 5;
            SetValue(n);
        }
        public void SetValue(int n )
        {
            if(value != n)
            {
                value = n;
                OnNumChanged();
            }

        }

        public class subscribEvent
        {
            public void pritf()
            {
                Console.WriteLine("event fire");
                Console.ReadKey();
            }
        }
    }

    class TestApp
    {
        static void Main()
        {
            TestEvent e = new TestEvent();
            TestEvent.subscribEvent v = new TestEvent.subscribEvent();
            e.ChangeNum += new TestEvent.NumMain(v.pritf);
            e.SetValue(6);
            e.SetValue(11);
        }
    }
}
*/

using System.IO;
namespace EventLearning
{
    class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int t, int p)
        {
            temp = t;
            pressure = p;
        }
        public int getTemp()
        {
            return temp;
        }
        public int getPressure()
        {
            return pressure;
        }
    }

    class DelegateBoilerEvent
    {
        public delegate void BoilerLogHandler(string status);
        public event BoilerLogHandler BoilerEventLog;
        public void LogProcess()
        {
            string remarks = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if(t > 150 || t < 80 || p <12 || p> 15)
            {
                remarks = "Need Maintenance";

            }
            onBolierEventLog("Logging Info :\n");
            onBolierEventLog("Temparature " + t + "\nPressure: " + p);
            onBolierEventLog("\nMessage: " + remarks);
            
        }

        protected void onBolierEventLog(string message)
        {
            if (BoilerEventLog != null)
            {
                BoilerEventLog(message);
            }
        }


        class BoilerInfoLogger
        {
            FileStream fs;
            StreamWriter sw;
            public BoilerInfoLogger(string filename)
            {
                fs = new FileStream(filename, FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
            }

            public void Logger(string info)
            {
                sw.WriteLine(info);
            }

            public void Close()
            {
                sw.Close();
                fs.Close();
            }

        }


        public class RecordBoilerInfo
        {
            static void Logger(string info)
            {
                Console.WriteLine(info);
            }

            static void Main(string[] args)
            {
                BoilerInfoLogger filelog = new BoilerInfoLogger("D:\\boiler.txt");
               
            }
        }

    }
}

