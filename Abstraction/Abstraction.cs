using System;

namespace milk
{
    abstract class food
    {
        public abstract void makeing();
    }
    class Rasmalai : food
    {
        public override void makeing()
        {
            Console.WriteLine("Made in milk,nuts,saffron and cardamoms.");
        }
    }
    class Khee : food
    {
        public override void makeing()
        {
            Console.WriteLine("Made in milk and badam");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            food myra = new Rasmalai();
            food mykhee = new Khee();
            myra.makeing();
            mykhee.makeing();
        }
    }
}
