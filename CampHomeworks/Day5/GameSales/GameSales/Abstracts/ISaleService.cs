using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Abstracts
{
    public interface ISaleService
    {
        void Sale(Gamer gamer, Game game);
        void Sale(Gamer gamer, Game game, Offer offer);
    }
}
