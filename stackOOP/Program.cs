using stackOOP;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        StackClass stack1 = new StackClass(52);//create a stack for 52 items
        Console.WriteLine("We have {0} stacks now", StackClass.stackCount);//using the static stackCount variable.
        StackClass stack2 = new StackClass(10);//create a stack for 10 items

        stack1.push("A");
        stack1.push("B");
        Console.WriteLine(stack1.peek());
        stack2.push("C");
        Console.WriteLine(stack1.pop());
        Console.WriteLine(stack2.pop());
        Console.WriteLine(stack2.pop());
        Console.WriteLine("We have {0} stacks now", StackClass.stackCount);
        StackClass stack3 = new StackClass(20);
        Console.WriteLine("We have {0} stacks now",StackClass.stackCount);
    }
}