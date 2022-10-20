using System.Collections.Generic;

public class Affichage
{
    GestionnaireJeu gestionP;

    public List<string> potenceAff = new List<string>();
    Mot mot // Pour Simplifier gestionP.partie.mot avec juste "mot"
    {
        get
        {
            return gestionP.partie.mot;

        }
    }


    public Affichage(GestionnaireJeu gestionP)
    {
        this.gestionP = gestionP;
    }
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
        AfficherPotenceGraph();
        Console.WriteLine(potenceAff[8]);

    }

    public void afficherPotenceSeRemplit()
    {
       
        
        string resultat = String.Empty;
        // remplace les lettres dans la potence
        for (int i = 0; i < gestionP.partie.mot.motAdevinerM.Length; i++)
        {

            if (gestionP.partie.lettreSaisi.Contains(gestionP.partie.mot.motAdevinerM[i].ToString())) //lettreP est null
            {
                resultat += gestionP.partie.mot.motAdevinerM[i];
                gestionP.partie.Verif = resultat;

            }
            else
            {
                resultat += "_";
            }

        }
        Console.WriteLine(" Mot : " + resultat);

        Console.WriteLine(gestionP.partie.Verif);

        

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

    public void Clear()
    {
        Console.Clear();
    }

    public void AfficherPotenceGraph()
    {
        potenceAff.Add(
@"+-------+
    |
    |
    |
    |
    |
==============
        ");

        potenceAff.Add(
@" +-------+
    |       |
    |       
    |
    |
    |
==============
        ");

        potenceAff.Add(
@" +-------+
    |       |
    |       O
    |
    |
    |
==============
        ");

        potenceAff.Add(
@" +-------+
    |       |
    |       O
    |       |
    |
    |
==============
        ");

        potenceAff.Add(
@"+-------+
    |       |
    |       O
    |      -|
    |
    |
==============
        ");

        potenceAff.Add(
@" +-------+
    |       |
    |       O
    |      -|-
    |
    |
==============
        ");

        potenceAff.Add(
@"+-------+
    |       |
    |       O
    |      -|-
    |      |
    |
==============
        ");

        potenceAff.Add(
@"+-------+
    |       |
    |       O
    |      -|-
    |      |
    |
==============
        ");

        potenceAff.Add(
@" +-------+
    |       |
    |       O
    |      -|-
    |      | |
    |
==============
        ");

    }

    public void AfficherJoeurs()
    {
       foreach(Joueur joueur in gestionP.joueurs)
       {
            Console.WriteLine("Score de "+ joueur.nom +" est : " + joueur.score);
       }

       
    }

public void PenduIcon(){
    
        Console.WriteLine( @" 
   __                             _   
  / /  ___   _ __   ___ _ __   __| |_   _  
 / /  / _ \ | '_ \ / _ \ '_ \ / _` | | | | 
/ /__|  __/ | |_) |  __/ | | | (_| | |_| | 
\____/\___| | .__/ \___|_| |_|\__,_|\__,_| 
            |_|
            ");

}


    public void espace()
    {
        Console.WriteLine("                                 ");
        Console.WriteLine("                                 ");
    }

 
public void AfficherLettres()
    {
       for(int i = 0; i < gestionP.partie.lettreSaisi.Count(); i++)
       {
            Console.WriteLine("Vous avez Saisi les Lettres : " + gestionP.partie.lettreSaisi[i]);
       } 
    }
}