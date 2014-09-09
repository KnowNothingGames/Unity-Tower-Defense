using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public void Stop()
        {
            // Remove Events.
        }
    }
}
