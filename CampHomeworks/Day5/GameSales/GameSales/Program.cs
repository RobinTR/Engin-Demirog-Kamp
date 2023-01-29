using GameSales.Abstracts;
using GameSales.Adapters;
using GameSales.Concretes;
using GameSales.Entities;

namespace GameSales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer { Id = 1, FirstName = "Mem Robin", LastName = "Çen",
            DateOfBirth = new DateTime(1999,2,25), NationalityId = "20422222224"
            };

            Game game = new Game { Id = 1, Name = "Minecraft", Price = 250 };

            Offer offer = new Offer { Id = 1, Name = "Gülümseten Cuma", Detail = "Gülümseten Cuma kampanyası detayları.", DiscountRate = 20};

            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer);

            GameManager gameManager = new GameManager();
            gameManager.Add(game);

            OfferManager offerManager = new OfferManager();
            offerManager.Add(offer);

            SaleManager saleManager = new SaleManager();
            saleManager.Sale(gamer, game);
            saleManager.Sale(gamer, game, offer);
        }
    }
}