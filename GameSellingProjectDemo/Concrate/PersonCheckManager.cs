using GameSellingProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Concrate
{
    public class PersonCheckManager : IPersonCheckService
    {
        public bool Verify(Gamer gamer)
        {
            if (gamer.NationalityId == "11189245922" && gamer.FirstName == "ARMAĞAN" && gamer.LastName == "ŞAHİN" &&
                gamer.DateOfBirth.Year == 1995)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
