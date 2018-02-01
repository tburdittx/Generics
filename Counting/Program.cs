using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Generics.Apples;


namespace Generics
{

    class Program
    {
        public static int Count = 0;      
        public static int AllApples = 0;

        static  List<Apples> BoxOfApple = new List<Apples>();

        static void Main(string[] args)
        {

            Cart cart = new Cart();
            Counter<Apples> counter = new Counter<Apples>();

            BoxOfApple.Add(new Apples() { colour = Colour.Green });
            BoxOfApple.Add(new Apples() { colour = Colour.Green });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });
            BoxOfApple.Add(new Apples() { colour = Colour.Red });

            Box<Apples> box = new Box<Apples>();
            box.Add(BoxOfApple);           

            foreach (Apples apple in BoxOfApple)
            {
                Counter<Apples> counters = new Counter<Apples>();
                counters.CountAllApples();
            }

            Console.WriteLine("Number of Apples: {0}", AllApples);

            Console.ReadLine();
        }
       
    }  
}
