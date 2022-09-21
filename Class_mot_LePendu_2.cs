    class Class_mot_LePendu_2
   {

    public string Mot;
    public char[] tableau2Lettres ;

    
      public void TableauDuMot(string Mot)
      {
            this.Mot = Mot;

      }

      public void MotCoupé()
      {
        tableau2Lettres = Mot.ToCharArray();
        for(int i=0; i < tableau2Lettres.Length;i++ )
        {
            Console.WriteLine(tableau2Lettres[i]);
        }
      }


   }





   