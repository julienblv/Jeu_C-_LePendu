class Partie
{
    public List<string>Joueur = new List<string>();
    

    public int ToursJ1;
    public int ToursJ2;
    
    


    Mot mot ;
    static string motAdevinerP;
    static int VieP = 8;

    public string lettreP; //lettreP est un equivalent de lettresaisie de la classe Mot pour pas me paumer
    
    
    
    

    

    public List<string> Potence = new List<string>();

    public void Commencer()
    {
        lettreP=String.Empty;

        Console.WriteLine("Bienvenue à toi ! Saisies le nom du Joueur 1");
        Joueur.Add(Console.ReadLine());//Joueur[0]
        Console.WriteLine("Merci ! Maintenant, saisies le nom du Joueur 2");
        Joueur.Add(Console.ReadLine()); //Joueur[1]
        QuiCommences();
        faireDeviner();
        //potence();
        //partieGagnée();
    }

    public void QuiCommences()
    {
        Random rnd = new Random();
        int chiffreAleatoiire = rnd.Next(10);
        if (chiffreAleatoiire %2 == 0)
        {
           Console.WriteLine(Joueur[0]+" C'est à vous de commençer !");
           ToursJ1 ++;
        }
        else
        {
            Console.WriteLine(Joueur[1]+" C'est à vous de commençer !");
            ToursJ2 ++;
        }
    }

    public void faireDeviner()
    {
        Console.WriteLine(" Saisissez le mot à faire deviner : ");
        motAdevinerP = Console.ReadLine();

        //déclares mon constructeur
        Mot mot = new Mot(motAdevinerP,VieP);
        lettreP = mot.GetLettreSaisie(lettreP);


        while(VieP!=0) // est prise une premiere fois mais redevient nulle ici
        {
            mot.VerificationMot();
          

            if(Potence.Contains(lettreP))
            {
                Console.WriteLine("Oups vous avez déjà mis cette lettre !");
                lettreP = "";

            }
            else
            {
                afficherPotenceSeRemplit();
            }
           
        }

        if(VieP==0)
        {
            partiePerdue();
        }
        
    }

    public void partieGagnée()
    {
        mot.MotCorrect();
    }

    public void partiePerdue()
    {
        mot.MotIncorrect();
    }

    public void afficherPotenceVide()
    {
        for(int i =0; i < motAdevinerP.Length; i++)
        {
            Potence.Add("_");  
        }
         Console.WriteLine(string.Join(" ", Potence));
    }  

    public void afficherPotenceSeRemplit()
    {

        // remplace les lettres dans la potence
            for (int i = 0; i < motAdevinerP.Length; i++)
            {
                Console.WriteLine("voici la lettre" + lettreP[0]); // ceci est null
                

                if(motAdevinerP.Contains(lettreP[i])) //lettreP est null
                {
                    
                    string ichar = Convert.ToString(lettreP[i]);
                    Potence.Add(ichar);
                    Console.WriteLine(string.Join(" ", Potence));
                }
                else
                {
                    Potence.Add("_");
                    Console.WriteLine(string.Join(" ", Potence));
                }
            }
    }
}

