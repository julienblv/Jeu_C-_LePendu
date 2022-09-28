class Partie
{
    public List<string>Joueur = new List<string>();

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
        }
        else
        {
            Console.WriteLine(Joueur[1]+" C'est à vous de commençer !");
        }
    }

    public void faireDeviner()
    {
        Console.WriteLine(" Saisissez le mot à faire deviner : ");
        Console.ReadLine();
    }

    public void partieGagnée()
    {

    }
    public void Potence()
    {
        
    }
}