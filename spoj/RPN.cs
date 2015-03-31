using System;
using System.Collections.Generic;
using System.Text;

class Test
{
    static Dictionary<char, int> priorities = new Dictionary<char, int>();
    static Dictionary<char, char> associativity = new Dictionary<char, char>();

    static void Main()
    {
        priorities['+'] = 1;
        priorities['-'] = 1;
        priorities['*'] = 2;
        priorities['/'] = 2;
        priorities['^'] = 3;

        associativity['+'] = 'l';
        associativity['-'] = 'l';
        associativity['*'] = 'l';
        associativity['/'] = 'l';
        associativity['^'] = 'r';

        int num = int.Parse(Console.ReadLine());
        while(num > 0)
        {
            ParseExpression(Console.ReadLine());

            num--;
        }
    }

    static void ParseExpression(string exp)
    {
        Queue<char> output = new Queue<char>();
        Stack<char> operators = new Stack<char>();

        for(int i = 0; i != exp.Length; i++)
        {
            char c = exp[i];
            if (c >= 'a' && c <= 'z')
                output.Enqueue(c);
            else if(c == '(')
            {
                operators.Push(c);
            }
            else if(c == ')')
            {
                char c2;
                while((c2 = operators.Pop()) != '(')
                {
                    output.Enqueue(c2);
                }
            }
            else
            {
                if((operators.Peek() == '(') ||
                   (priorities[c] > priorities[operators.Peek()]) ||
                   (priorities[c] == priorities[operators.Peek()] && associativity[c] == 'l'))
                {
                    operators.Push(c);
                }
                else
                {
                    output.Enqueue(operators.Pop());
                    operators.Push(c);
                }
            }
        }

        while(operators.Count != 0)
        {
            output.Enqueue(operators.Pop());
        }

        StringBuilder sb = new StringBuilder();
        while (output.Count != 0)
            sb.Append(output.Dequeue());

        Console.WriteLine(sb.ToString());
    }
}
