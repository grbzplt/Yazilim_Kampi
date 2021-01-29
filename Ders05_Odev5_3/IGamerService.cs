using System;
using System.Collections.Generic;
using System.Text;

namespace Ders05_Odev5_3
{
    public interface IGamerService
    {
        void Add(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
