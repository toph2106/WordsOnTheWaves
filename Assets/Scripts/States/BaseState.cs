namespace WordsOnTheWaves.States
{
    public abstract class BaseState
    {
        protected Managers.GameManager gameManager;

        public BaseState(Managers.GameManager manager)
        {
            this.gameManager = manager;
        }

        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();
    }
}
