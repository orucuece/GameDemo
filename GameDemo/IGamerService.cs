using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    interface IGamerService
    {
        //operasyonların interfacei yazıldı
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
