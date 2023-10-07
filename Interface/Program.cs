using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface i1
    {
        void show();
    }
    interface i2
    {
        void show2();
    }
    class A : i1, i2
    {
        public void show() {
            Console.WriteLine("i1");
        }
        public void show2()
        {
            Console.WriteLine("i2");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            i1 obj1;
            i2 obj2;
            obj1 = new A();
            obj2 = new A();
            obj1.show();
            obj2.show2();
            Console.ReadLine();
        }
    }
}
