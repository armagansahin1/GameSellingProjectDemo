using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Abstract
{
    public interface ICampaign
    {
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
