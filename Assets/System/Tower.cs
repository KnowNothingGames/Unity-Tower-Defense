namespace TowerDefense.System
{
    public class Tower
    {
        public int Cost { get; set; }
        public Weapon Weapon { get; set; }
        public Location Location { get; set; }
        public int Health { get; set; }

        public Tower()
        {
            this.Weapon = new Weapon();
            this.Location = new Location();
        }


    }
}
