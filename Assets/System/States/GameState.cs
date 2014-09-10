using TowerDefense;

namespace TowerDefense.System.States
{
    public class GameState : IGameState
    {
        public event GameStartEventHandler OnStart;
        public event GameStopEventHandler OnStop;
        public event GamePauseEventHandler OnPause;
        public event GameUnpauseEventHandler OnUnpause;
        public event GameTickEventHandler OnTick;
        public event GameClickEventHandler OnClick;

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
        }

        public void Stop()
        {
            // Remove Events.
        }
    }
}
