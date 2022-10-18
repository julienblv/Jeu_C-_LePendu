public class Partie
{
    public List<string> Joueur = new List<string>();

    public List<string> lettreSaisi = new List<string>();

    string motAdevinerP;
    public int ToursJ1;
    public int ToursJ2;


    public string Verif;

    public Mot mot;
    int VieP = 9;
    GestionnaireJeu gestion;


    public Partie(GestionnaireJeu gestion)
    {
        this.gestion = gestion;
    }



    public List<string> Potence = new List<string>();

    public void Commencer()
    {
        

        Console.WriteLine("Bienvenue à toi ! Saisies le nom du Joueur 1");
        Joueur.Add(Console.ReadLine());//Joueur[0]
        Console.WriteLine("Merci ! Maintenant, saisies le nom du Joueur 2");
        Joueur.Add(Console.ReadLine()); //Joueur[1]
        gestion.afficherG.Clear();
        QuiCommences();
        BouclePrincipale();



        //partieGagnée();
    }

    public void QuiCommences()
    {
        Random rnd = new Random();
        int chiffreAleatoiire = rnd.Next(10);
        if (chiffreAleatoiire % 2 == 0)
        {
            Console.WriteLine(Joueur[0] + " C'est à vous de commençer !");
            ToursJ1++;
        }
        else
        {
            Console.WriteLine(Joueur[1] + " C'est à vous de commençer !");
            ToursJ2++;
        }
    }

    public void BouclePrincipale()
    {
        gestion.afficherG.Clear();
        Console.WriteLine(" Saisissez le mot à faire deviner : ");
        motAdevinerP = Console.ReadLine(); //nv mot a devinerp local

        int verifChiffre = 0;
        while (verifChiffre == 0)
        {
            int c; // valeur c car compares

            if (int.TryParse(motAdevinerP, out c))// comparaison si la valeur est bien un strinfg
            {
                gestion.afficherG.ErreurSaisieChiffre();
                motAdevinerP = Console.ReadLine();
                verifChiffre = 1;
            }
            else
            {
                verifChiffre = 1;
            }
        }

        //déclares mon constructeur
        mot = new Mot(motAdevinerP, VieP,gestion); // ne pas remettre Mot avant mot sinon Local



        while (VieP != 0) // est prise une premiere fois mais redevient
        {
            mot.VerificationMot();

            gestion.afficherG.afficherPotenceSeRemplit();

            if (mot.VieM == 1)
            {
                partiePerdue();
                break;
            }

            if (motAdevinerP == Verif)
            {
                partieGagnée();
                VieP = 0;

            }


        }
        PartieTerminee();



    }

    public void partieGagnée()
    {
        gestion.afficherG.MotCorrect(motAdevinerP);
    }
    public void partiePerdue()
    {
        gestion.afficherG.MotIncorrect(motAdevinerP);
    }
    public void PartieTerminee()
    {
        gestion.DemanderRejouer();
    }

    
}

