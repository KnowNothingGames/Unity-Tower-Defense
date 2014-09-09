using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense.System.Player
{
    public interface IPlayer
    {
        int Lives { get; set; }
        int Gold { get; set; }

        void Defeated();
        void Victory();
    }
}
