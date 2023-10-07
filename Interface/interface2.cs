using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface i
    {
        void greet();
    }
    class B : i
    {
        public void greet() {
            Console.WriteLine("Good Morning!");
        }
    }
    class C : i
    {
        public void greet()
        {
            Console.WriteLine("Good Afternoon!");
        }
    }
    class D : i
    {
        public void greet()
        {
            Console.WriteLine("Good Evening!");
        }
    }
    internal class interface2
    {
        public static void main(string[] args)
        {
            i obj;
            obj = new B();
            obj.greet();
            obj = new C();
            obj.greet();
            obj = new D();
            obj.greet();
            Console.ReadLine();
        }
    }
}
