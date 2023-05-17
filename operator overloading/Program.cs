using System;

namespace operator_overloading
{
    public class Food
    {
        public string Name { get; set; }
        // Constructor
        public Food(string name)
        {
            Name = name;
        }
        // Overloading the + operator to combine two Food objects
        public static Food operator +(Food food1, Food food2)
        {
            string Name = $"{food1.Name} {food2.Name} Combo";
            return new Food(Name);
        }
    }
    class pro
    {
        static void Main(string[] args)
        {
            Food pizza = new Food("Pizza");
            Food burger = new Food("Burger");
            Food combo = pizza + burger;
            Console.WriteLine(combo.Name);
        }
    }
}