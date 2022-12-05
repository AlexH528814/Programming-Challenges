using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter writer;

        // writer = new StreamWriter("textfile.txt");

        // string path = "textfile.txt";

        string path = @"D:\testfileforwriting.txt";
        // Create the file, or overwrite if the file exists.
        //using (FileStream fs1 = File.Create(path))

        //writer = new StreamWriter(path);
        //writer.WriteLine("hello world");
        //writer.Close();


        /*
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine("Text added");

                    sr.Close();

                    Console.WriteLine(File.ReadAllText(path));

                }*/



        using FileStream fs = File.Create(path);
        using var sr = new StreamWriter(fs);

        sr.WriteLine("coin\nfalcon\nhawk\nforest");

        Console.WriteLine("done");


    }
}