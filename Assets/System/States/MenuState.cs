using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace TowerDefense.System.States
{
    public class MenuState : IGameState
    {
        public event GameStartEventHandler OnStart;
        public event GameStopEventHandler OnStop;
        public event GamePauseEventHandler OnPause;
        public event GameUnpauseEventHandler OnUnpause;
        public event GameClickEventHandler OnClick;
        public event GameTickEventHandler OnTick;

        public void Start()
        {
            // Initialize (Mouse) Menu-Button Events
            // Initialize Keyboard Events
        }

        public void Update()
        {

        }

        public void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width - 125, Screen.height - 150, 100, 50), "Play Demo"))
            {
                // How do we handle the transition from one state to another?
                // A transition event that the Game object listens to with the EventArgs as the next state or something?
                

                // On another note, we could just split them into different scenes and use something like:
                // Application.LoadLevel("SceneName");
                // Which might prove to be much easier for the transition but may prove more difficult to maintain GameObjects.
                // Might want to look into this further before making a decision.
            }

            if (GUI.Button(new Rect(Screen.width - 125,  Screen.height - 75, 100, 50), "Exit to desktop"))
            {
                Application.Quit();
            }
        }

        public void Stop()
        {
            // Remove Events.
        }
    }
}
