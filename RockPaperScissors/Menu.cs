using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Pokemon
{
    internal class Menu
    {
        public string Examples;
        public string[] Options;
        public int Select;

        public Menu(int select, string[] options, string examples)
        {
            Options = options;
            Examples = examples;
            Select = 0;
        }

        public void ShowOptions()
        {
            WriteLine(Examples);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOptions = Options[i];
                string foran;
                if (i == Select)
                {
                    foran = @"
";
                    ForegroundColor = ConsoleColor.DarkRed;
                  
                }
                else
                {

                    foran = " ";
                    ForegroundColor = ConsoleColor.White;

                }

                WriteLine($"{foran}{currentOptions}");
            }
            ResetColor();
        }

        public static void startMenu()
        {

            string foran = "";
            string[] options = { @"

                                                                                     ██████╗ ██╗      █████╗ ██╗   ██╗
                                                                                     ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝
                                                                                     ██████╔╝██║     ███████║ ╚████╔╝ 
                                                                                     ██╔═══╝ ██║     ██╔══██║  ╚██╔╝  
                                                                                     ██║     ███████╗██║  ██║   ██║   
                                                                                     ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   
                                 

", @"
                                                                                 █████╗ ██████╗  ██████╗ ██╗   ██╗████████╗
                                                                                 ██╔══██╗██╔══██╗██╔═══██╗██║   ██║╚══██╔══╝
                                                                                 ███████║██████╔╝██║   ██║██║   ██║   ██║   
                                                                                 ██╔══██║██╔══██╗██║   ██║██║   ██║   ██║   
                                                                                 ██║  ██║██████╔╝╚██████╔╝╚██████╔╝   ██║   
                                                                                 ╚═╝  ╚═╝╚═════╝  ╚═════╝  ╚═════╝    ╚═╝     
 
                                           
", @"

                                                                                        ███████╗██╗  ██╗██╗████████╗
                                                                                        ██╔════╝╚██╗██╔╝██║╚══██╔══╝
                                                                                        █████╗   ╚███╔╝ ██║   ██║   
                                                                                        ██╔══╝   ██╔██╗ ██║   ██║   
                                                                                        ███████╗██╔╝ ██╗██║   ██║   
                                                                                        ╚══════╝╚═╝  ╚═╝╚═╝   ╚═╝                                                                                 
                                                                                  
                                                                

" };
            Menu mainMenu1 = new Menu(0, options, foran);
            int Select = mainMenu1.Run();
            mainMenu1.ShowOptions();
            switch (Select)
            {
                case 0:
                    Clear();
                    StartGame1();
                  

                    break;
                case 1:
                    Clear();
                    About();
                    startMenu();
                    break;

                case 2:
                    Clear();
                    Exit();
                    break;            
            }
            Clear();
        }

        public static void Exit()
        {
            WriteLine("Press any key to exit.");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static void About()
        {
            Clear();
            WriteLine("Made by Tommy and Kamil.");
            ReadKey(true);
            startMenu();
        }

        public static void StartGame1()
        {
            Clear();
            Logo();
            ReadKey(true);
        }

        public int Run()
        {
            ConsoleKey pressed;
            do
            {
                Clear();
                ShowOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                pressed = keyInfo.Key;
                if (pressed == ConsoleKey.UpArrow)
                {
                    Select--;
                    if (Select == -1)
                    {
                        Select = Options.Length - 1;
                    }

                }
                else if (pressed == ConsoleKey.DownArrow)
                {
                    Select++;
                    if (Select == Options.Length)
                    {
                        Select = 0;
                    }
                }
            } while (pressed != ConsoleKey.Enter);

            return Select;
        }
        public static void Logo()
        {
            ForegroundColor = ConsoleColor.Blue;
            //CursorVisible = false;
           WriteLine( @"             





                                                                                                                      ,'\
                                                                                        _.----.        ____         ,'  _\   ___    ___     ____
                                                                                    _,-'       `.     |    |  /`.   \,-'    |   \  /   |   |    \  |`.
                                                                                    \      __    \    '-.  | /   `.  ___    |    \/    |   '-.   \ |  |
                                                                                     \.    \ \   |  __  |  |/    ,','_  `.  |          | __  |    \|  |
                                                                                       \    \/   /,' _`.|      ,' / / / /   |          ,' _`.|     |  |
                                                                                        \     ,-'/  /   \    ,'   | \/ / ,`.|         /  /   \  |     |
                                                                                         \    \ |   \_/  |   `-.  \    `'  /|  |    ||   \_/  | |\    |
                                                                                          \    \ \      /       `-.`.___,-' |  |\  /| \      /  | |   |
                                                                                           \    \ `.__,'|  |`-._    `|      |__| \/ |  `.__,'|  | |   |
                                                                                            \_.-'       |__|    `-._ |              '-.|     '-.| |   |
                                                                                                                    `'                            '-._|"
);
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"                                                                                            
                                                                                                            >>>Press ENTER to start<<<");
                ResetColor();
        }
    }
}






