public class GestionnaireJeu
{
    public Partie partie;
    public Affichage afficherG;

    public GestionnaireJeu()
    {
        afficherG = new Affichage(this);
        GameIntro();
    }

        public void NouvellePartie()
        {
            partie = new Partie(this); //il se prends lui meme donc this
            partie.Commencer();
        }

        public void DemanderRejouer()
        {
            afficherG.partieTermineeAff();
            string choixUser = Console.ReadLine();

            if (choixUser == "y")
            {
                NouvellePartie();
            }

            if (choixUser == "n")
            {
                Quitter();
            }
            else
            {
                afficherG.ErreurYN();
            }
        }

        public void Regles()
        {
            afficherG.ReglesA();
           
        }

        public void Quitter()
        {
            Console.WriteLine("Merci quand même d'avoir ouvert");
            Environment.Exit(0);
        }


        public void GameIntro()
        { 

            
            afficherG.EcranTitre();

            bool gameisOn = true;
            while (gameisOn == true)
            {
                string ActionMenu = Console.ReadLine();
                int ActionMenuParsed = Convert.ToInt32(ActionMenu);

                switch (ActionMenuParsed)
                {
                    case 1:
                        afficherG.Clear();
                        NouvellePartie();
                        
                        break;
                    case 2:
                        Regles();
                        break;
                    case 3:
                        Quitter();
                        gameisOn = false;
                        break;
                    case 4:
                        afficherG.ErreurChiffre();
                        break;
                        

                }
            }
        }

    
}