using UnityEngine;

namespace WordsOnTheWaves.States
{
    public class CargoState : BaseState
    {
        public CargoState(Managers.GameManager manager) : base(manager) { }

        public override void Enter()
        {
            Debug.Log("State: Cargo (Shop Crate)");
            gameManager.HideAllUI();
            if (gameManager.cargoUI != null) gameManager.cargoUI.SetActive(true);
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}
