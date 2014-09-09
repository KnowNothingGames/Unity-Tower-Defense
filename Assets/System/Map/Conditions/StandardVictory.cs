using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TowerDefense.System.Player;

namespace TowerDefense.System.Map.Conditions
{
    public class StandardVictory : ICondition
    {
        public bool checkCondition(IMap map, List<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                if (player.Lives <= 0) return true;
            }

            return false;
        }
    }
}
