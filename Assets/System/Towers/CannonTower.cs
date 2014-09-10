using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace TowerDefense.System.Towers
{
	public class CannonTower : Tower
	{
        public GameObject gameObject { get; set; }

        private void initializeGameObject()
        {
            this.gameObject = GameObject.Instantiate(Resources.LoadAssetAtPath("Assets/CannonTower.prefab", typeof(GameObject)), this.Location.ToVector3(), Quaternion.identity) as GameObject;
        }
        public CannonTower(Location loc) : base()
        {
            this.Location = loc;
            this.initializeGameObject();
        }
        public CannonTower() : this(new Location(0, 0, 0)) { }
	}
}
