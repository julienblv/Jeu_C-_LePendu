using System.Collections.Generic;

class Mot
{

    
    public string motAdevinerM;
    public char lettreSaisi;
    //constructeur pour que le mot soit utilisable partout
    public Mot(string mot)
    {
        motAdevinerM = mot;
    }


    public void VerificationMot()
    {
        Console.WriteLine(motAdevinerM + " est le mot a deviner");

        Console.WriteLine("Au joueur d'apres de deviner le mot : ");

        lettreSaisi = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Vous avez choi la lettre" + lettreSaisi);


        
    }


    public void MotCorrect()
    {

    }

    public void MotIncorrect()
    {

    }


}