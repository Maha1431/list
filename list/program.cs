using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
    class program
    {
        static void Main(string[] args)
        {
            /* linkedlist<int> list = new linkedlist<int>();
             list.add(56);
             list.add(70);
             list.add(30);
             Console.ReadLine();*/

            Stack<int> stack = new Stack<int>();
            stack.Push(56);
            stack.Push(70);
            stack.Push(30);
            stack.Peek();

        }


    }

}

