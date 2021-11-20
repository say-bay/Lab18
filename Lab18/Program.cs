using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab18
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[8];
            array[0] = "(";
            array[1] = "[";
            array[2] = "]";
            array[3] = "{";
            array[4] = "}";
            array[5] = ")";
            array[6] = "[";
            array[7] = "]";
            Stack<string> brackets1 = new Stack<string>();
            Stack<string> brackets2 = new Stack<string>();
            Stack<string> brackets3 = new Stack<string>();
            for (int i = 0; i < 8; i++)
            {
                if (array[i] == "{")
                {
                    brackets1.Push(array[i]);
                }
                if (array[i] == "[")
                {
                    brackets2.Push(array[i]);
                }
                if (array[i] == "(")
                {
                    brackets3.Push(array[i]);
                }
                if (array[i] == "}")
                {
                    string stackElement1 = brackets1.Pop(); ;
                }
                if (array[i] == "]")
                {
                    string stackElement2 = brackets2.Pop(); ;
                }
                if (array[i] == ")")
                {
                    string stackElement3 = brackets3.Pop(); ;
                }
            }
            int a = 0;
            int b = 0;
            int c = 0;
            try
            {
                string stackElementEnd1 = brackets1.Peek();
            }
            catch
            {
                a = 1;
            }
            try
            {
                string stackElementEnd2 = brackets2.Peek();
            }
            catch
            {
                b = 1;
            }
            try
            {
                string stackElementEnd3 = brackets3.Peek();
            }
            catch
            {
                c = 1;
            }
            finally
            {
                if ((a + b + c) != 3)
                {
                    Console.WriteLine("Не верно расставлены скобки");
                }
                else
                {
                    Console.WriteLine("Верно расставлены скобки");
                }
            }
            Console.ReadKey();
        }
    }
}
