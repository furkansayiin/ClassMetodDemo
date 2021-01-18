using System;

namespace ClassMetodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriName = "Furkan";
            musteri1.musteriSurname = "Sayın";
            musteri1.musteriMoney = 2000;

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriName = "Engin";
            musteri2.musteriSurname = "Demiroğ";
            musteri2.musteriMoney = 5000;

            Musteri musteri3 = new Musteri();
            musteri3.musteriId = 3;
            musteri3.musteriName = "Berkay";
            musteri3.musteriSurname = "Bilgin";
            musteri3.musteriMoney = 7000;

            Musteri[] musteriler = new Musteri[] {musteri1 , musteri2 , musteri3};
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriName + musteri.musteriSurname + " : " + musteri.musteriMoney);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri3);
            
            


        }
    }
}
