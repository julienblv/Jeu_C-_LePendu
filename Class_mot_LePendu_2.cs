    class Class_mot_LePendu_2
   {

    public string Mot;
    public char[] tableau2Lettres;

    string lettre;
    char lettre2;

    public char[] Potence;
    
    // constructeur permettant d'utiliser le mot et le tableau partout !
      public void TableauDuMot(string Mot, char[] tableau2Lettres)
      {
            this.Mot = Mot;
            this.tableau2Lettres = tableau2Lettres;

      }

      public void MotCoupé()
      {
        tableau2Lettres = Mot.ToCharArray();
        for(int i=0; i < tableau2Lettres.Length;i++ )
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

        foreach(char lettre2 in tableau2Lettres)
        {
          if(// nombre de lettre présentes dans le tableau //)
          Console.WriteLine(Potence[lettre2]);

        }
      }


   }





   