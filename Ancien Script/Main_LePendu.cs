// Namespace Declaration
using System;

// Program start class
class Main_LePendu
{

    // Main begins program execution.
    static void Main(string[] agrs)
    {
        Program pgrm = new Program();
            // Write to console \n = passage a la ligne 
        Console.WriteLine("***************************");
        Console.WriteLine("***** le Jeu_du_Pendu *****");
        Console.WriteLine("***************************"); 
        Console.WriteLine("                           ");
        Console.WriteLine("           Start(1)        ");
        Console.WriteLine("                           ");
        Console.WriteLine("           Règles(2)       ");
        Console.WriteLine("                           ");
        Console.WriteLine("           Quitter(3)      ");
        Console.WriteLine("                           ");
        Console.WriteLine("Sasissez vôtre choix (1 à 3)");
        bool gameisOn = true;
        while(gameisOn == true)
        {
            string ActionMenu = Console.ReadLine();
            int ActionMenuParsed = Convert.ToInt32(ActionMenu);

                switch (ActionMenuParsed)
                {
                    case 1: 
                        Start();
                        break;
                    case 2:
                        Regles();
                        break;
                    case 3:
                        Quitter();
                        gameisOn = false;
                        break;
                        
                }
        }
    }

    static void Start()
    {
        Program pgrm = new Program();
        pgrm.Update();
    }

    static void Regles()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Julien\Desktop\Jeu_C#_LePendu\Regles.txt");
        
        foreach (string line in lines)
        {
             Console.WriteLine("\t" + line);
        }

        Console.WriteLine("Appuyez sur une touche pour sortir.");
        // System.Console.ReadKey();
        
    }

    static void Quitter()
    {
        Console.WriteLine("Merci quand même d'avoir ouvert appuyez sur n'importe quel touche pour sortir");
        System.Console.ReadKey();
        
    }
}