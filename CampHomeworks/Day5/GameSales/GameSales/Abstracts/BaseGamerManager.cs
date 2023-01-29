using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Abstracts
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("Oyuncu eklendi: " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi: " + gamer.FirstName + " " + gamer.LastName);
        }

        public virtual void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi: " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
