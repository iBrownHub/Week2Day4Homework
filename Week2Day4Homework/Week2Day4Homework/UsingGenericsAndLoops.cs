using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4Homework
{
    class UsingGenericsAndLoops
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        List<string> list = new List<string>();
        Dictionary<int, string> dict = new Dictionary<int, string>();
        public UsingGenericsAndLoops()
        {

        }
        public Stack<string> BooksToRead()
        {
            stack.Push("Harry Potter and the Philosophers Stone");
            stack.Push("American Psycho");
            stack.Push("The Bible");
            return stack;
        }
        public void DoWhileLoop()
        {
            do
            {
                Console.WriteLine(stack.Pop());
            } while (stack.Count > 0);
        }

        public Queue<string> Barbers()
        {
            queue.Enqueue("Ross Brown");
            queue.Enqueue("James Hunter");
            queue.Enqueue("Harry Smith");
            return queue;
        }
        public void WhileLoop()
        {
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        public Dictionary<int, string> TopScorers()
        {
            dict.Add(1, "Ross Brown");
            dict.Add(2, "James Hunter");
            dict.Add(3, "Harry Smith");
            return dict;
        }

        public List<string> ShoppingList()
        {
            list.Add("Ham");
            list.Add("Cheese");
            list.Add("Lettuce");
            list.Add("Bread");
            return list;
        }
        public void ForLoop()
        {
            for (int i = 1; i <= dict.Count; i++)
            {
                Console.WriteLine(dict[i]);
            }
        }
        public void ForeachLoop()
        {
            int[] scores = { 230875, 223491, 210092 };
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
