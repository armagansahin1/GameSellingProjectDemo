using GameSellingProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Concrate
{
    public class GamerManager : BaseGamerManager
    {
        private IPersonCheckService _personCheck;

        public GamerManager(IPersonCheckService personCheck)
        {
            _personCheck = personCheck;
        }

        public override void Save(Gamer gamer)
        {
            if (_personCheck.Verify(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                Console.WriteLine("Kişi Bulunamadı !!!");
            }

        }
    }
}
