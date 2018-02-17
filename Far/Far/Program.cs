using System;
using System.IO;
namespace FarManager
{

    class MainClass
    {
        static int CONSOLE_SIZE = 20;
        static void ShowDirectoryInfo(DirectoryInfo directory, int cursor, int first)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            FileSystemInfo[] fss = directory.GetFileSystemInfos();
            int index = 0;
            foreach (FileSystemInfo f in fss)
            {
                if (index == cursor)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                else if (f.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                if (index >= first && index <= first + CONSOLE_SIZE)
                    Console.WriteLine(f.Name);
                index++;
            }
        }
        public static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"/Users/macbook/Documents/PP1");
            int first = 0;
            int cursor = 0;
            ShowDirectoryInfo(directory, cursor, first);
            int n = directory.GetFileSystemInfos().Length;
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    cursor--;
                    if (cursor < 0)
                    {
                        cursor = n - 1;
                        first = cursor - CONSOLE_SIZE;
                    }
                    if (cursor < first)
                    {
                        first--;
                    }
                }
                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    cursor++;
                    if (cursor == n)
                    {
                        cursor = 0;
                        first = 0;
                    }
                    if (cursor > first + CONSOLE_SIZE)
                    {
                        first++;
                    }
                }
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    if (directory.GetFileSystemInfos()[cursor].GetType() == typeof(DirectoryInfo))
                    {
                        directory = (DirectoryInfo)directory.GetFileSystemInfos()[cursor];
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                        first = 0;
                    }
                    else
                    {
                        StreamReader sr = new StreamReader(directory.GetFileSystemInfos()[cursor].FullName);
                        string s = sr.ReadToEnd();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        Console.WriteLine(s);
                        Console.ReadKey();
                    }

                }
                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    if (directory.Parent != null)
                    {
                        directory = directory.Parent;
                        cursor = 0;
                        n = directory.GetFileSystemInfos().Length;
                        first = 0;
                    }
                    else
                        break;
                }
                if (keyInfo.Key == ConsoleKey.D)
                {
                    if (directory.GetFileSystemInfos()[cursor].GetType() == typeof(FileInfo))
                    {
                        DirectoryInfo fordelete = new DirectoryInfo(directory.GetFileSystemInfos()[cursor].FullName);
                        System.IO.File.Delete(fordelete.FullName);
                    }

                }


                ShowDirectoryInfo(directory, cursor, first);
            }


        }
    }
}