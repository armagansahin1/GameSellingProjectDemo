using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Kaydedildi!!!");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Silindi!!!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Güncellendi!!!");
        }
    }
}
