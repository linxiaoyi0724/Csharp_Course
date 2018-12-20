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
                using (StreamReader sr = new StreamReader("D:/LearnCSharp/CsharpGit/Csharp_Course/xiaoyi.txt"))
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


/*    //Learning Conditional
using System.Diagnostics;
namespace LearningAttribute
{
	class MyClass
	{
		[Conditional("RELEASE")]
		public static void Message(string msg)
		{
			Console.WriteLine(msg);
		}
	}
	class TestAttribute
	{
		static void function1()
		{
			MyClass.Message("In function1");
			function2();
		}
		static void function2()
		{
			MyClass.Message("In function2");
		}
		static void Main(string[] args)
		{
			MyClass.Message("In function");
			function1();
			Console.ReadKey();
		}
	}
}
*/
/*
//difference of value type and reference type
namespace LearningListReferenceassignment
{
    class TestListReferenceAndAsignment
    {
        static List<int> BoMs = new List<int>();
        static void Main(string[] args)
        {
            for(int i = 0; i <=10; i++)
            {
                BoMs.Add(i);
            }

            List<int> a = null;
            List<int> b = null;

            a = GetNormalBoMs();
            b = GetConfigBoMs();

            a[0] = 5;
            b[1] = 9;
            for(int j =0; j < a.Count; j++)
            {
                Console.Write(a[j] + " ");
                Console.Write(b[j] + " ");
                Console.Write(BoMs[j] + " ");
                Console.WriteLine(); 
            }
            Console.ReadLine();

        }

        //direct assignment don't change the values
        static List<int> GetNormalBoMs()
        {
            List<int> boms = new List<int>();
            foreach(int m in BoMs)
            {
                boms.Add(m);
            }
            return boms;
        }

        //change memory pointer also change the original values
        static List<int> GetConfigBoMs()
        {
            List<int> boms = new List<int>();
            boms = BoMs;
            return boms;
        }
    }
}
*/



/*  //Learning Value Type And Reference Type
namespace LearningValueTypeAndReferenceType
{
    class User
    {
        public int Age;
    }
    class TestValueTypeAndReferenceType
    {
        static void Main(string[] args)
        {
            int v1 = 1;
            int v2 = v1;
            v2 = 100;
            Console.WriteLine("v1 = " + v1);
            Console.WriteLine("v2 = " + v2);

            User u1 = new User();
            u1.Age = 1;
            User u2 = u1;
            u2.Age = 100;
            Console.WriteLine("u1.Age = " + u1.Age);
            Console.WriteLine("u2.Age = " + u2.Age);
            Console.ReadKey();
        }
    }
}
*/




/*    //Learning Obselote
namespace LearningObselote
{
	class TestObselote
	{

		[Obsolete("Don't use OldMethod, use NewMethod instead", true)]
		static void OldMethod()
		{
			Console.WriteLine("this is a OldMethod");
		}
		static void NewMethod()
		{
			Console.WriteLine("this is a NewMethod");
		}
		static void Main(String[] args)
		{
			OldMethod();
			Console.ReadKey();
		}
	}
}
*/





/*
using System.Diagnostics;
using System.Reflection;
namespace LearningAttribute
{
	[AttributeUsage(AttributeTargets.Class |
		AttributeTargets.Constructor |
		AttributeTargets.Field |
		AttributeTargets.Method |
		AttributeTargets.Property,
		AllowMultiple = true)]

	public class DeBugInfo : System.Attribute
	{
		private int bugNo;
		private string developer;
		private string lastReview;
		public string message;

		public DeBugInfo(int bg, string dev, string d)
		{
			this.bugNo = bg;
			this.developer = dev;
			this.lastReview = d;
		}

		public int BugNo
		{
			get
			{
				return bugNo;
			}
		}

		public string Develop
		{
			get
			{
				return developer;
			}
		}

		public string LastReview
		{
			get
			{
				return lastReview;
			}
		}
		public string Message
		{
			get
			{
				return message;
			}
			set
			{
				message = value;
			}
		}
	}

	[DeBugInfo(45, "xiaoyi", "20181205.11", Message = "Return type mismatch")]
	[DeBugInfo(49, "xiaoyi", "20181205.12", Message = "Unused variable")]

	class Rectange
	{
		protected double length;
		protected double width;
		public Rectange(double l, double w)
		{
			length = l;
			width = w;
		}
		[DeBugInfo(55, "xiaoyi", "20181205.13", Message = "Return type mismatch")]

		public double GetArea()
		{
			return length * width;
		}
		[DeBugInfo(56, "xiaoyi", "20181205.14")]
		public void display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}

		class ExecuteRectangle
		{
			static void Main(string[] args)
		{
			Rectange r = new Rectange(4.5, 7.5);
			r.display();
			Type type = typeof(Rectange);
			foreach(Object attributes in type.GetCustomAttributes(false))
			{
				DeBugInfo dbi = (DeBugInfo)attributes;
				if (null != dbi)
				{
					Console.WriteLine("Bug no: {0}", dbi.BugNo);
					Console.WriteLine("Developer: {0}", dbi.Develop);
					Console.WriteLine("Last Reviewed: {0}", dbi.LastReview);
					Console.WriteLine("Remark: {0}", dbi.message);
				}
			}

			foreach(MethodInfo m in type.GetMethods())
			{
				foreach(Attribute a in m.GetCustomAttributes(true))
				{
					DeBugInfo dbi = (DeBugInfo)a;
					if (null != dbi)
					{
						Console.WriteLine("Bug no: {0}, for Method: {1}",
								dbi.BugNo, m.Name);
						Console.WriteLine("Developer: {0}", dbi.Develop);
						Console.WriteLine("Last Reviewed: {0}",
								dbi.LastReview);
						Console.WriteLine("Remarks: {0}", dbi.Message);
					}
				}
			}
			Console.ReadLine();
		}
	}
}
*/






/*  // Learning Reflection
[AttributeUsage(AttributeTargets.All)]
public class HelpAttribute : System.Attribute
{
	public readonly string Url;
	private string topic;
	public string Topic
	{
		get
		{
			return topic;
		}
		set
		{
			topic = value;
		}
	}
	public HelpAttribute(string url)
	{
		this.Url = url;
	}
}


[HelpAttribute("Information on the class Myclass")]
class Myclass
{

}

namespace LearningReflection
{
	class TestReflection
	{
		static void Main(string [] args)
		{
			System.Reflection.MemberInfo info = typeof(Myclass);
			object[] attributes = info.GetCustomAttributes(true);
			for(int i = 0; i < attributes.Length; i++)
			{
				System.Console.WriteLine(attributes[i]);
			}
			Console.ReadKey();
		}
	}
}
*/



/* // learning Properties
namespace LearningProperties
{
	class Stuent
	{
		private int code;
		private string name;
		private int age;

		public int Code
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


		public int  Age
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
			return "Code = " + code + ", Name = " + name + ", Age = " + age;
		}
	}

	class TestProperties
	{
		static void Main(string[] args)
		{
			Stuent s = new Stuent();
			s.Code = 001;
			s.Name = "xiaoyi";
			s.Age = 21;
			Console.WriteLine("Student Info: {0}", s);

			s.Age += 1;
			Console.WriteLine("Student Info: {0}", s);
			Console.ReadKey();
		}
	}
}
*/


/*  //Learning Abstract
namespace LearningAbstractProperties
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

	class student : person
	{
		private string code = "N.A";
		private string name = "N.A";
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
			return "Code : " + code + ",Name : " + name + ",Age : " + age;
		}

	}

	class TestAbstactProperties
	{
		static void Main(string[] args)
		{
			student s = new student();
			s.Code = "001";
			s.Name = "xiaoyi";
			s.Age = 22;
			Console.WriteLine("Student Info : {0}",s);
			s.Age += 1;
			Console.WriteLine("Student Info: {0}", s);
			Console.ReadLine();
		}
	}
}
*/


/*   // Learning to read and write xml type file
using System;
using System.Linq;
using System.Xml.Linq;

namespace Sample2
{
	class program
	{
		static void Main(string[] args)
		{
			
			XDocument xdoc = new XDocument();
			XElement Persons = new XElement("Persons");
			XElement Person1 = new XElement("person");
			Person1.Add(new XElement("Name", "Tom"));
			Person1.Add(new XElement("Age", "18"));
			Persons.Add(Person1);

			XElement Person2 = new XElement("person");
			Person2.Add(new XElement("Name", "jack"));
			Person2.Add(new XElement("Age", "20"));
			Persons.Add(Person2);

			xdoc.Add(Persons);
			xdoc.Save("myXml1.xml");
			Console.WriteLine("sucess to create xml file");
			
			//Console.ReadKey();

			XDocument xd = XDocument.Load("myXml1.xml");
			foreach(XElement item in xd.Root.Descendants("person"))
			{
				Console.WriteLine("Name: {0} Age: {1}", item.Element("Name").Value, item.Element("Age").Value);
			}
			Console.ReadLine();
		}
	}
}
 */



/*   //Learning xml
using System.Xml.Linq;
namespace LearningWriteListToXml
{
	class TestWriteListToXml
	{
		static void Main(string[] args)
		{
			List<int> list = new List<int>();
			for(int i = 0; i < 10 ; i++)
			{
				list.Add(i);
			}

			XDocument xdoc = new XDocument();
			XElement Dots = new XElement("Dots");
			for (int i = 0; i < 10; i++)
			{
				XElement dots = new XElement("dots");
				dots.Add(new XElement("dot", list[i]));
				Dots.Add(dots);
			}
			xdoc.Add(Dots);
			xdoc.Save("Dots.xml");
			Console.WriteLine("secess to create Dot.xml");
		//	Console.ReadKey();

			XDocument xd = XDocument.Load("Dots.xml");
			foreach( XElement item in xd.Root.Descendants("dots"))
			{
				Console.WriteLine("dots coordinate: {0}", item.Element("dot").Value);
			}
			Console.ReadLine();
		}
	}
}
*/






/* //Learning indexer
namespace LearningIndexer
{
	class TestIndexer
	{
		private static int size = 10;
		public string[] NameList = new string[size];

		public TestIndexer()
		{
			for(int i = 0; i < size; i++)
			{
				NameList[i] = "N.A";
			}
		}

		public string this[int index]
		{
			get
			{
				string tmp;
				if( index>=0 && index < size)
				{
					tmp = NameList[index];
				}
				else
				{
					tmp = "";
				}
				return tmp;
			}
			set
			{
				if (index >=0 && index < size)
				{
					NameList[index] = value;
				}
			}
		}
		public int  this[string name]
		{
			get
			{
				int index = 0;
				while(index < TestIndexer.size)
				{
					if(NameList[index] == name)
					{
						return index;
					}
					index++;
				}
				return index;
			}
		}
		static void Main(string[] args)
		{
			TestIndexer names = new TestIndexer();
			names[0] = "xiaoyi";
			names[1] = "xiaoke";
			names[2] = "xiaoyao";
			names[3] = "meizhen";
			names[4] = "qiongzi";

			for(int i = 0; i < TestIndexer.size; i++)
			{
				Console.WriteLine(names[i]);
			}

			Console.WriteLine(names["xiaoyao"]);
			Console.ReadLine();
		}
	}
}
*/






/* //Learning Indexer
namespace LearningIndexer
{
	class TestIndexer
	{
		private int size;
		private string[] NameList;
		public TestIndexer(int size)
		{
			this.size = size;
			NameList = new string[size];
			for(int i = 0; i< size; i++)
			{
				NameList[i] = "N.A";
			}
		}

		public string this[int index]
		{
			get
			{
				string tmp;
				if(index >=0 && index < size)
				{
					tmp = NameList[index];
				}
				else
				{
					tmp = "";
				}
				return tmp;
			}
			set
			{
				if(index >= 0 && index < size)
				{
					NameList[index] = value;
				}
			}
		}


		public int this[string name]
		{
			get
			{
				int index = 0;
				while(index < size)
				{
					if(NameList[index] == name)
					{
						return index;
					}
					index++;
				}
				return index;
			}
		}



		static void Main(string[] args)
		{
			TestIndexer names = new TestIndexer(10);
			names[0] = "xiaoyi";
			names[1] = "xiaoke";
			names[2] = "xiaoyao";
			names[3] = "meizhen";
			names[4] = "qiongzi";

			for(int i =0; i < names.size; i++)
			{
				Console.WriteLine(names[i]);
			}
			Console.WriteLine(names["xiaoyao"]);
			Console.ReadLine();
		}
	}
}
*/


/*  //Learning Delegate
delegate int NumberChanger(int n);
namespace LearningDelegate
{
	class TestDelegate
	{
		public static int num = 10;
		public static int AddNum(int n)
		{
			num = num + n;
			return num;
		}
		public static int MulNum(int n)
		{
			num = num * n;
			return num;
		}
		public static int  GetNum()
		{
			return num;
		}


		static void Main(string[] args)
		{
			NumberChanger n1 = new NumberChanger(AddNum);
			NumberChanger n2 = new NumberChanger(MulNum);
			n1(25);
			Console.WriteLine("Value of Num: {0}", GetNum());
			n2(5);
			Console.WriteLine("Value of Num: {0}", GetNum());
			Console.ReadLine();
		}
	}
}
*/




/*   // Learning Multicasting of a Delegate
delegate int NumberChanger(int n);
namespace LearningDelegate
{
	class TestDelegate
	{
		private static int num = 10;
		private static int AddNum(int q)
		{
			num += q;
			return num;
		}
		private static int MulNum(int q)
		{
			num *= q;
			return num;
		}
		private static int getNum()
		{
			return num;
		}

		static void Main(string[] args)
		{
			NumberChanger nc;
			NumberChanger nc1 = new NumberChanger(AddNum);
			NumberChanger nc2 = new NumberChanger(MulNum);
			nc1(5);
			nc2(5);
			nc = nc1;
			nc += nc2;
			Console.WriteLine("Value of Num is : {0}", getNum());
			Console.ReadKey();
		}
	}
}
*/




/*  //Learning Delegate
using System.IO;
namespace LearningDelegate
{
	class TestDelegate
	{
		public delegate void PrintString(string s);
		static StreamWriter sw;
		static FileStream fs;
		public static void WriteToScreen(string s)
		{
			Console.WriteLine("the string is {0}", s);
		}
		public static void WriteToFile(string s)
		{
			fs = new FileStream("D:/vs2015_code/CsharpLearning/message.txt", FileMode.Append, FileAccess.Write);
			sw = new StreamWriter(fs);
			sw.WriteLine(s);
			sw.Flush();
			sw.Close();
			fs.Close();
		}

		public static void SendString(PrintString ps)
		{
			ps("hello world");
		}

		static void Main(string[] args)
		{
			PrintString ps1 = new PrintString(WriteToScreen);
			PrintString ps2 = new PrintString(WriteToFile);
			SendString(ps1);
			SendString(ps2);
			Console.ReadLine();
		}
	}
}
*/




/*   //Learning DelegateAndEvent
namespace LearningDelegateAndEvent
{
	class car
	{
		public delegate void CarHandler(string message);
		public event CarHandler Exploded;
		public event CarHandler AboutToBelow;
		public int CurrentSpeed { get; set; }
		public int MaxSpeed { get; set; }
		public string PetName { get; set; }
		public bool CarIsDead;

		public car(int maxsed)
		{
			MaxSpeed = maxsed;
		}
		public car(string name, int cursed,int maxsed)
		{
			PetName = name;
			CurrentSpeed = cursed;
			MaxSpeed = maxsed;
		}
		public void Accelate(int delta)
		{
			CurrentSpeed += delta;
			if(CurrentSpeed > MaxSpeed)
			{
				CarIsDead = true;
			}
			else
			{
				CarIsDead = false;
			}
			if (CarIsDead)
			{
				if(Exploded != null)
				{
					Exploded("the car is dead");
				}
			}
			else
			{
				if((MaxSpeed - CurrentSpeed) > 0 && (MaxSpeed -CurrentSpeed ) < 10 && AboutToBelow != null)
				{
					AboutToBelow("carful buddy ! gonna blow ! ");
					Console.WriteLine("CurrentSpeed =  {0}", CurrentSpeed);
				}
			}
		}
	}

	class Answer
	{
		public void CarDead(string messages)
		{
			Console.WriteLine(messages);
		}
		public void NearDead(string messages)
		{
			Console.WriteLine(messages);
		}
	}

	class TestDeleagteAndEvent
	{
		static void Main(String[] args)
		{
			car c = new car("benchi", 93, 100);
			Answer a = new Answer();
			c.Exploded += new car.CarHandler(a.CarDead);
			c.AboutToBelow += new car.CarHandler(a.NearDead);
			c.Accelate(6);
			Console.ReadLine();
			c.Accelate(3);
			Console.ReadLine();
		}
	}

/*  //Learning Delegate
namespace LearningDelegate
{
    class xiaozhang
    {
        public static void BugTicket()
        {
            Console.WriteLine("NND, fuck");
        }
        public static void BugMovieTicket()
        {
            Console.WriteLine("zi ji pao niu rang wo mai piao");
        }
    }

    class xiaoming
    {
        public delegate void BugTicketEventHandler();
        static void Main(string[] args)
        {
            BugTicketEventHandler MyDelegate = new BugTicketEventHandler(xiaozhang.BugTicket);
            MyDelegate += xiaozhang.BugMovieTicket;
            MyDelegate();
            Console.ReadKey();
        }
    }
}
*/


/* //Learning Event
namespace LearningEvent
{
    class TestEvent
    {
        private int value;
        public delegate void ChangeNumHandler();
        public event ChangeNumHandler ChangeNum;
        public TestEvent()
        {
            int n = 5;
            SetValue(n);
        }
        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnChangeNum();
            }
        }
        public void OnChangeNum()
        {
            if(ChangeNum != null)
            {
                ChangeNum();
            }
            else
            {
                Console.WriteLine("event not fire");
                Console.ReadKey();
            }
        }
    }

    class subscirp
    {
        public void printf()
        {
            Console.WriteLine("Event fire");
            Console.ReadKey();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            TestEvent e = new TestEvent();
            subscirp s = new subscirp();
            e.ChangeNum += new TestEvent.ChangeNumHandler(s.printf);
            e.SetValue(7);
            e.SetValue(11);
        }
    }
}
*/




/* //Learning Delegate And Event
using System.IO;
namespace LearningEvent
{
    class Boiler
    {
        private int temp;
        private int pressure;
        public Boiler(int t,int p)
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
        public delegate void Loggerhandler(string s);
        public event Loggerhandler BolierLog;
        public void LogPrecess()
        {
            string remark = "O.K";
            Boiler b = new Boiler(100, 12);
            int t = b.getTemp();
            int p = b.getPressure();
            if(t>150 || t < 80 || p<12 || p > 15)
            {
                remark = "Need Maintenance";
            }
            OnBoilerLogEvent("Logging Info: \n");
            OnBoilerLogEvent("Temparature " + t + "\nPressur " + p);
            OnBoilerLogEvent("\nMessage: " + remark);
        }
        protected void OnBoilerLogEvent(string message)
        {
            if(BolierLog != null)
            {
                BolierLog(message);
            }
        }
    }

    class BoilerInfoLogger
    {
        FileStream ps;
        StreamWriter sw;
        public BoilerInfoLogger(string filename)
        {
            ps = new FileStream(filename,FileMode.Append,FileAccess.Write);
            sw = new StreamWriter(ps);
        }
        public void Logger(string info)
        {
            sw.WriteLine(info);
        }
        public void Close()
        {
            sw.Flush();
            sw.Close();
            ps.Close();
        }
    }

    class RecordBoilerInfo
    {
        static void Logger(string info)
        {
            Console.WriteLine(info);
        }

        static void Main(string[] args)
        {
            BoilerInfoLogger fileLog = new BoilerInfoLogger("D:/vs2015_code/CsharpLearning/boiler_xiaoyi.txt");
            DelegateBoilerEvent boilerEvent = new DelegateBoilerEvent();
            boilerEvent.BolierLog += new DelegateBoilerEvent.Loggerhandler(Logger);
            boilerEvent.BolierLog += new DelegateBoilerEvent.Loggerhandler(fileLog.Logger);
            boilerEvent.LogPrecess();
            Console.ReadLine();
            fileLog.Close();
        }
    }
>>>>>>> 15f48d12c77209f7230e776d5667dcb793fc77c1
}
*/



/*  //LearningDelegateAndEvent
namespace DelegateAndEvent
{
	public delegate void RingHandler();
	class ring
	{
		public event RingHandler DoIt;
		public void RaiseRing()
		{
			if(DoIt != null)
			{
				DoIt();
			}
			else
			{
				Console.WriteLine("No thing to happend");
			}
		}
	}
	class Stuedent
	{
		public void GetUp()
		{
			Console.WriteLine("Student GetUp");
		}
	}

	class Cooker
	{
		public void Cook()
		{
			Console.WriteLine("Cook is cook");
		}
	}

	class TestDelegateAndEvent
	{
		static void Main(String[] args)
		{
			ring r = new ring();
			Stuedent s = new Stuedent();
			Cooker c = new Cooker();
			r.DoIt += new RingHandler(s.GetUp);
			r.DoIt += new RingHandler(c.Cook);
			r.RaiseRing();
			Console.ReadLine();
		}
	}
}
*/



/*  //Learning Delegate And Event
namespace LearningDelegateAndEvent
{
    class TestDelegateAndEvent
    {
        public delegate void DelegateTestHandler();
        public event DelegateTestHandler EventTest;
        public void start()
        {
            Console.WriteLine("Launch Event");
            EventTest();
            Console.ReadLine();
        }
    }
    class program
    {
        static void Test()
        {
            Console.WriteLine("this is registered function");
            Console.ReadLine();
        }
        static void Main(string [] args)
        {
            TestDelegateAndEvent app = new TestDelegateAndEvent();
            app.EventTest += Test;
            app.start();
        }
    }
}
*/



/*    //Learning ArrayList
using System.Collections;
namespace LearnArrayList
{
	class TestArrayList
	{
		static void Main(string [] args)
		{
			ArrayList list = new ArrayList();
			Console.WriteLine("prease add some numbers");
			list.Add(44);
			list.Add(33);
			list.Add(43);
			list.Add(22);
			list.Add(99);
			list.Add(78);
			list.Add(65);
			list.Add(46);
			list.Add(55);
			Console.WriteLine("The List Capacity is {0}",list.Capacity);
			Console.WriteLine("The List Count is {0}", list.Count);

			Console.WriteLine("Content: ");
			
			foreach(int i in list)
			{
				Console.Write(i + " ");
			}
			Console.WriteLine();
			Console.WriteLine("The Sorted List is: ");
			//list.Sort();
			list.Remove(99);
			list.Insert(4, 99);
			foreach(int i in list)
			{
				Console.Write(i + " ");
			}

			Console.WriteLine(list.IsFixedSize);
			Console.WriteLine(list.IsReadOnly);
			Console.ReadLine();
		}
	}
}
*/



/* //Learning HashTable
using System.Collections;
namespace LearningHashTable
{
	class TestHashTable
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			ht.Add("001", "xiaoyi");
			ht.Add("002", "meizhen");
			ht.Add("003", "xiaoyao");
			ht.Add("004", "qiongzi");
			ht.Add("005", "xiaoke");

			Console.WriteLine("The HashTable Count is : {0}", ht.Count);

			if (ht.ContainsValue("xiaomei"))
			{
				Console.WriteLine("The value in HashTable is existed");
			}
			else
			{
				ht.Add("006", "xiaomei");
			}

			ICollection key = ht.Keys;
			foreach(string k in key)
			{
				Console.WriteLine(k + ": " + ht[k]);
			}
			Console.WriteLine();
			ht.Remove("006");
			foreach (string k in key)
			{
				Console.WriteLine(k + ": " + ht[k]);
			}

			ht.Clear();
			Console.WriteLine("The HashTable Count is: ", ht.Count);
			Console.ReadLine();
		}
	}
}
*/



/*  //Learning SortedList
using System.Collections;
namespace LearningSortedList
{
	class TestSortedList
	{
		static void Main(string[] args)
		{
			SortedList st = new SortedList();
			st.Add("001", "xiaoyi");
			st.Add("002", "meizhen");
			st.Add("003", "xiaoyao");
			st.Add("004", "qiongzi");
			st.Add("005", "xiaoke");

			Console.WriteLine("The SortedList Count is {0}", st.Capacity);

			if (st.ContainsValue("xiaomei"))
			{
				Console.WriteLine("xiaomei is already in SortedList");
			}
			else
			{
				st.Add("006", "xiaomei");
			}

			ICollection key = st.Keys;
			foreach(string k in key)
			{
				Console.WriteLine(k +" " + st[k]);
			}
			Console.ReadKey();
		}
	}
}
*/






namespace LearningFormat
{
	class TestFormat
	{
		static void Main(string[] args)
		{
			float a = 1.00f;
			Console.WriteLine(a.ToString(string.Format("{0:N}",a)));
			Console.ReadLine();
		}
	}
}








