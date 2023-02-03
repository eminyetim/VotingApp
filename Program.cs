using System;

namespace VotingApp
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
            System.Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz:");
            System.Console.WriteLine("(1)Yeni kullanici ekle");
            System.Console.WriteLine("(2)Yeni program ekle");
            System.Console.WriteLine("(3)Puanlama yap");
            System.Console.WriteLine("(4)Puanlari görüntüle");
            System.Console.WriteLine("(5)Kullanicilari görüntüle");

            
            int cikis = 0;
           
            do
            {
                int islem = int.Parse(Console.ReadLine());
                switch (islem)
                {
                    case 1: Puanla.yeniKullanici(); break;
                    case 2: Puanla.yeniProgram(); break;
                    case 3: Puanla.Puanlama();break;
                    case 4: Puanla.puanlariGörüntüle();break;
                    case 5: Puanla.kullanicilariGörüntüle();break;

                    case 0: cikis = 1; break;
                    default: break;
                }

            }while (cikis == 0);
        }
    }

}