public class Partie
{

    public List<string> lettreSaisi = new List<string>();

    string motAdevinerP;
    public int ToursJ1;
    public int ToursJ2;


    public string Verif;

    public Mot mot;
    int VieP = 11;
    GestionnaireJeu gestion;

    public Joueur joueurDevine //getter
    {
        get
        {
            int somme = gestion.joueur1.score + gestion.joueur2.score;
            bool joueur1Devine = (somme % 2 == 0);
            
            return (joueur1Devine)?gestion.joueur1:gestion.joueur2; //expression ternaire equivaut a if-else : stockable dans des variables
        }
    }

    public Joueur joueurFaitDevine
    {
        get
        {
            int somme = gestion.joueur1.score + gestion.joueur2.score;
            bool joueur1Devine = (somme % 2 != 0);
            
            return (joueur1Devine)?gestion.joueur1:gestion.joueur2; //expression ternaire equivaut a if-else : stockable dans des variables
        }
    }

    public Partie(GestionnaireJeu gestion)
    {
        this.gestion = gestion;
    }




    public List<string> Potence = new List<string>();

    public void Commencer()
    {
        gestion.afficherG.Clear();
        gestion.afficherG.PenduIcon();

        gestion.afficherG.espace();
        
        QuiCommences();
        BouclePrincipale();



        //partieGagnée();
    }

    public void QuiCommences()
    {
        gestion.afficherG.espace();
       
        gestion.afficherG.AfficherMessage(joueurDevine.nom + " C'est à vous de commençer !",ConsoleColor.Magenta);
    }

    public void BouclePrincipale()
    {
        gestion.afficherG.Clear(); 
        gestion.afficherG.PenduIcon();

        gestion.afficherG.espace();
        gestion.afficherG.AfficherMessage(joueurFaitDevine.nom + " Saisissez le mot à faire deviner : ",ConsoleColor.Yellow);
        motAdevinerP = Console.ReadLine(); //nv mot a devinerp local
        gestion.afficherG.Clear();
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

            Console.Clear(); // !!!!!!!! -> ne permets pas l'affichage de la potence sans réafficher le menu
            gestion.afficherG.PenduIcon();
            gestion.afficherG.AffichageLettreSaisie();
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

           // Console.WriteLine(gestion.afficherG.potenceAff[gestion.partie.mot.temp]); // erreur si mis


        }
        PartieTerminee();



    }

    public void partieGagnée()
    {
        gestion.afficherG.espace();
        joueurDevine.score++;
        gestion.afficherG.MotCorrect(motAdevinerP);
    }
    public void partiePerdue()
    {
        gestion.afficherG.espace();
        joueurFaitDevine.score++;
        gestion.afficherG.MotIncorrect(motAdevinerP);
    }
    public void PartieTerminee()
    {
        gestion.afficherG.espace();
        gestion.afficherG.AfficherJoeurs(); // affiche les scores
        gestion.DemanderRejouer();
    }

    
}

