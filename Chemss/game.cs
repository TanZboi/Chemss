namespace Chemss;

public class game
{
    public static void start()
    {
        clboard.outputboard();
        Console.ReadLine();
    }

    public static void getusermove()
    {
        Program.reset();
        Console.WriteLine("Which piece are you moving?. (eg. 'e2') \n");
        string frominput = Console.ReadLine();

        frominput = frominput.Replace('a', '0');
        frominput = frominput.Replace('b', '1');
        frominput = frominput.Replace('c', '2');
        frominput = frominput.Replace('d', '3');
        frominput = frominput.Replace('e', '4');
        frominput = frominput.Replace('f', '5');
        frominput = frominput.Replace('g', '6');
        frominput = frominput.Replace('h', '7');
        
        int fromx = Convert.ToInt32(frominput[0]);
        int fromy = Convert.ToInt32(frominput[1]);
        

        string frompeice = Program.board[fromx, fromy];
        
        Console.WriteLine(frompeice);
        
        
        if (frompeice == " ")
        {
            Console.WriteLine("Invalid move. Please try again. \n");
            getusermove();
        }
        else if (frompeice[0] == 'B')
        {
            Console.WriteLine("Invalid move. Please try again. \n");
            getusermove();
            //
        }
        
        Console.WriteLine("Moving piece: " + frompeice + " to which square?\n");
        string toinput = Console.ReadLine();
        
        toinput = toinput.Replace('a', '0');
        toinput = toinput.Replace('b', '1');
        toinput = toinput.Replace('c', '2');
        toinput = toinput.Replace('d', '3');
        toinput = toinput.Replace('e', '4');
        toinput = toinput.Replace('f', '5');
        toinput = toinput.Replace('g', '6');
        toinput = toinput.Replace('h', '7');
        
    }
}