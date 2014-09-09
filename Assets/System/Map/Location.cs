using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TowerDefense.System.Map
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public LocationTypes Type { get; set; }

        public Location(int x, int y, int z, LocationTypes type = LocationTypes.UnbuildableGround)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Type = type;
        }
        public Location() : this(0, 0, 0, LocationTypes.UnbuildableGround) { }
    }
}
