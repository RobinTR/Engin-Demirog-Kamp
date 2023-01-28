namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Mem Robin";
            musteri1.Soyad = "Çen";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Engin";
            musteri2.Soyad = "Demiroğ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Test";
            musteri3.Soyad = "Test";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Sil(musteri3);
            Console.WriteLine("----------Müşteri Listesi----------");
            foreach (Musteri musteri in musteriManager.Listele())
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}