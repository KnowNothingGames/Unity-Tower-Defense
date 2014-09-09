using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TowerDefense.System.Player;

namespace TowerDefense.System.Map
{
    /// <summary>
    /// Represents either a Victory/Defeat Condition.
    /// </summary>
    public interface ICondition
    {
        /// <summary>
        /// When this returns true, the condition has been fulfilled.
        /// </summary>
        bool checkCondition(IMap map, List<IPlayer> players);
    }
}
