using System;

namespace Widget {
    class Program {
        static void Main(string[] args) {
           var w1 = new Widget("LARGE", "RED");
            Console.WriteLine($"A {w1.Size}, {w1.Color} widget cost {w1.Price()}");
            var wsw2 = new Widget("SMALL", "WHITE");
            Console.WriteLine($"A { wsw2.Size}, { wsw2.Color} Widget cost { wsw2.Price()}");
        }
    }
}
