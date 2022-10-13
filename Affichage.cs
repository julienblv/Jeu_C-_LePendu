using System.Collections.Generic;

class Affichage
{
    public Partie partieP;
    Mot mot;
    GestionnaireJeu gestionP;

    public List<string> lettreSaisiA = new List<string>();
    public string VerifA;
    public void ErreurSaisie()
    {
        Console.WriteLine("veuillez ne saisir que 1 lettre");
    }

    public void ErreurSaisieChiffre()
    {
        Console.WriteLine("Saisissez un nom pas un chiffre");
    }
    public void ErreurYN()
    {
        Console.WriteLine(" Saisissez 'y' ou 'n' Svp ");
    }

    public void ErreurChiffre()
    {
        Console.WriteLine("Saisisez un chiffre svp");
    }

    public void MotCorrect(string motAdevinerM)
    {

        Console.WriteLine("Bravo vous avez trouvé le mot : " + motAdevinerM);

    }

    public void MotIncorrect(string motAdevinerM)
    {

        Console.WriteLine("Aïe Malheureusement C'est perdu le mot n'as pas été trouvé, c'était : " + motAdevinerM);

    }

    public void afficherPotenceSeRemplit()
    {
        mot = new Mot(mot.motAdevinerM, mot.VieM, mot.Partie);
        
        partieP = new Partie(gestionP,VerifA,lettreSaisiA);

       
        
        string resultat = String.Empty;
        // remplace les lettres dans la potence
        for (int i = 0; i < mot.motAdevinerM.Length; i++)
        {

            if (lettreSaisiA.Contains(mot.motAdevinerM[i].ToString())) //lettreP est null
            {
                resultat += mot.motAdevinerM[i];
                VerifA = resultat;

            }
            else
            {
                resultat += "_";
            }

        }
        Console.WriteLine(" Mot : " + resultat);

        Console.WriteLine(VerifA);

        

    }

    public void EcranTitre()
    {
        string Ascii =  @" 
   __                             _   
  / /  ___   _ __   ___ _ __   __| |_   _  
 / /  / _ \ | '_ \ / _ \ '_ \ / _` | | | | 
/ /__|  __/ | |_) |  __/ | | | (_| | |_| | 
\____/\___| | .__/ \___|_| |_|\__,_|\__,_| 
            |_|
            ";                            
            Console.WriteLine(Ascii);
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                 Start(1)        ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                 Règles(2)       ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                 Quitter(3)      ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                 ");
            Console.WriteLine("                                     ");
            Console.WriteLine("         Sasissez vôtre choix (1 à 3)");
    }

    public void ReglesA()
    {
        string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Julien\Desktop\Jeu_C#_LePendu\Regles.txt");
        
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("Une fois avoir lu vous devrez relançer");
            Environment.Exit(0);
    }

    public void partieTermineeAff()
    {
        Console.WriteLine(" Partie terminée, voulez-vous rejouer ? (say 'y' for yes and 'n' for no) ");
    }
}