public class GestionnaireJeu
{
    Partie partie;
    Affichage afficherG;
    public GestionnaireJeu()
    {
        GameIntro();
    }
        public void NouvellePartie()
        {
            partie = new Partie(this,partie.Verif,partie.lettreSaisi); //il se prends lui meme donc this
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
            Affichage afficher = new Affichage();
            afficher.ReglesA();
        }

        public void Quitter()
        {
            Console.WriteLine("Merci quand même d'avoir ouvert");
            Environment.Exit(0);
        }


        public void GameIntro()
        { 

            Affichage afficher = new Affichage();
            afficher.EcranTitre();

            bool gameisOn = true;
            while (gameisOn == true)
            {
                string ActionMenu = Console.ReadLine();
                int ActionMenuParsed = Convert.ToInt32(ActionMenu);

                switch (ActionMenuParsed)
                {
                    case 1:
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
                        afficher.ErreurChiffre();
                        break;
                        

                }
            }
        }

    
}