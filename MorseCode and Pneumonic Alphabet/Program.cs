using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Text;

class Program
{
    public static Dictionary<char, string> morsecodedict;   

    static void Main()
    {
        InitializeDict();

        Console.WriteLine("Enter a letter and I'll tell you it's NATO phonetic alphabet telephony");
        var input = Console.ReadKey();

        char letter = input.KeyChar;

        PneumonicAlphabet(letter);


        Console.WriteLine("Type something and I'll send it back in morse code");
            string answer = Console.ReadLine();
        answer = answer.ToLower();

        Console.WriteLine(Translate(answer)) ;


    }

    public static string Translate(string input)
    {
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char character in input)
        {
            if (morsecodedict.ContainsKey(character))
            {
                stringBuilder.Append(morsecodedict[character] + " ");
            }
            else if (character == ' ')
            {
                stringBuilder.Append("/ ");
            }
            else
            {
                stringBuilder.Append(character + " ");
            }
        }

        return stringBuilder.ToString();
    }


    public static void PneumonicAlphabet(char letter)
    {
        
        Console.WriteLine("");

        switch (letter)
        {
            case 'a':
                Console.WriteLine("alfa");
                break;

            case 'b':
                Console.WriteLine("bravo");
                break;

            case 'c':
                Console.WriteLine("delta");
                break;

            case 'd':
                Console.WriteLine("delta");
                break;

            case 'e':
                Console.WriteLine("echo");
                break;

            case 'f':
                Console.WriteLine("foxtrot");
                break;

            case 'g':
                Console.WriteLine("golf");
                break;

            case 'h':
                Console.WriteLine("hotel");
                break;

            case 'i':
                Console.WriteLine("india");
                break;

            case 'j':
                Console.WriteLine("juliett");
                break;

            case 'k':
                Console.WriteLine("kilo");
                break;

            case 'l':
                Console.WriteLine("lima");
                break;

            case 'm':
                Console.WriteLine("mike");
                break;

            case 'n':
                Console.WriteLine("november");
                break;

            case 'o':
                Console.WriteLine("oscar");
                break;

            case 'p':
                Console.WriteLine("papa");
                break;

            case 'q':
                Console.WriteLine("quebec");
                break;

            case 'r':
                Console.WriteLine("romeo");
                break;

            case 's':
                Console.WriteLine("sierra");
                break;

            case 't':
                Console.WriteLine("tango");
                break;

            case 'u':
                Console.WriteLine("uniform");
                break;

            case 'v':
                Console.WriteLine("victor");
                break;

            case 'w':
                Console.WriteLine("whiskey");
                break;

            case 'x':
                Console.WriteLine("xray");
                break;

            case 'y':
                Console.WriteLine("yankee");
                break;

            case 'z':
                Console.WriteLine("zulu");
                break;

            default:
                Console.WriteLine("Retry");
                Console.WriteLine("");
                Main();
                return;
        }
    }
























































    public static void InitializeDict()
    {
        morsecodedict = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };
    }

}