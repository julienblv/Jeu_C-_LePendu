class Partie
{
    public List<string>Joueur = new List<string>();

    public List<string> lettreSaisi = new List<string>();
    

    public int ToursJ1;
    public int ToursJ2;
    
    


    Mot mot ;
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
        string motAdevinerP = Console.ReadLine(); //nv mot a devinerp local

        //déclares mon constructeur
        mot = new Mot(motAdevinerP,VieP); // ne pas remettre Mot avant mot sinon Local
        


        while(VieP!=0) // est prise une premiere fois mais redevient
        {
            mot.VerificationMot();
          

            if(Potence.Contains(mot.UserInput))
            {
                Console.WriteLine("Oups vous avez déjà mis cette lettre !");
                //mot.lettreSaisi="";

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


    public void afficherPotenceSeRemplit()
    {
        Console.WriteLine(lettreSaisi.Count);
        string resultat = String.Empty;
        // remplace les lettres dans la potence
            for (int i = 0; i < mot.motAdevinerM.Length; i++)
            {

                if(lettreSaisi.Contains(mot.motAdevinerM[i].ToString())) //lettreP est null
                {
                    resultat += mot.motAdevinerM[i];
                    
                    
                }
                else
                {
                    resultat += "_";
                }
                
            }
            Console.WriteLine(" Mot : " + resultat);
    }
}

