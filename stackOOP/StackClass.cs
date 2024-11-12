using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackOOP
{
    internal class StackClass
    {
        private int top;
        private object[] stack;
        public static int stackCount = 0;//counts the number of stacks created

        public StackClass(int stack_size)
        {
            top = -1;
            stack = new string[stack_size];
            stackCount++;
            Console.WriteLine("new stack created with {0} spaces", stack_size);
        }

        private bool is_empty()
        {
            if (top == -1)
            { return true; }
            else
            { return false; }
        }
        private bool is_full()
        {
            if (top == 51)
            { return true; }
            else
            { return false; }
        }

        public object peek( )
        {
            if (this.is_empty())
            {
                Console.WriteLine("The stack is empty");
                return null;//nothing to return
            }
            else
            { return stack[top]; }
        }

        public void push(string data)
        {
            if (this.is_full())
            { Console.WriteLine("The Stack is full - unable to push"); }
            else
            {
                top++;
                stack[top] = data;
            }
        }

        public object pop()
        {
            if (is_empty())
            {
                Console.WriteLine("Stack is empty - nothing to pop");
                return null;//nothing to return
            }            
            top--;//move the top down
            return stack[top+1];//return the item that was at the top
        }
    }
}
