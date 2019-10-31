using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingGenericsAndLoops genLoop = new UsingGenericsAndLoops();
            genLoop.BooksToRead();
            genLoop.DoWhileLoop();
            genLoop.Barbers();
            genLoop.WhileLoop();
            genLoop.TopScorers();
            genLoop.ForLoop();
            genLoop.ShoppingList();
            genLoop.ForeachLoop();
            Console.ReadLine();
        }
    }
}
