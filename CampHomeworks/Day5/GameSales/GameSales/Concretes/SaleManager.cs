using GameSales.Abstracts;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Concretes
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine(game.Name + " oyunu, " + gamer.FirstName + " adlı kullanıcıya " + game.Price + " TL'ye satıldı.");
        }

        public void Sale(Gamer gamer, Game game, Offer offer)
        {
            double salePrice = game.Price - (game.Price * (offer.DiscountRate/100));
            Console.WriteLine(game.Name + " oyunu, " + gamer.FirstName + " adlı kullanıcıya " + offer.Name + " kampanyası ile %" + offer.DiscountRate + " indirimle " + salePrice + " TL'ye satıldı.");
        }
    }
}
