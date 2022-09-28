class Partie
{
    public List<string>Joueur = new List<string>();
    public string motAdevinerP;

    public int ToursJ1;
    public int ToursJ2;

    public void Commencer()
    {
        Console.WriteLine("Bienvenue à toi ! Saisies le nom du Joueur 1");
        Joueur.Add(Console.ReadLine()); //Joueur[0]
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
        
        Mot mot = new Mot(motAdevinerP); //pass pas 
        mot.VerificationMot();

        //mot.MotIncorrect();
        
        //mot.MotCorrect();
        
    }

    public void partieGagnée()
    {

    }
    public void Potence()
    {
        
    }

}