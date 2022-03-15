using System;

namespace Polymorphism
{
    class myClass
    {
        public void Show()
        {
            int a = 10;
            int b = 15;
            Console.WriteLine(a+b);
        } 
        public void Show(int a, int b)
        {
            Console.WriteLine(a+b);
        } 
        public void Show(int a, int b, int c)
        {
            Console.WriteLine(a+b+c);
        } 
        public void Show(string a, string b)
        {
            Console.WriteLine("{0} {1}",a,b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            myClass obj = new myClass();
            obj.Show();
            obj.Show(5,9);
            obj.Show("Asgar","Chandiyo");
            obj.Show(7,7,7);
            obj.Show();
            Console.ReadLine();
        }
    }
}
