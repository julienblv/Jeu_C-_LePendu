using System.Collections.Generic;

public class Mot
{

    public string UserInput;
    public int count = 0;
    public int VieM = 11;
    
    public int temp;
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
        gestion.afficherG.espace();
        Console.WriteLine(gestion.partie.joueurDevine.nom + " a vous de deviner le mot (choisissez une lettre) : ");
        UserInput = (Console.ReadLine());
        gestion.afficherG.Clear();
        

        if (UserInput.Length > 1)
        {
            gestion.afficherG.PenduIcon();
            gestion.afficherG.espace();
            gestion.afficherG.ErreurSaisie();
            UserInput = Console.ReadLine();
            gestion.afficherG.Clear();
        }

        int c2; // valeur c car compares
        int verifChiffre = 0;
        while (verifChiffre == 0)
        {
            gestion.afficherG.AffichageLettreSaisie();
            if (int.TryParse(UserInput, out c2))// comparaison si la valeur est bien un strinfg
            {

                gestion.afficherG.PenduIcon();
                gestion.afficherG.espace();
                Console.WriteLine("Saisissez une lettre pas un chiffre");
                UserInput = Console.ReadLine();
                verifChiffre = 1;
                gestion.afficherG.Clear();
            }
            else
            {
                verifChiffre = 1;
            }
        }
        char _char = Convert.ToChar(UserInput);

        Console.WriteLine("Vous avez choi la lettre : " + _char);
        gestion.partie.lettreSaisi.Add(_char.ToString()); 
        gestion.afficherG.Clear();


        if (gestion.partie.Potence.Contains(UserInput))
        {
            gestion.afficherG.PenduIcon();
            gestion.afficherG.espace();
            Console.WriteLine("Oups vous avez déjà mis cette lettre !");
            gestion.afficherG.Clear();

        }
        else
        {
            if (motAdevinerM.Contains(_char)) 
            {
                gestion.afficherG.PenduIcon();
                gestion.afficherG.espace();
                gestion.partie.Potence.Add(_char.ToString());
                Console.WriteLine(" Bravo vous avez trouvé la lettre : " + UserInput);
                

            }
            else
            {
                gestion.afficherG.PenduIcon();
                gestion.afficherG.espace();
                gestion.afficherG.AfficherMessage("Aie malhheureusement ce n'est pas la bonne lettre", ConsoleColor.Red);
                gestion.afficherG.AfficherPotenceGraph(temp);
                VieM = VieM - 1;
                count++;
                temp = count;
                Thread.Sleep(2000);
                gestion.afficherG.Clear();

                
            }

        }


    }


}