using UnityEngine;
using WordsOnTheWaves.States;

namespace WordsOnTheWaves.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [Header("UI Panels")]
        public GameObject mainMenuUI;
        public GameObject cargoUI;
        public GameObject preparationUI;
        public GameObject serviceUI;

        private BaseState currentState;

        public MainMenuState MainMenu { get; private set; }
        public CargoState Cargo { get; private set; }
        public PreparationState Preparation { get; private set; }
        public ServiceState Service { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
                return;
            }
            Instance = this;
            DontDestroyOnLoad(gameObject);

            InitializeStates();
        }

        private void InitializeStates()
        {
            MainMenu = new MainMenuState(this);
            Cargo = new CargoState(this);
            Preparation = new PreparationState(this);
            Service = new ServiceState(this);
        }

        private void Start()
        {
            ChangeState(MainMenu);
        }

        private void Update()
        {
            if (currentState != null)
            {
                currentState.Update();
            }

            // Debug phím điều hướng để nghiệm thu Tuần 1
#if ENABLE_INPUT_SYSTEM
            if (UnityEngine.InputSystem.Keyboard.current != null)
            {
                if (UnityEngine.InputSystem.Keyboard.current.digit1Key.wasPressedThisFrame) ChangeState(MainMenu);
                if (UnityEngine.InputSystem.Keyboard.current.digit2Key.wasPressedThisFrame) ChangeState(Cargo);
                if (UnityEngine.InputSystem.Keyboard.current.digit3Key.wasPressedThisFrame) ChangeState(Preparation);
                if (UnityEngine.InputSystem.Keyboard.current.digit4Key.wasPressedThisFrame) ChangeState(Service);
            }
#else
            if (Input.GetKeyDown(KeyCode.Alpha1)) ChangeState(MainMenu);
            if (Input.GetKeyDown(KeyCode.Alpha2)) ChangeState(Cargo);
            if (Input.GetKeyDown(KeyCode.Alpha3)) ChangeState(Preparation);
            if (Input.GetKeyDown(KeyCode.Alpha4)) ChangeState(Service);
#endif
        }

        public void ChangeState(BaseState newState)
        {
            if (currentState != null)
            {
                currentState.Exit();
            }

            currentState = newState;
            
            if (currentState != null)
            {
                currentState.Enter();
            }
        }

        public void HideAllUI()
        {
            if (mainMenuUI != null) mainMenuUI.SetActive(false);
            if (cargoUI != null) cargoUI.SetActive(false);
            if (preparationUI != null) preparationUI.SetActive(false);
            if (serviceUI != null) serviceUI.SetActive(false);
        }
    }
}
