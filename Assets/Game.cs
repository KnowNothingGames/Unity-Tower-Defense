using System;
using System.Collections.Generic;
using TowerDefense.System.States;
using UnityEngine;

namespace TowerDefense
{
    // Game Delegates.
    public delegate void GameStartEventHandler(object sender, EventArgs e);
    public delegate void GameStopEventHandler(object sender, EventArgs e);
    public delegate void GamePauseEventHandler(object sender, EventArgs e);
    public delegate void GameUnpauseEventHandler(object sender, EventArgs e);
    public delegate void GameTickEventHandler(object sender, EventArgs e);
    public delegate void GameClickEventHandler(object sender, EventArgs e);

    public class Game : MonoBehaviour
    {
        #region Events
        public event GameStartEventHandler GameStart;
        public event GameStopEventHandler GameStop;
        public event GamePauseEventHandler GamePause;
        public event GameUnpauseEventHandler GameUnpause;
        public event GameTickEventHandler GameTick;

        protected virtual void OnStart(EventArgs e) { if (GameStart != null) GameStart(this, e); }
        protected virtual void OnStop(EventArgs e) { if (GameStop != null) GameStop(this, e); }
        protected virtual void OnPause(EventArgs e) { if (GamePause != null) GamePause(this, e); }
        protected virtual void OnUnpause(EventArgs e) { if (GameUnpause != null) GameUnpause(this, e); }
        protected virtual void OnTick(EventArgs e) { if (GameTick != null) GameTick(this, e); }
        #endregion

        private Stack<IGameState> stateStack { get; set; }
        private IGameState currentState
        {
            get
            {
                return this.stateStack.Peek();
            }
        }

        void Initialize()
        {
            this.stateStack = new Stack<IGameState>();
            this.stateStack.Push(new MenuState());
            //this.stateStack.Push(new GameState());
        }

        // Use this for initialization
        void Start()
        {
            this.Initialize();
            OnStart(EventArgs.Empty);
        }

        // Update is called once per frame
        void Update()
        {
            this.currentState.Update();
        }

        void OnGUI()
        {
            this.currentState.OnGUI();
        }
    }
}
