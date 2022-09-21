    class Class_mot_LePendu
   {
       private Boolean[] lettresVisibles;
       private String Mot;
 
       public void MotADecouvrir(String nouveauMot)
       {
           Mot = nouveauMot;
           lettresVisibles = new Boolean[Mot.Count()];
       }
 
       public override String ToString()
       {
           String s = "";
 
           for (Int32 x = 0; x < Mot.Count(); x++)
           {
               if (lettresVisibles[x])
                   s += Mot[x];
               else
                   s += "_";
           }
 
           return s;
       }
 
       public Boolean LettreDecouverte(Char c)
       {
           if (Mot.Any(l => l == c))
           {
               for (Int32 x = 0; x < Mot.Count(); x++)
               {
                   if (Mot[x] == c)
                       lettresVisibles[x] = true;
               }
               return true;
           }
           return false;
       }
 
       public Boolean MotDecouvert()
       {
           return !lettresVisibles.Any(l => !l);
       }
    }





   