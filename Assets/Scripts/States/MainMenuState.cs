using UnityEngine;

namespace WordsOnTheWaves.States
{
    public class MainMenuState : BaseState
    {
        public MainMenuState(Managers.GameManager manager) : base(manager) { }

        public override void Enter()
        {
            Debug.Log("State: Main Menu");
            gameManager.HideAllUI();
            if (gameManager.mainMenuUI != null) gameManager.mainMenuUI.SetActive(true);
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}
