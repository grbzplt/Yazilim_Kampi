using Ders05_Odev5_2.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_2.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
