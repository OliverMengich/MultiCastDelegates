using System;

namespace DynamiPoly2
{
    class Pig:Animal
    {
        public override  void  foodhabit()
        {
              System.Console.WriteLine("Food Habit Of Pig");
        }
    }
     class Animal
    {
        public virtual void foodhabit()
        {
            System.Console.WriteLine(" Food Habit Of class Animal");
        }
    }
    class dog: Animal
    {
      public override void foodhabit()
      {
         System.Console.WriteLine("This is FoodHabit of dog");

      }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new dog();
            animal.foodhabit();
            animal = new Animal();
            animal.foodhabit();
            animal = new Pig();
            animal.foodhabit();
        }
    }
}
