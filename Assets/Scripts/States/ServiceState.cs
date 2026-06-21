using UnityEngine;

namespace WordsOnTheWaves.States
{
    public class ServiceState : BaseState
    {
        public ServiceState(Managers.GameManager manager) : base(manager) { }

        public override void Enter()
        {
            Debug.Log("State: Service (Selling at Beach)");
            gameManager.HideAllUI();
            if (gameManager.serviceUI != null) gameManager.serviceUI.SetActive(true);
        }

        public override void Update()
        {
        }

        public override void Exit()
        {
        }
    }
}
