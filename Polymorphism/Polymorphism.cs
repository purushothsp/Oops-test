using System;

/*namespace milk
{
    public class milk
    {
        public virtual void makeing()
        {
            Console.WriteLine("Food");
        }
    }
    class Rasmalai : milk
    {
        public override void makeing()
        {
            Console.WriteLine("Made in milk,nuts,saffron and cardamoms.");
        }
    }
    class Khee : milk
    {
        public override void makeing()
        {
          Console.WriteLine("Made in milk and badam");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            milk myfood = new milk();
            milk myra = new Rasmalai();
            milk mykhee = new Khee();
            myfood.makeing();
            myra.makeing();
            mykhee.makeing();

        }
    }
}*/

//method overloading

namespace overloading
{
    class food
    {
        public void foodEat()
        {
            Console.WriteLine("food for eat");
        }
    }
    class Rasamalai : food
    {
        public void foodEat()
        {
            Console.WriteLine("this is sweet");
        }
    }
    class Vegetable_Pakoda : food
    {
        public void foodEat()
        {
            Console.WriteLine("this is karam");
        }
    }
    class pro
    {
        public static void Main(string[] args)
        {
            food fd = new food();
            food Rasamalai = new Rasamalai();
            food Vegetable_Pakoda = new Vegetable_Pakoda();
            fd.foodEat();
            Rasamalai.foodEat();
            Vegetable_Pakoda.foodEat();
        }
    }
}