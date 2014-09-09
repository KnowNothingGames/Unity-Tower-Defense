using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TowerDefense.System.Player;

namespace TowerDefense.System.Map
{
    /// <summary>
    /// Represents a chunk or collection of locations.
    /// </summary>
    public interface IRegion
    {
        Location[][] Locations { get; set; }
    }
}
