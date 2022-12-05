using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;


internal class Program
{
    private static void Main(string[] args)
    {
        Stack<char> firstStack = new Stack<char>();
        Stack<char> secondtStack = new Stack<char>();

        string check = "{(([))}";

        int length = check.Length;
        bool valid = true;


        foreach (char c in check)
        {
            firstStack.Push(c);
        }


        while (firstStack.Count > length / 2 && length % 2 == 0)
        {
            secondtStack.Push(firstStack.Peek());
            firstStack.Pop();
        }

        while (firstStack.Count > 0 && secondtStack.Count > 0)
        {
            if (firstStack.Peek() == '{' && secondtStack.Peek() == '}')
            { 
                firstStack.Pop();
                secondtStack.Pop();

            }
            else if (firstStack.Peek() == '[' && secondtStack.Peek() == ']')
            {
                firstStack.Pop();
                secondtStack.Pop();

            }

            else if (firstStack.Peek() == '(' && secondtStack.Peek() == ')')
            {
                firstStack.Pop();
                secondtStack.Pop();

            }

            else
            {
                valid = false;
                break;
            }}


        if (!valid || (valid && length % 2 != 0))
        { Console.WriteLine("Invalid Condition!");}
        else
        { Console.WriteLine("Correct Is Valid ");
           
        }
    }
} 