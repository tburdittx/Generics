using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {  
        static  List<Apples> BoxOfApple = new List<Apples>();
        static List<Apples> MoreApples = new List<Apples>();
        static List<Cart<Box<Apples>>> HowManyBoxes = new List<Cart<Box<Apples>>>();
        static void Main(string[] args)
        {
            Apples apples = new Apples();
           Cart<Apples> cart = new Cart<Apples>();
           Counter<Apples> counters = new Counter<Apples>();
            Counter<Apples> moreCounting = new Counter<Apples>();

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

            BoxOfApple.ForEach(counters.Add);

            MoreApples.Add(new Apples() { colour = Colour.Green });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });
            MoreApples.Add(new Apples() { colour = Colour.Yellow });

            MoreApples.ForEach(moreCounting.Add);

            cart.Add(BoxOfApple);
            cart.Add(MoreApples);

            Console.WriteLine("Number of Apples in the Box 1: {0}", counters.Count());
            Console.WriteLine($"Number of Apples in Box 2: {moreCounting.Count()}");
            Console.WriteLine($"Number of Apples in the cart: {cart.Count()} ");

            Console.ReadLine();
        }
    }  
}
