using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)                                                                               
        {
            int input=-1;
            int guess;

            guess = new Random().Next(100); //0-100
            Console.WriteLine("輸入0-100");
            while (true)
            {
                //決定輸入內容
                string input_str = Console.ReadLine();  //input  string 
                input = int.Parse(input_str);
                if (input == guess)
                {
                    Console.WriteLine("YES");
                    break;
                }
                Console.WriteLine("NO");
            }
        

            Console.WriteLine("PAUSE");
            Console.ReadKey();
        }
    }
}
