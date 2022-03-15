using System;

namespace Polymorphism
{
    class abbu
    {
        public virtual void Show()
        {
            int a = 10;
            int b = 15;
            Console.WriteLine(a+b);
        } 
    }
    class bacha : abbu
    {
        public override void Show()
        {
            int a = 10;
            int b = 15;
            Console.WriteLine(a - b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            abbu obj = new bacha();
            obj.Show();
            Console.ReadLine();
        }
    }
}
