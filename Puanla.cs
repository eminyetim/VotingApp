using System;

namespace VotingApp
{
    
    public class Puanla
    {
        static List<Kullanicilar> kuallniclarList = new List<Kullanicilar>();
        static List<Programlar> programlarList = new List<Programlar>();

        public Puanla()
        {

        }
        public static void yeniKullanici()
        {
            System.Console.WriteLine("Lütfen Kullanicinin ismini giriniz");
            string tempName = Convert.ToString(Console.ReadLine());
            Kullanicilar k1 = new Kullanicilar(tempName);
            kuallniclarList.Add(k1);
        }

        public static void yeniProgram()
        {
            System.Console.WriteLine("Lütfen Program ismini giriniz");
            string tempName = Convert.ToString(Console.ReadLine());
            Programlar p1 = new Programlar(tempName);
            programlarList.Add(p1);
        }

        public static void Puanlama()
        {
            string kullanicName = "";
            bool kullaniciVarmi = false;
            do
            {
                System.Console.WriteLine("Lütfen Puanlama yapacak kullanicinin ismini giriniz");
                kullanicName = Convert.ToString(Console.ReadLine());
                if(kullanicName == "cikis")
                {
                    Environment.Exit(0);
                }
                foreach (var item in kuallniclarList)
                {
                    if(item.name == kullanicName )
                    {
                        kullaniciVarmi = true;
                    }
                }       
            } while (kullaniciVarmi == false);  
              
           
            if(kullaniciVarmi == false )
            {
                System.Console.WriteLine("Kullaci Bulunamadi tekrar deneyeniz");
            }
            if(kullaniciVarmi == true)
            {
                foreach (var item in kuallniclarList)
                {
                    
                    if(item.name == kullanicName)
                    {
                        int temp = item.sonPuanlama;
                        for (int i = temp; i < programlarList.Count(); i++)
                        {
                            System.Console.WriteLine("** Puanlama :" + programlarList[i].nameProgram + " **");
                            System.Console.WriteLine("Lütfen kaç puan eklmek istediğiniz giriniz:");
                            int puan = int.Parse(Console.ReadLine());
                            programlarList[i].point+=puan;
                            item.sonPuanlama++;
                            if(puan == 0)
                            {
                                Environment.Exit(0);
                            }
                         }      
                    }
                                          
                }          

            }

        }

        public static void puanlariGörüntüle()
        {
            foreach (var item in programlarList )
            {
                System.Console.WriteLine(item.nameProgram + " :" + item.point);
            }
        }
        
        public static void kullanicilariGörüntüle()
        {
            foreach (var item in kuallniclarList )
            {
                System.Console.WriteLine(item.name + " :" + item.sonPuanlama);
            }
        }
    }

}