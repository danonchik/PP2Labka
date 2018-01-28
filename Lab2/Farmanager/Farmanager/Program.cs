using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmanager
{
    class Program
    { 
        static void ShowFolderContent(DirectoryInfo cur,int pos)
        {
            FileSystemInfo[] all = cur.GetFileSystemInfos();
            for(int i = 0; i < all.Length; i++)
            {
                if (i == pos)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else Console.BackgroundColor = ConsoleColor.White;
                if (all[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(all[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\777\Desktop\labka");
            while (true)
            {
                Console.Clear();
                ShowFolderContent(dir, pos);
                ConsoleKeyInfo klav = Console.ReadKey();
                switch (klav.Key)
                {
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                       
                            pos = dir.GetFileSystemInfos().Length - 1;
                            break;
                        
                       
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos>dir.GetFileSystemInfos().Length)
                        {
                            pos = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                        }
            
                         if (f.GetType() == typeof(FileInfo))
                        {
                            StreamReader k = new StreamReader(f.FullName);
                            string s = k.ReadToEnd();
                            Console.Clear();
                            Console.WriteLine(s);
                            Console.ReadKey();
                        }
                        break;

                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                        
                    
                            
                }

            }

        }
    }
}
