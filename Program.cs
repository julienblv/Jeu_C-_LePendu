using System.Collections.Generic;
class Program

{
// Liste pour les joueurs
    public List<string>Joueur = new List<string>(2);
    int count = 1;


// utile pour quand le joueur commences
    static string joueur_start;
    static int starterval;
    static int  StartPlayer;
    static int toursPlayer;

// utile pour la class du pendu
    public string motPlayer;
    static string lettreSaisie;
    static List<char> tableau2LettresUp = new List<char>();
    int compteurVie;


    public void Update()
    {
        
        Joueur.Add("J1");
        Joueur.Add("J2");

            // Write to console \n = passage a la ligne
        Console.WriteLine("La partie va bientot commençer, saisissez le nom du joueur 1 : "); 
        EntreeJoueurs();
        Console.WriteLine("ensuite le 2e : ");
        EntreeJoueurs();
            

        Console.WriteLine(" Patientez un instant le jeu détermines qui va començer");
        usrStart();

            if(toursPlayer != 0)
            {
                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2();
                MotEntre();
                Mdvn.TableauDuMot(motPlayer,tableau2LettresUp);
                Mdvn.MotCoupé();
                Mdvn.lettredevinée();

                //toursPlayer++;
            
            }
            
            else
            {
                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2();
                MotEntre();
                Mdvn.TableauDuMot(motPlayer,tableau2LettresUp);
                Mdvn.MotCoupé();
                Mdvn.lettredevinée();

                //toursPlayer++;
                
            }

    }


    public string EntreeJoueurs()
    {
        string read= Console.ReadLine();
        Joueur[count] = read;
        count++;

        return Joueur[count];
    }


    public void usrStart()
    {
        Random rnd = new Random();
        starterval = rnd.Next(10);

        if(starterval%2 == 0)
        {
            joueur_start = Joueur[2];
            StartPlayer = 2;
            
        }
        else
        {
            joueur_start = Joueur[1];
            StartPlayer = 1;
            
        }
    }


    public void MotEntre()
    {

        Console.WriteLine("Saisissez vôtre mot "+Joueur[count]+" : ");
        motPlayer = Console.ReadLine();
    }

    
}