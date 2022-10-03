using System.Collections.Generic;

class Mot
{

    public Partie Partie;
    
    public string UserInput;

    
    //constructeur pour que le mot soit utilisable partout
    public Mot(string mot,int vie, Partie partie)
    { 
        this.Partie = partie;
        motAdevinerM = mot;
        VieM = vie;
    }

    public string motAdevinerM;
    public int VieM = 8;

    public void VerificationMot()
    {
        Console.WriteLine(motAdevinerM + " est le mot a deviner");

        Console.WriteLine("Au joueur d'apres de deviner le mot (choisissez une lettre) : ");
        UserInput=(Console.ReadLine());

        if(UserInput.Length > 1)
        {
            Console.WriteLine("veuillez ne saisir que 1 lettre");
            UserInput = Console.ReadLine();
        }

       char _char =  Convert.ToChar(UserInput);

        Console.WriteLine("Vous avez choi la lettre : " + _char);
        Partie.lettreSaisi.Add(_char.ToString());
        

        if(Partie.Potence.Contains(UserInput))
        {
                Console.WriteLine("Oups vous avez déjà mis cette lettre !");
                //mot.lettreSaisi="";

        }
        else
        {
            if(motAdevinerM.Contains(_char)) //Plantes ici car motAdevinerM null
            {
            Partie.Potence.Add(_char.ToString());
            Console.WriteLine(" Bravo vous avez trouvé la lettre : "+ UserInput);

            }
            else
            {
            Console.WriteLine("Aïe Malheureusement ce n'est pas la bonne lettre");
            VieM = VieM-1;
            }

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