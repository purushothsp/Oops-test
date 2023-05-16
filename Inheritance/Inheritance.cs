using System;

namespace SingleInheritance
{
    class karam_Snacks
    {
        public string karam;
        public void val() 
        {
            karam = "Vegetable Pakoda";
        }
    }
    class sweet_Snacks: karam_Snacks
    {
        public string sweet;
        public void val2()
        { 
             sweet= "MothiLaddu";
        }
        public string get()
        {
            return(karam);
        }
        public string getsweet()
        {
            return(sweet);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            sweet_Snacks fd = new sweet_Snacks();
            fd.val();
            fd.val2();
            Console.WriteLine("karam name:"+fd.get());
            Console.WriteLine("sweet name:" + fd.sweet);
            Console.ReadLine();
        }
    }
}