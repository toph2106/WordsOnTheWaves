using UnityEngine;

namespace WordsOnTheWaves.States
{
    public class PreparationState : BaseState
    {
        public PreparationState(Managers.GameManager manager) : base(manager) { }

        public override void Enter()
        {
            Debug.Log("State: Preparation (Arrange Books)");
            gameManager.HideAllUI();
            if (gameManager.preparationUI != null) gameManager.preparationUI.SetActive(true);
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}
