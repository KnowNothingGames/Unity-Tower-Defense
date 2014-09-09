using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense.System.Map
{
    public interface ISpawner
    {
        Location Spawn { get; set; }
    }
}
