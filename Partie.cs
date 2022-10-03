class Partie
{
    public List<string> Joueur = new List<string>();

    public List<string> lettreSaisi = new List<string>();


    public int ToursJ1;
    public int ToursJ2;


    public string Verif;

    Mot mot;
    static int VieP = 9;







    public List<string> Potence = new List<string>();

    public void Commencer()
    {
        VieP = 9;

        Console.WriteLine("Bienvenue à toi ! Saisies le nom du Joueur 1");
        Joueur.Add(Console.ReadLine());//Joueur[0]
        Console.WriteLine("Merci ! Maintenant, saisies le nom du Joueur 2");
        Joueur.Add(Console.ReadLine()); //Joueur[1]

        QuiCommences();
        faireDeviner();



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

    public void faireDeviner()
    {
        Console.WriteLine(" Saisissez le mot à faire deviner : ");
        string motAdevinerP = Console.ReadLine(); //nv mot a devinerp local

        int verifChiffre = 0;
        while (verifChiffre == 0)
        {
            int c; // valeur c car compares

            if (int.TryParse(motAdevinerP, out c))// comparaison si la valeur est bien un strinfg
            {
                Console.WriteLine("Saisissez un nom pas un chiffre");
                motAdevinerP = Console.ReadLine();
                verifChiffre = 1;
            }
            else
            {
                verifChiffre = 1;
            }
        }

        //déclares mon constructeur
        mot = new Mot(motAdevinerP, VieP, this); // ne pas remettre Mot avant mot sinon Local



        while (VieP != 0) // est prise une premiere fois mais redevient
        {
            mot.VerificationMot();

            afficherPotenceSeRemplit();

            if (VieP == 1)
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

            if (lettreSaisi.Contains(mot.motAdevinerM[i].ToString())) //lettreP est null
            {
                resultat += mot.motAdevinerM[i];
                Verif = resultat;

            }
            else
            {
                resultat += "_";
            }

        }
        Console.WriteLine(" Mot : " + resultat);

        Console.WriteLine(Verif);

    }
}

