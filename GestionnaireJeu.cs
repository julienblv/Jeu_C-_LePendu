public class GestionnaireJeu
{
    public Partie partie;
    public Affichage afficherG;

//les deux joueurs
  public List<Joueur> joueurs = new List<Joueur>();

  public Joueur joueur1
  {
    get
    {
        return joueurs[0];
    }
  }

    public Joueur joueur2
  {
    get
    {
        return joueurs[1];
    }
  }

    public GestionnaireJeu()
    {
        afficherG = new Affichage(this);
        GameIntro();
    }

        public void NouvellePartie()
        {
            partie = new Partie(this); //il se prends lui meme donc this
            partie.Commencer();
            afficherG.AfficherPotenceGraph();
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
            afficherG.PenduIcon();
            afficherG.espace();
            afficherG.ReglesA();
           
        }

        public void Quitter()
        {
            afficherG.PenduIcon();
            afficherG.espace();
            Console.WriteLine("Merci quand même d'avoir ouvert");
            Environment.Exit(0);
        }


    public void IdentificationJoueurs()
    {
        afficherG.PenduIcon();
        joueurs.Clear(); //efface la liste pour être sur qu'elle est vide
        for(int i=0; i<2 ;i++)
        {
            afficherG.espace();
            Console.WriteLine("Joueur " + (i+1) + " Identifiez vous");
            string nom = Console.ReadLine();
            Joueur joueur = new Joueur(nom);
            joueurs.Add(joueur);
            Thread.Sleep(1000);
            Console.WriteLine(joueur.nom + " Sera le joueur " + (i+1));
        }

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
                        IdentificationJoueurs();
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