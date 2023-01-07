using System;
using System.Linq;
using System.IO;

class Program {
    public static void Main(string[] args) {
        Console.Write("TitanCommands Shell >>> ");
        string inputFile = Console.ReadLine();

        if (File.Exists(inputFile)) {
            string text = File.ReadAllText(inputFile);
            Console.WriteLine("\n");
            Console.WriteLine("*****************");
            Console.WriteLine("* TitanCommands *");
            Console.WriteLine("*  O U T P U T  *");
            Console.WriteLine("*****************");
            Console.WriteLine("\n");
            Parser.parse(text);
        }

        else {
            throw new Exception($"There is no such file called '{inputFile}'!");
        }
    }
}

internal class Parser {
    public static void parse(string text) {
        string[] fileText = text.Split(";");
        foreach (string tok in fileText) {
            string token = tok.Replace("\n", "");
            if (token.StartsWith("println(") && token.EndsWith(")")) {

                if (token.Split("\"").Length == 3) {
                    Console.WriteLine(token.Split("\"")[1]);
                }

                else { throw new Exception($"println(string); takes exactly 3 arguments of which {token.Split("\"").Length} were given."); }
            }

            else if (token.StartsWith("println(")) { throw new Exception("Syntax error"); }

            else if (token.StartsWith("print(") && token.EndsWith(")")) {
                if (token.Split("\"").Length == 3) {
                    Console.Write(token.Split("\"")[1]);
                }

                else { throw new Exception(($"print(string); takes exactly 3 arguments of which {token.Split("\"").Length} were given.")); }
            }

            else if (token.StartsWith("print(")) { throw new Exception("Syntax error"); }
        }
    }
}
