using System;

namespace WordsinSentences
{   
  
    class MainClass
    {
        public static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string[] word = sentence.Split();
            Console.WriteLine(word.Length);
            Console.ReadKey();
        }
    }
}
