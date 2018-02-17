using System;
using System.IO;

namespace DirectoryFIleInfo
{
    class MainClass
    {   
        static void EmptySpaces(int level)
        {
            for (int i = 0; i < level * 4; i++)
                Console.Write(" ");
        }
        static void List(string way, int level)
        {
            DirectoryInfo directory = new DirectoryInfo(way);
            // Console.WriteLine(directory.FullName);


            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo file in files)
            {
                EmptySpaces(level);
                Console.WriteLine(file.Name);

            }
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (DirectoryInfo d in directories)
            {   
                EmptySpaces(level);
                Console.WriteLine(d.Name);
                List(d.FullName, level+1);

            }
        }


        public static void Main(string[] args)
        {
            List(@"/Users/macbook/Documents/PP1", 0);


            Console.ReadKey();
                
          

        }
    }
}
