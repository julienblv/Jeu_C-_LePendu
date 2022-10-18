using System.Collections.Generic;

public class Mot
{

    public string UserInput;

     public int VieM = 9;

   public GestionnaireJeu gestion;

    //constructeur pour que le mot soit utilisable partout
    public Mot(string mot, int vie,GestionnaireJeu gestion)
    {
        
        motAdevinerM = mot;
        VieM = vie;
        this.gestion = gestion;
        
    }

    public string motAdevinerM;
  

    public void VerificationMot()
    {
        Console.WriteLine("Au joueur d'apres de deviner le mot (choisissez une lettre) : ");
        UserInput = (Console.ReadLine());

        if (UserInput.Length > 1)
        {
            gestion.afficherG.ErreurSaisie();
            UserInput = Console.ReadLine();
        }

        int c2; // valeur c car compares
        int verifChiffre = 0;
        while (verifChiffre == 0)
        {
            if (int.TryParse(UserInput, out c2))// comparaison si la valeur est bien un strinfg
            {
                Console.WriteLine("Saisissez une lettre pas un chiffre");
                UserInput = Console.ReadLine();
                verifChiffre = 1;
            }
            else
            {
                verifChiffre = 1;
            }
        }

        char _char = Convert.ToChar(UserInput);

        Console.WriteLine("Vous avez choi la lettre : " + _char);
        gestion.partie.lettreSaisi.Add(_char.ToString()); 


        if (gestion.partie.Potence.Contains(UserInput))
        {
            Console.WriteLine("Oups vous avez déjà mis cette lettre !");
            //mot.lettreSaisi="";

        }
        else
        {
            if (motAdevinerM.Contains(_char)) 
            {
                gestion.partie.Potence.Add(_char.ToString());
                Console.WriteLine(" Bravo vous avez trouvé la lettre : " + UserInput);

            }
            else
            {
                Console.WriteLine("Aïe Malheureusement ce n'est pas la bonne lettre");
                VieM = VieM - 1;
            }

        }





    }




}