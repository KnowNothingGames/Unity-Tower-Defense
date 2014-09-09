using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TowerDefense.System.Player;

namespace TowerDefense.System.Map
{
    /// <summary>
    /// Represents a collection of Locations that a linked player may build towers in.
    /// </summary>
    public interface IBuildRegion
    {
        List<Location> Locations { get; set; }
        IPlayer Player { get; set; }
    }
}
