   public class Class_mot_LePendu
  {
    public Class_mot_LePendu(int reference)
    {
        chiffre = reference ; 
    }
    public Class_mot_LePendu()
    { 
    }

    public int chiffre;
//        private Boolean[] lettresVisibles;
//        private String Mot;
 
//        public void MotADecouvrir(String nouveauMot)
//        {
//            lettresVisibles = new Boolean[nouveauMot.Count()];
//            Console.WriteLine(lettresVisibles);
//        }
 
//        public override String ToString()
//        {
//            String s = "";
 
//            for (Int32 x = 0; x < Mot.Count(); x++)
//            {
//                if (lettresVisibles[x])
//                    s += Mot[x];
//                else
//                    s += "_";
//            }
 
//            return s;
//        }
 
//        public Boolean LettreDecouverte(Char c)
//        {
//            if (Mot.Any(l => l == c))
//            {
//                for (Int32 x = 0; x < Mot.Count(); x++)
//                {
//                    if (Mot[x] == c)
//                        lettresVisibles[x] = true;
//                }
//                return true;
//            }
//            return false;
//        }
 
//        public Boolean MotDecouvert()
//        {
//            return !lettresVisibles.Any(l => !l);
//        }
   }



//     Class_mot_LePendu penduM = new Class_mot_LePendu();
            //     while(penduM.MotDecouvert() == false )
            //     {
                
            //     penduM.MotADecouvrir(motJ1);
            //     penduM.ToString();
                
            //     Console.WriteLine("debug1");
            //     //saisie de lettre
            //     Console.WriteLine("saisissez une lettre J1");
            //     lettreSaisie = Console.ReadLine();
            //     lettreSaisie2 = Convert.ToChar(lettreSaisie);
            //    Console.WriteLine("debug2");
            //     //check par rapport au mot
            //     penduM.LettreDecouverte(lettreSaisie2);
            //     penduM.MotDecouvert();
            //    Console.WriteLine("debug3");
            //     //toursP1++; //sert a faire passer au tour d'apres

            //Class_mot_LePendu penduM = new Class_mot_LePendu();
                // while(penduM.MotDecouvert() == false )
                // {
                    
                //     penduM.MotADecouvrir(motJ2);
                //     penduM.ToString();
                    
                //     //saisie de lettre
                //     Console.WriteLine("saisissez une lettre J2");
                //     lettreSaisie = Console.ReadLine();
                //     lettreSaisie2 = Convert.ToChar(lettreSaisie);
                
                //     //check par rapport au mot
                //     penduM.LettreDecouverte(lettreSaisie2);

                //     //tcheckup du mot decouvert
                //     penduM.MotDecouvert();
                //     //toursP1++; //sert a faire passer au tour d'apres
                // }

   