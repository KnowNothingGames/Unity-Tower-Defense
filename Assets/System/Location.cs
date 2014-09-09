namespace TowerDefense.System
{
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Location(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public Location() : this(0, 0, 0) { }
    }
}
