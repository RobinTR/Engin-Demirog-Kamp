using GameSales.Abstracts;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Concretes
{
    public class OfferManager : IOfferService
    {
        public void Add(Offer offer)
        {
            Console.WriteLine(offer.Name + " adlı kampanya oluşturuldu.");
        }

        public void Update(Offer offer)
        {
            Console.WriteLine(offer.Name + " adlı kampanya güncellendi.");
        }

        public void Delete(Offer offer)
        {
            Console.WriteLine(offer.Name + " adlı kampanya silindi.");
        }
    }
}
