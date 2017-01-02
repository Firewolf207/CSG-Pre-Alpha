using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace CSG
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Console.WriteLine("CSG (2017-2018) All Rights Reserved.");
            for (; true; )
            {
                Console.WriteLine("");
                Console.Write("CSG:>");
                string enter = Console.ReadLine();
                if (enter == "HELP" || enter == "help")
                {
                    Console.WriteLine("");
                    Console.WriteLine("all commands found when typing CMDS");
                    Console.WriteLine("if you get errors try installing getting a newer version of C#");
                }
                else if (enter == "CMDS" || enter == "cmds")
                {
                   
                    Console.WriteLine("\n HELP = Help for CSG \n CMDS = Shows Commands \n TIME = shows current time \n NOTEPAD = Enter CSG notepad \n EXITT = exit CSG notepad \n SETTINGS");
                }
                else if (enter == "TIME" || enter == "time")
                {
                    DateTime date = DateTime.Now;
                    Console.WriteLine("\n {0}", date);
                }
                else if (enter == "NOTEPAD" || enter == "notepad")
                {
                    for (; true; )
                    {
                        string a = Console.ReadLine();
                        if (a == "EXITT" || a == "exitt") break;
                        else if (a == "exit" || a == "EXIT")
                        {
                            Console.WriteLine("\n TYPE IN EXITT NOT EXIT");
                        }
                    }
                }
                else if (enter == "SETTINGS" || enter == "settings")
                {
                    Console.WriteLine("\n Coming Soon");
                }
            }
        }
    }
}
