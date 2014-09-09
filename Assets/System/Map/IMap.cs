using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense.System.Map
{
    /// <summary>
    /// A Map. Yeah, I don't know what to put here.
    /// </summary>
    public interface IMap
    {
        int WaveCount { get; set; }

        List<ICondition> VictoryConditions { get; set; }
        List<ICondition> DefeatConditions { get; set; }

        List<ISpawner> Spawners { get; set; }
        List<IWaypoint> Waypoints { get; set; }
        List<IGoal> Goals { get; set; }

        IRegion[][] Regions { get; set; }
    }
}
