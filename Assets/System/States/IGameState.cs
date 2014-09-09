namespace TowerDefense.System.States
{
    public interface IGameState
    {
        event GameStartEventHandler OnStart;
        event GameStopEventHandler OnStop;
        event GamePauseEventHandler OnPause;
        event GameUnpauseEventHandler OnUnpause;
        event GameClickEventHandler OnClick;
        event GameTickEventHandler OnTick;

        void Start();
        void Update();
        void Stop();
    }
}
