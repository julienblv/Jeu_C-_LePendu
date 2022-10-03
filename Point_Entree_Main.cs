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
                case 4:
                    Console.WriteLine("Saisisez un chiffre svp");
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
            Console.WriteLine(" Partie terminée, voulez-vous rejouer ? (say 'y' for yes and 'n' for no) ");
            string choixUser = Console.ReadLine();

            if (choixUser == "y")
            {
                Partie partie = new Partie();
                partie.Commencer();
            }

            if (choixUser == "n")
            {
                Quitter();
            }
            else
            {
                Console.WriteLine(" Saisissez 'y' ou 'n' Svp ");
            }
        }

        static void Regles()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Julien\Desktop\Jeu_C#_LePendu\Regles.txt");
        
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Une fois avoir lu vous devrez relançer");
            Environment.Exit(0);

        }

        static void Quitter()
        {
            Console.WriteLine("Merci quand même d'avoir ouvert");
            Environment.Exit(0);
        }

    
}