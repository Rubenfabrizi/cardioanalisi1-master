using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equazionilybrary
{

    public class DataCardio
    {
        //primo punto
        public static int CalcfrecquenzaMin(int eta)
        {
            
            int freq =  220 - eta;
            
            double battiti= freq*0.7;
            

            double fmin = freq - battiti;

           
        
            
            return freq;
        }
        public static int CalcfrecquenzaMax(int eta)
        {

            int freq = 220 - eta;

            
            double battiti1 = freq * 0.9;

           

            double fmax = freq - battiti1;


            return freq;
        }

        //secondo punto 
        public static string interpretaredati(int battiti)
        {
            string msg = "";
            if (battiti<60)
            {
                msg="bradicardia";
            }
            else if (battiti >= 60 && battiti <= 100)
                 {
                    msg="normale";
                 }
                else if(battiti>100)
                {
                    msg="tachicardia";
                }
            

                return msg;
        }
        
        public static double calcolocalorie(int frequenza, int eta, double durata, double peso,string sesso)
        {
            double calorieb = 0;
            if (sesso=="m")
            {
                calorieb = (((eta * 0.2017) - (peso * 0.199) + (frequenza * 0.6309) - 55.0969)* durata /4.184);
            }
            else if(sesso=="f")
            {
                calorieb = (((eta * 0.074) - (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * durata / 4.184);
            }
           

            return calorieb;
        }
        

        
    }
}
