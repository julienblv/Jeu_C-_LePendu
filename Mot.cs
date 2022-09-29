using System.Collections.Generic;

class Mot
{

    public Partie Partie = new Partie();
    
    public string lettreSaisi;

    
    //constructeur pour que le mot soit utilisable partout
    public Mot(string mot,int vie)
    {
        motAdevinerM = mot;
        VieM = vie;
    }

    public string motAdevinerM;
    public int VieM = 8;

    public void VerificationMot()
    {
        Console.WriteLine(motAdevinerM + " est le mot a deviner");

        Console.WriteLine("Au joueur d'apres de deviner le mot (choisissez une lettre) : ");
        lettreSaisi = Console.ReadLine();

        if(lettreSaisi.Length > 1)
        {
            Console.WriteLine("veuillez ne saisir que 1 lettre");
            lettreSaisi = Console.ReadLine();
        }

        Convert.ToChar(lettreSaisi);

        Console.WriteLine("Vous avez choi la lettre : " + lettreSaisi);

        //Console.WriteLine("Debug devinez " + motAdevinerM);

        if(motAdevinerM.Contains(lettreSaisi)) //Plantes ici car motAdevinerM null
        {
            Partie.Potence.Add(lettreSaisi);
            Console.WriteLine(" Bravo vous avez trouvé la lettre : "+ lettreSaisi);

        }
        else
        {
            Console.WriteLine("Aïe Malheureusement ce n'est pas la bonne lettre");
            VieM = VieM-1;
        }
        


        
    }


    public void MotCorrect()
    {
        Console.WriteLine("Bravo vous avez trouvé le mot : " + motAdevinerM);
    }

    public void MotIncorrect()
    {
        Console.WriteLine("Aïe Malheureusement C'est perdu le mot n'as pas été trouvé, c'était : " + motAdevinerM);
    }


}