using System;
using System.Collections.Generic;
using System.Text;
using GameSellingProjectDemo.Entities;

namespace GameSellingProjectDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool Verify(Gamer gamer);
    }
}

