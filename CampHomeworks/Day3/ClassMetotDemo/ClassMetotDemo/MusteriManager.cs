using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        List<Musteri> musteriList = new List<Musteri>();
        public void Ekle(Musteri musteri)
        {
            musteriList.Add(musteri);
            Console.WriteLine($"{ musteri.Ad } { musteri.Soyad } isimli müşteri eklendi.");
        }

        public void Sil(Musteri musteri)
        {
            musteriList.Remove(musteri);
            Console.WriteLine($"{musteri.Id} id'li müşteri silindi.");
        }

        public List<Musteri> Listele()
        {
            return musteriList;
        }
    }
}
