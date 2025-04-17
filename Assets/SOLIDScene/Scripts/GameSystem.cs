using UnityEngine;

namespace SOLIDScene
{
    public class GameSystem : MonoBehaviour
    {
        public GameObject playerPrefab;
        public GameObject ResetPopUpPrefab;
        public static bool IsGameOver;
        void Start()
        {
            IsGameOver = false;
        }

        void Update()
        {
            if (IsGameOver)
            {
                ResetPopUpPrefab.SetActive(true);
                return;
            }
        }
    }
}