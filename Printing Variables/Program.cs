using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string hello;

        hello = "Hello World";

        Console.WriteLine(hello);

        int a = 1;
        Console.WriteLine(a);

        //whole number
        int b = 2;

        //decimal number
        double d = 3.5;

        //word
        string f = "word";

        //multiple numbers
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }
    }
}
