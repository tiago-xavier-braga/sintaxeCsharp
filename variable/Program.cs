using System;

namespace variables{
    class Program{
        static void Main(){
            Console.WriteLine("Variables");

            int x = 5;
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);

            string text = "Hello Word";
            Console.WriteLine(text);

            /*
            string readNumberUser; 
            readNumberUser = Console.ReadLine();
            Console.WriteLine(readNumberUser);
            */
            Console.WriteLine("Cast");
            int a = 2;
            int b = 3;

            float result = (float) a / b;
            Console.WriteLine(result);
            Console.WriteLine($"Result a/b is: {result}");
        }
    }
}