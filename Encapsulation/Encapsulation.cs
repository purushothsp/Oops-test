using System;

namespace Encapsulation
{
    class food
    {
        private string name;
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
        private string name2;
        public string Name2
        {
            get
            {
                return name2;
            }
            set 
            { 
                name2 = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            food fd = new food();
            fd.Name = "Rasa Malai";
            fd.Name2 = "Kheer ";
            Console.WriteLine("The Food Name Is: "+ fd.Name);
            Console.WriteLine("The Food Name Is: "+ fd.Name2);
        }
    }
}
