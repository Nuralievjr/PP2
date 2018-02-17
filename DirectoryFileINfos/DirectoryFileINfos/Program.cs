using System;
using System.IO;
namespace DirectoryFileINfos
{
    class MainClass
    {
        static void Ex3(string path)
         {
             DirectoryInfo d = new DirectoryInfo(path);
             FileInfo[] files = d.GetFiles();
             DirectoryInfo[] directories = d.GetDirectories();
 
             Console.WriteLine("Files:");
             foreach (FileInfo file in files)
             {
                 Console.WriteLine(file.Name);
             }
             Console.WriteLine("Directories:");
             foreach (DirectoryInfo directory in directories)
             {
                 Console.WriteLine(directory.Name);
             }
             Console.ReadKey();
         }
        
         static void Main(string[] args)
        {
            Ex3(@"/Users/macbook/Documents/PP1");
        }
    }
}
