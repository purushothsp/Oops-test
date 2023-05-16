using System;

namespace multilevel
{
    class karam
    {
        public void val()
        {
            Console.WriteLine("Vegetable Pakoda");
        }
    }
    class sweet : karam

    {
        public void swt()
        {
            Console.WriteLine("MothiLaddu");
        }
    }
    class even_snacks : sweet
    {
        public void even()
        {
            Console.WriteLine("Ragi Cookies");
        }
    }
    class multi
    {
        static void Main(string[] args)
        {
            even_snacks snacks = new even_snacks();

            snacks.val(); 
            snacks.swt();
            snacks.even();
        }
    }
}