using ReKoA.Core.Card;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReKoA.Core.Player
{
    public interface IPlayer
    {
        Deck Deck { get; set; }
    }
}
