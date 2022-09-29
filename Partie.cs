class Partie
{
    public List<string>Joueur = new List<string>();
    

    public int ToursJ1;
    public int ToursJ2;
    
    


    Mot mot ;
    static string motAdevinerP;
    static int VieP = 8;
    
    
    

    

    public List<string> Potence = new List<string>();

    public void Commencer()
    {
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


        while(VieP!=0)
        {
            mot.VerificationMot();
          

            if(Potence.Contains(mot.lettreSaisi))
            {
                Console.WriteLine("Oups vous avez déjà mis cette lettre !");
                mot.lettreSaisi = "";

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
                if (mot.motAdevinerM.Contains(mot.lettreSaisi[i])) //un des deux est null
                {
                    
                    string ichar = Convert.ToString(mot.lettreSaisi[i]);
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

