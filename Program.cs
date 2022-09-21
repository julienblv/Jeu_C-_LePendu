class Program
{
    static string joueur1;
    static string joueur2;
    static string joueur_start;
    static int starterval;
    static int  StartP;
    static int toursP2;
    static int toursP1;
    public string motJ1;
    public string motJ2;
    static string lettreSaisie;
    static char lettreSaisie2;

    int compteurVie;
    public void Update()
    {
            // Write to console \n = passage a la ligne
            Console.WriteLine("La partie va bientot commençer, saisissez le nom du joueur 1 : "); 
            EntreeJoueur1();
            Console.WriteLine("ensuite le 2e : "); 
            EntreeJoueur2();

            Console.WriteLine(" Patientez un instant le jeu détermines qui va començer");
            usrStart();

            if(toursP1 != 0)
            {
                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2();
                MotEntreJ1();
                Mdvn.TableauDuMot(motJ1);
                Mdvn.MotCoupé();
            
            }
            
            else
            {
                Class_mot_LePendu_2 Mdvn = new Class_mot_LePendu_2();
                MotEntreJ2();
                Mdvn.TableauDuMot(motJ1);
                Mdvn.MotCoupé();

                
            }

    }


    static string EntreeJoueur1()
    {
        joueur1 = Console.ReadLine();

        return joueur1;
    }


    static string EntreeJoueur2()
    {
        joueur2 = Console.ReadLine();

        return joueur2;
    }


    static void usrStart()
    {
        Random rnd = new Random();
        starterval = rnd.Next(10);

        if(starterval%2 == 0)
        {
            joueur_start = joueur2;
            StartP = 2;
            
        }
        else
        {
            joueur_start = joueur1;
            StartP = 1;
            
        }
    }


    public void MotEntreJ1()
    {
        Console.WriteLine("Saisissez vôtre mot "+joueur1+" : ");
        motJ1 = Console.ReadLine();
    }

    public void MotEntreJ2()
    {
        Console.WriteLine("Saisissez vôtre mot "+joueur2+" : ");
        motJ2 = Console.ReadLine();
    }

    
}