using System;

class Program
{
    static void Main(string[] args)
    {
        string hello;

        void Hello()
        {
            hello = "hello";
        }

        Hello();

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
        int[] myNumbers = {1, 2, 3, 4, 5};
        Console.WriteLine(myNumbers);
    }
}
