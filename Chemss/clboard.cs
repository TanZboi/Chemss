namespace Chemss;

public class clboard
{
    public static void outputboard()
    {
        string Boardverytop = " _________________________________________________";
        string Boardtop =   " |_____|_____|_____|_____|_____|_____|_____|_____|";
        string Boardline7 = "8| " + Program.board[6,0] + "  | " + Program.board[6,1] + "  | " + Program.board[6,2] + "  | " + Program.board[6,3] + "  | " + Program.board[6,4] + "  | " + Program.board[6,5] + "  | " + Program.board[6,6] + "  | " + Program.board[6,7] + "  |";
        string Boardline6 = "7| " + Program.board[7,0] + "  | " + Program.board[7,1] + "  | " + Program.board[7,2] + "  | " + Program.board[7,3] + "  | " + Program.board[7,4] + "  | " + Program.board[7,5] + "  | " + Program.board[7,6] + "  | " + Program.board[7,7] + "  |";
        string Boardline5 = "6| " + Program.board[5,0] + "  | " + Program.board[5,1] + "  | " + Program.board[5,2] + "  | " + Program.board[5,3] + "  | " + Program.board[5,4] + "  | " + Program.board[5,5] + "  | " + Program.board[5,6] + "  | " + Program.board[5,7] + "  |";
        string Boardline4 = "5| " + Program.board[4,0] + "  | " + Program.board[4,1] + "  | " + Program.board[4,2] + "  | " + Program.board[4,3] + "  | " + Program.board[4,4] + "  | " + Program.board[4,5] + "  | " + Program.board[4,6] + "  | " + Program.board[4,7] + "  |";
        string Boardline3 = "4| " + Program.board[3,0] + "  | " + Program.board[3,1] + "  | " + Program.board[3,2] + "  | " + Program.board[3,3] + "  | " + Program.board[3,4] + "  | " + Program.board[3,5] + "  | " + Program.board[3,6] + "  | " + Program.board[3,7] + "  |";
        string Boardline2 = "3| " + Program.board[2,0] + "  | " + Program.board[2,1] + "  | " + Program.board[2,2] + "  | " + Program.board[2,3] + "  | " + Program.board[2,4] + "  | " + Program.board[2,5] + "  | " + Program.board[2,6] + "  | " + Program.board[2,7] + "  |";
        string Boardline1 = "2| " + Program.board[1,0] + "  | " + Program.board[1,1] + "  | " + Program.board[1,2] + "  | " + Program.board[1,3] + "  | " + Program.board[1,4] + "  | " + Program.board[1,5] + "  | " + Program.board[1,6] + "  | " + Program.board[1,7] + "  |";
        string Boardline0 = "1| " + Program.board[0,0] + "  | " + Program.board[0,1] + "  | " + Program.board[0,2] + "  | " + Program.board[0,3] + "  | " + Program.board[0,4] + "  | " + Program.board[0,5] + "  | " + Program.board[0,6] + "  | " + Program.board[0,7] + "  |";
        String Boardbottom = "    a     b     c     d     e     f     g     h";


        Console.WriteLine(Boardverytop + "\n" + Boardline7 + "\n" + Boardtop + "\n" + Boardline6 + "\n" + Boardtop + "\n" + Boardline5 + "\n" + Boardtop + "\n" + Boardline4 + "\n" + Boardtop + "\n" + Boardline3 + "\n" + Boardtop + "\n" + Boardline2 + "\n" + Boardtop + "\n" + Boardline1 + "\n" + Boardtop + "\n" + Boardline0 + "\n" + Boardtop + "\n" + Boardbottom);
    }
    
    public static void initBoard()
    {
        //load the board with the pieces
        Program.board[0,0] = "WR";
        Program.board[0,1] = "WN";
        Program.board[0,2] = "WB";
        Program.board[0,3] = "WQ";
        Program.board[0,4] = "WK";
        Program.board[0,5] = "WB";
        Program.board[0,6] = "WN";
        Program.board[0,7] = "WR";
        Program.board[1,0] = "WP";
        Program.board[1,1] = "WP";
        Program.board[1,2] = "WP";
        Program.board[1,3] = "WP";
        Program.board[1,4] = "WP";
        Program.board[1,5] = "WP";
        Program.board[1,6] = "WP";
        Program.board[1,7] = "WP";
            
        Program.board[6,0] = "BR";
        Program.board[6,1] = "BN";
        Program.board[6,2] = "BB";
        Program.board[6,3] = "BQ";
        Program.board[6,4] = "BK";
        Program.board[6,5] = "BB";
        Program.board[6,6] = "BN";
        Program.board[6,7] = "BR";
        Program.board[7,0] = "BP";
        Program.board[7,1] = "BP";
        Program.board[7,2] = "BP";
        Program.board[7,3] = "BP";
        Program.board[7,4] = "BP";
        Program.board[7,5] = "BP";
        Program.board[7,6] = "BP";
        Program.board[7,7] = "BP";
            
        //set every other array node to '  '
        for (int i = 2; i < 6; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Program.board[i,j] = "  ";
            }
        }
    }
}