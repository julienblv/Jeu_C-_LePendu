class Class_mot_LePendu_2
{
    public Class_mot_LePendu_2(Class_mot_LePendu Class_mot_LePendu)
    {
        this.Class_mot_LePendu = Class_mot_LePendu;
    }
    public string Mot;

    Class_mot_LePendu Class_mot_LePendu;

    string lettre;
    char lettre2;

    public string Potence;

    public List<char> tableau2Lettres = new List<char>();
    public List<char> lettresVisibles = new List<char>();



    // constructeur permettant d'utiliser le mot et le tableau partout !
    public void TableauDuMot(string Mot, List<char> tableau2Lettres)
    {
        this.Mot = Mot;
        this.tableau2Lettres = tableau2Lettres;

    }

    public void MotCoupé()
    {

        for (int i = 0; i < Mot.Length; i++)
        {
            Console.WriteLine(Mot[i]);
            tableau2Lettres.Add(Mot[i]);


        }

        for (int i = 0; i < tableau2Lettres.Count; i++)
        {
            Console.WriteLine(tableau2Lettres[i]);

            //Potence.length(i); marches pas mais veut que i donnes le nombre de potence
        }

    }

    public void lettredevinée()
    {
        Console.WriteLine(" Saisissez la lettre à deviner : ");
        lettre = Console.ReadLine();
        lettre2 = Convert.ToChar(lettre);

        foreach (char lettre2 in tableau2Lettres)
        {
            Potence = "";

            for (int i = 0; i < tableau2Lettres.Count; i++)
            {
                if (lettresVisibles.Contains(tableau2Lettres[i]))
                {
                    Potence += tableau2Lettres[i];
                }
                else
                {
                    Potence += "_";
                }
            }
        }

        Console.WriteLine(Potence);
    }
}







