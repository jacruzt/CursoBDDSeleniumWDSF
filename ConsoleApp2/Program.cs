using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Triangle
    {
        public int bas;
        public int height;

        public static int staticint;

        public static void SetStaticValue(int par1)
        {
            staticint = par1;
        }

        public static void GetStaticValue()
        {
            SetStaticValue(150);
            Console.WriteLine("Stataic Value {0}", staticint);
        }
        public void SetValue(int par1)
        {
            staticint = par1;
        }

        public void GetStatic()
        {
            Console.WriteLine("Stataic Value {0}",staticint);
        }

        //Constructor
        public Triangle(int a, int b)
        {
            Console.WriteLine("Constructor called");
            bas = a;
            height = b;
        }

        //<access specifier> <return type> <name> (<paraameter>) {}

        public void GetArea()
        {
            double area = (0.5 * (bas * height));
            Console.WriteLine("Area is : {0}", area);
        }

        public double GetArea(int par1, int par2)
        {
            return (0.5*(par1 * par2));
        }

        public double GetArea(double par1, double par2)
        {
            return (0.5 * (par1 * par2));
        }

        public double GetTriangleArea()
        {
            double area = (0.5 * (bas * height));
            return area;
        }

        public void SetValue(int par1, int par2)
        {
            bas = par1;
            height = par2;
        }
    }
    
    public abstract class AbstClass
    {
        private int a;
        private int b;
        protected int add = 0;

        public abstract void Add(int par1, int par2);
        public abstract void Add(double par1, int par2);

        public void Display()
        {
            Console.WriteLine("Addition is : {0}", add);
        }
    }

    public abstract class ChildClass : AbstClass
    {
        public override void Add(int par1, int par2)
        {
            base.add = (par1 + par2);
        }
    }

    public class GrandChild : ChildClass
    {
        public override void Add(double par1, int par2)
        {
            base.add = (int)(par1 + par2);
        }
    }

    public class BaseClassOne : AbstClass
    {
        public override void Add(int par1, int par2)
        {
            base.add = (par1 + 10 + 20 + par2);
        }

        public override void Add(double par1, int par2)
        {
            base.add = (int) (par1 + 30 + 40 + par2);
        }
    }

    public interface INterface
    {
        void Display(string str);
        void Display(string str1, string str2);
    }

    public interface INterface2
    {
        int Get(int par1);
    }

    public class UserDefineException : Exception
    {
        public UserDefineException(string str) : base(str)
        {
            Console.WriteLine("User Define Exception.");
        }
    }


    public class DerivedClassOne : INterface, INterface2
    {
        public void Display(string str)
        {
            Console.WriteLine(str);
        }

        public void Display(string str1, string str2)
        {
            try
            {
                Console.WriteLine("{0} : {1}", str1, str2);
                throw new UserDefineException ("Created by user");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally Block.");
            }
        }

        public int Get(int par1)
        {
            return par1;
        }
    }

    public class DerivedClassTwo : INterface
    {
        public void Display(string str)
        {
            Console.WriteLine(str);
        }

        public void Display(string str1, string str2)
        {
            Console.WriteLine("{0} : {1}", str1, str2);
        }

        public void Show()
        {
            Console.WriteLine("{0} : {1}", "a", "b");
        }
    }

    public class PropertyClass
    {
        private string data;

        public void SetData(string par1)
        {
            data = par1;
        }

        public string GetData()
        {
            return data;
        }

        public string Data1 { get; set;}

        public string Data
        {
            get { return data; }
            set { data = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle obj1 = new Triangle(10, 20);
            //Triangle obj2 = new Triangle(100, 200);

            //obj1.GetArea();
            
            //Console.WriteLine("Area ints: {0}", obj1.GetArea(10,20));
            //Console.WriteLine("Area doubles: {0}", obj1.GetArea(10.34, 20.59));

            //GrandChild obj = new GrandChild();
            //obj.Add(26, 48);
            //obj.Display();

            //obj.Add(26.78, 48);
            //obj.Display();

            //BaseClassOne obj2 = new BaseClassOne();
            //obj2.Add(12, 13);
            //obj2.Display();

            //obj2.Add(12.87, 33);
            //obj2.Display();

            //INterface refobj = new DerivedClassOne();

            //refobj.Display("DerivedClassOne - 1");
            //refobj.Display("DerivedClassOne - 1", "DerivedClassone - 2");

            //INterface2 refobj1 = new DerivedClassOne();

            //Console.WriteLine(refobj1.Get(20));

            //INterface refobj2 = new DerivedClassTwo();

            //refobj2.Display("DerivedClassTwo - 1");
            //refobj2.Display("DerivedClassTwo - 1", "DerivedClassone - 2");

            PropertyClass pc = new PropertyClass();
            pc.SetData("Value 1");
            Console.WriteLine("Data :  {0}", pc.GetData());

            pc.Data = "Rhaul";
            Console.WriteLine("Data :  {0}", pc.Data);

            pc.Data1 = "Javier";
            Console.WriteLine("Data :  {0}", pc.Data1);

            //obj1.height = 10;
            //obj1.bas = 20;

            //obj2.height = 100;
            //obj2.bas = 200;

            //obj1.SetValue(10, 20);
            //obj2.SetValue(100, 200);

            //obj1.SetValue(123);

            //Triangle.staticint = 10;

            //obj2.GetStatic();

            //Triangle.GetStaticValue();

            //DerivedClass der = new DerivedClass(547);

            //der.GetIntPub();
            //der.Show();
            //der.GetFromBaseClass();

            //obj1.GetArea();
            //obj2.GetArea();

            //Console.WriteLine("Area is : {0}", obj1.GetTriangleArea());
            //Console.WriteLine("Area is : {0}", obj2.GetTriangleArea());

            //string var1 = "Hello, World!" + "Mexico";
            //string var12 = @"C:\Pandora jacruzt\pandora\DB1SOB\Trading Services\FXDW";
            //int var2 = 10;
            //bool var3 = false;
            //char var4 = 'A';
            //Console.WriteLine("Values {0}", var12);
            //Console.WriteLine("Values {0},{1},{2},{3}", var1,var2,var3,var4);
            //Console.ReadKey();

            //char input = (char)Console.Read(); 

            //if ((input == 'a') || (input == 'b') || (input == 'c'))
            //{
            //    Console.WriteLine("Input is: {0}", input);
            //}
            //else
            //{
            //    Console.WriteLine("Input is Not Valid: {0}", input);
            //}
            //else if (input == 'b')
            //{
            //    Console.WriteLine("Input is: {0}", input);
            //}
            //else if (input == 'c')
            //{
            //    Console.WriteLine("Input is: {0}", input);
            //}

            //switch(input)
            //{
            //    case 'a':
            //        Console.WriteLine("Input is: {0}", input);
            //        break;

            //    case 'b':
            //        Console.WriteLine("Input is: {0}", input);
            //        break;

            //    case 'c':
            //        Console.WriteLine("Input is: {0}", input);
            //        break;

            //    default:
            //        Console.WriteLine("Input is Not Valid: {0}", input);
            //        break;

            //}

            //for (int i = 0; i < 10; i=i+1)
            //{
            //    Console.WriteLine("Input is: {0}", i);
            //}

            //int i = 0;

            //while (i < 10)
            //{
            //    Console.WriteLine("Input is: {0}", i);
            //    i = i + 1;
            //}
            Console.ReadKey();
        }
    }
}
