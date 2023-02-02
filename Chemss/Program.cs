using System;

namespace Chemss
{
    class Program
    {
        public static string[,] board = new string[8,8];
        
        public static void Main(string[] args)
        {
            clboard.initBoard();
            clboard.outputboard();
            Console.WriteLine("\nWelcome to Chemss! A lightweight, console version of Chess. This is a work in progress, so please be patient! \nPlease type 'help' for a list of commands. \n");
            string input = Console.ReadLine();
            getCommand(input);
        }
        
        public static void getCommand(string input)
        {
            string usrinput;
            switch (input)
            {
                case "help":
                    reset();
                    Console.WriteLine("\nhelp - Displays this message. \nelo - Sets the ELO (Chess skill rating) of the CPU opponent. \nplay - Starts a game of chess. \nhow - Displays the rules of chess. \nexit - Exits the program. \n");
                    usrinput = Console.ReadLine();
                    getCommand(usrinput);
                    break;
                case "elo":
                    reset();
                    //
                    break;
                case "play":
                    reset();
                    game.getusermove();
                    //
                    break;
                case "how":
                    reset();
                    Console.WriteLine("Chess is a two-player strategy game played on a checkered board. The objective is to checkmate the opponent's king, \nwhich means the king is in a position to be captured (in check) and there is no way to move the king \nout of capture (mate).");
                    Console.WriteLine("\nEach player starts with 16 pieces: one king, one queen, two rooks, two knights, two bishops, and eight pawns. The \npieces move in specific ways: the king moves one square in any direction, the queen can move in any \ndirection any number of squares, the rook can move horizontally or vertically any number of squares, the \nbishop can move diagonally any number of squares, the knight moves in an L-shape, and the \npawns move forward one square but capture diagonally.");
                    usrinput = Console.ReadLine();
                    getCommand(usrinput);
                    //
                    break;
                case "exit":
                    reset();
                    Environment.Exit(0);
                    break;
                case "random":
                    reset();
                    break;
                default:
                    reset();
                    Console.WriteLine("Invalid Command: '" + input + "'. Please type 'help' for a list of commands. \n");
                    usrinput = Console.ReadLine();
                    getCommand(usrinput);
                    break;
            }
        }

        public static void reset()
        {
            Console.Clear();
            clboard.outputboard();
        }
    }
}