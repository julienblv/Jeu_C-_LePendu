class Point_Entree_Main
{
    static void Main(string[] agrs)
    {
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
        while (gameisOn == true)
        {
            string ActionMenu = Console.ReadLine();
            int ActionMenuParsed = Convert.ToInt32(ActionMenu);

            switch (ActionMenuParsed)
            {
                case 1:
                    Jouer();
                    Rejouer();
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

        static void Jouer()
        {
            Partie partie = new Partie();
            partie.Commencer();
        }

        static void Rejouer()
        {
            //if le joueur veut rejouer alors ...
            //else break ou gameisOn = false;
        }

        static void Regles()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Julien\Desktop\Jeu_C#_LePendu\Regles.txt");
        
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Appuyez sur une touche pour sortir.");
        }

        static void Quitter()
        {
            Console.WriteLine("Merci quand même d'avoir ouvert appuyez sur n'importe quel touche pour sortir");
            System.Console.ReadKey();
        }

    
}