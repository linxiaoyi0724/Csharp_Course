#define RELEASE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* // TestHello
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



/*  //FileStream Learning
using System.IO;
namespace FilestreamLearning {
    class TestFilestream
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("sample.txt", FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite);
            for(int i = 1; i<=20; i++)
            {
                f.WriteByte((Byte)i);
            }
            f.Position = 8;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(f.ReadByte() + " ");
            }
            f.Close();
            Console.ReadKey();
        }
    }
}
*/


/*  //Learning StreamReader 
using System.IO;
namespace StreamReaderLearning
{
    class TestStreamReader {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader("D:/test_txt/xiaoyi.txt"))
                {
                    string TxtLine;
                    while((TxtLine = sr.ReadLine())!= null)
                    {
                        Console.WriteLine(TxtLine);
                    }
                }

            }
            catch(Exception e)
            {
                Console.WriteLine("The file is not read");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }

    }
}
*/


/*  //Learning Text StreamWrite
using System.IO;
namespace StreamWriteLearning
{
    class TestStreamrite
    {
        static void Main(string[] args)
        {
            string[] NameList = new string[] { "xiaoyi","meizhem"};
            using (StreamWriter s = new StreamWriter("D:/vs2015_code/CsharpLearning/XiaoyiWrite.txt"))
            {
                foreach(string name in NameList)
                {
                    s.WriteLine(name);
                }
            }
            using (StreamReader sr = new StreamReader("D:/vs2015_code/CsharpLearning/XiaoyiWrite.txt"))
            {
                string name;
                while((name = sr.ReadLine())!= null){
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();
        }
    }
}
*/


/*   // Learn BinaryWrite and BinaryRead
using System.IO;
namespace LearningBinary
{
    class TestBinary
    {
        static void Main(string[] args)
        {
            int a = 25;
            double b = 3.14157;
            bool c = true;
            string d = "I am happy";
            BinaryWriter bw;
            BinaryReader br;
            try
            {
                bw = new BinaryWriter(new FileStream("D:/vs2015_code/CsharpLearning/TestBinary.txt", FileMode.Create));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "can not creat file");
                return;
            }


            try
            {
                bw.Write(a);
                bw.Write(b);
                bw.Write(c);
                bw.Write(d);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "can not write in file");
                return;
            }
            bw.Close();

            try
            {
                br = new BinaryReader (new FileStream("D:/vs2015_code/CsharpLearning/TestBinary.txt", FileMode.Open));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "can not open file");
                return;
            }

            try
            {
                a = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", a);
                b = br.ReadDouble();
                Console.WriteLine("Double data: {0}", b);
                c = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", c);
                d = br.ReadString();
                Console.WriteLine("String data: {0}", d);
                
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + "can not read from file");
                return;
            }
            br.Close();
            Console.ReadKey();
        }
    }
}
*/

/* //Learning DirectoryInfo anad FileInfo
using System.IO;
namespace LearningDirectory
{
    class TestApp
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo("C:/Windows");
            FileInfo[] f = d.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("file name: {0} Size: {1}", file.Name, file.Length);
            }
            Console.ReadKey();


        }
    }
}
*/














