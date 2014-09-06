using System;
using System.Collections;
using System.Collections.Generic;

namespace FunWithGenerics
{
    class Program
    {
        static void Main()
        {
            var arrayList = new ArrayList
            {
                new Apple(),
                new Orange(),
                new Potato()
            };

            var f = (Fruit)arrayList[0];
            //var s = arrayList[2] as Fruit;

            Console.WriteLine(f.GetType());

            var fruits = new List<Fruit>         
            {
                new Apple(),
                new Orange(),
                //new Potato()
            };

            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit.GetType());
            }

            var appleGardener = new Gardener<Apple>();
            appleGardener.Grow(new Apple());

            var orangeGardener = new Gardener<Orange>();
            orangeGardener.Grow(new Orange());

            Console.ReadKey();
        }
    }

    abstract class Fruit
    {
        public abstract int GetSize();
    }

    class Apple : Fruit
    {
        public override int GetSize()
        {
            return 2;
        }
    }

    class Orange : Fruit
    {
        public override int GetSize()
        {
            return 3;
        }
    }

    class Potato
    {
         
    }

    class Gardener<T> where T : Fruit
    {
        public void Grow(T fruit) 
        {
            Console.WriteLine(fruit.GetSize());
        }
    }
}
