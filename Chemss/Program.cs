using System;

namespace Chemss
{
    class Program
    {
        public static string[,] board = new string[8,8];
        
        static void Main(string[] args)
        {
            outputboard();
            Console.WriteLine("Welcome to Chemss! A lightweight, console version of Chess. This is a work in progress, so please be patient! \nPlease type 'help' for a list of commands. \n");
            string input = Console.ReadLine();
            getCommand(input);
        }
        
        static void getCommand(string input)
        {
            string usrinput;
            switch (input)
            {
                case "help":
                    Console.WriteLine("\nhelp - Displays this message. \nelo - Sets the ELO (Chess skill rating) of the CPU opponent. \nplay - Starts a game of chess. \nhow - Displays the rules of chess. \nexit - Exits the program. \n");
                    usrinput = Console.ReadLine();
                    getCommand(usrinput);
                    break;
                case "elo":
                    //
                    break;
                case "play":
                    //
                    break;
                case "how":
                    //
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid command. Please type 'help' for a list of commands. What a sausage you are.\n");
                    usrinput = Console.ReadLine();
                    getCommand(usrinput);
                    break;
            }
        }
        
        static void loadBoard()
        {
            //load the board with the pieces
            board[0,0] = "1R";
            board[0,1] = "1N";
            board[0,2] = "1B";
            board[0,3] = "1Q";
            board[0,4] = "1K";
            board[0,5] = "1B";
            board[0,6] = "1N";
            board[0,7] = "1R";
            board[1,0] = "1P";
            board[1,1] = "1P";
            board[1,2] = "1P";
            board[1,3] = "1P";
            board[1,4] = "1P";
            board[1,5] = "1P";
            board[1,6] = "1P";
            board[1,7] = "1P";
            
            board[6,0] = "2R";
            board[6,1] = "2N";
            board[6,2] = "2B";
            board[6,3] = "2Q";
            board[6,4] = "2K";
            board[6,5] = "2B";
            board[6,6] = "2N";
            board[6,7] = "2R";
            board[6,0] = "2P";
            board[6,1] = "2P";
            board[6,2] = "2P";
            board[6,3] = "2P";
            board[6,4] = "2P";
            board[6,5] = "2P";
            board[6,6] = "2P";
            board[6,7] = "2P";
        }

        static void outputboard()
        {
            string Boardverytop = " _________________________________________________";
            string Boardtop =   " |_____|_____|_____|_____|_____|_____|_____|_____|";
            string Boardline8 = "8|     |     |     |     |     |     |     |     |";
            string Boardline7 = "7|     |     |     |     |     |     |     |     |";
            string Boardline6 = "6|     |     |     |     |     |     |     |     |";
            string Boardline5 = "5|     |     |     |     |     |     |     |     |";
            string Boardline4 = "4|     |     |     |     |     |     |     |     |";
            string Boardline3 = "3|     |     |     |     |     |     |     |     |";
            string Boardline2 = "2|     |     |     |     |     |     |     |     |";
            string Boardline1 = "1|     |     |     |     |     |     |     |     |";
            String Boardbottom = "    a     b     c     d     e     f     g     h";


            Console.WriteLine(Boardverytop + "\n" + Boardline8 + "\n" + Boardtop + "\n" + Boardline7 + "\n" + Boardtop + "\n" + Boardline6 + "\n" + Boardtop + "\n" + Boardline5 + "\n" + Boardtop + "\n" + Boardline4 + "\n" + Boardtop + "\n" + Boardline3 + "\n" + Boardtop + "\n" + Boardline2 + "\n" + Boardtop + "\n" + Boardline1 + "\n" + Boardtop + "\n" + Boardbottom);
        }
    }
}