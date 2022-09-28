using System.Collections.Generic;
class Program

{
// Liste pour les joueurs
    public List<string>Joueur = new List<string>();
    int count = 0;


// utile pour quand le joueur commences
    static string joueur_start;
    static int starterval;
    static int  StartPlayer;
    static int toursPlayer;

// utile pour la class du pendu
    public string motPlayer;
    static string lettreSaisie;
    static List<char> tableau2LettresUp = new List<char>(); // <------ peut être pb ici
    int compteurVie;


    public void Update()
    {
        
        Joueur.Insert(0,"J1"); 
        Joueur.Insert(1,"J2");
        Joueur.Insert(2,"Invalid"); 
        

        foreach(string item in Joueur) {
            Console.WriteLine(item);
        }

            // Write to console \n = passage a la ligne
        Console.WriteLine("La partie va bientot commençer, saisissez le nom du joueur 1 : "); 
            EntreeJoueurs();
        Console.WriteLine("ensuite le 2e : ");
            EntreeJoueurs();
        Console.WriteLine(" Patientez un instant le jeu détermines qui va començer");
            usrStart();

            Class_mot_LePendu Mot = new Class_mot_LePendu(/* 2 */); //appel du contructeur  le 2 marches aussi car surcharge de constructeurs
            Mot.chiffre = 2;

            if(toursPlayer != 0)
            {
                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2(Mot); //tant qu'il y a la ref on peut yu accéder

                MotEntre();
                Mdvn.TableauDuMot(motPlayer,tableau2LettresUp);
                Mdvn.MotCoupé(); //pb ici
                Mdvn.lettredevinée();

                //toursPlayer++;
            
            }
            
            else
            {

                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2(Mot);
                MotEntre();
                
                Mdvn.TableauDuMot(motPlayer,tableau2LettresUp);
                Mdvn.MotCoupé();
                Mdvn.lettredevinée();

                //toursPlayer++;
                
            }

    }


    public string EntreeJoueurs()
    {
        string nvjoueur = Console.ReadLine();

        Joueur.Insert(count,nvjoueur);
        count++;

        return Joueur[count];
    }


    public void usrStart()
    {
        Random rnd = new Random();
        starterval = rnd.Next(10);

        if(starterval%2 == 0)
        {
            joueur_start = Joueur[1];
            StartPlayer = 2;
            
        }
        else
        {
            joueur_start = Joueur[0];
            StartPlayer = 1;
            
        }
    }


    public void MotEntre()
    {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
        Console.WriteLine("Saisissez vôtre mot "+ Joueur[count] +" : ");
        motPlayer = Console.ReadLine();
    }

    
}