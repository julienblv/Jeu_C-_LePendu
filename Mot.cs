using System.Collections.Generic;

class Mot
{

    
    public string motAdevinerM;
    public string lettreSaisi;
    //constructeur pour que le mot soit utilisable partout
    public Mot(string mot)
    {
        motAdevinerM = mot;
    }


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

        if(motAdevinerM.Contains(lettreSaisi))
        {
            Console.WriteLine(" Bravo vous avez trouvé la lettre : "+ lettreSaisi);

        }
        else
        {
            Console.WriteLine("Aïe Malheureusement ce n'est pas la bonne lettre");
        }


        
    }


    public void MotCorrect()
    {

    }

    public void MotIncorrect()
    {

    }


}