using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TARpv21
{
    public class Inimene
    {
        string eesnimi;
        int vanus;
        string staatus;
        string perekonanimi;
        int isikukood;
        string pool; 



        public Inimene() { }//Конструктор
        public Inimene(string Eesnimi, int Vanus)
        {
            eesnimi = Eesnimi;
            vanus = Vanus; 
        }
        public string Eesnimi
        {
            set 
            {
                if (eesnimi == null) eesnimi = value; 
            }
            get { return eesnimi; }
        }//св-ва
        public string Perekonanimi
        {
            set
            {
                perekonanimi = value;
            }
            get { return eesnimi; }
        }
        public int Vanus
        {
            set { vanus = value;
                if (vanus<7)
                {
                    staatus = "väike laps";
                }
                else if (vanus<17)
                {
                    staatus = "Kooli laps";
                }
                else if (vanus<65)
                {
                    staatus = "tööline inimene";
                }
                else
                {
                    staatus = "senior";
                }
            
            }
            get { return vanus;  } 
        }
        public int Isikukood
        { 
            set 
            { 
                isikukood = value ;
                char[] arr = isikukood.ToString().ToCharArray();
                if (arr[0] == 1 )
                {
                    pool = "1800. ... 1899. a sündinud mees";
                }
                else if (arr[0] == 2)
                {
                    pool = "kui 1800. ... 1899. a sündinud naine";
                }
                else if (arr [0]== 3)
                {
                    pool = "kui 1900. ... 1999. a sündinud mees";
                }
                else if (arr[0] == 4)
                {
                    pool = " kui 1900. ... 1999. a sündinud naine";
                }
                else if (arr[0] == 5)
                {
                    pool = "kui 1900. ... 1999. a sündinud mees";
                }
                else if (arr[0] == 6)
                {
                    pool = "kui 1900. ... 1999. a sündinud mees";
                }
                else if (arr[0] == 7)
                {
                    pool = "kui 1900. ... 1999. a sündinud mees";
                }
                else if (arr[0] == 8)
                {
                    pool = "kui 1900. ... 1999. a sündinud mees";
                }

            }
        public string Staatus
        {
            set { staatus = value; }
            get { return staatus;  }
        }
        public void Tervitame()//Метод
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Minu nimi on {0}. Olen {1} aastat vana. Minu staatus on {2}", eesnimi, vanus, staatus);
        }
    }   
}
