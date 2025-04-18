using UnityEngine;
using UnityEngine.UI;

namespace AnsNoDesignScene
{
    public class GameSystem : MonoBehaviour
    {
        public GameObject playerPrefab;
        public GameObject ResetPopUpPrefab;
        public Text score;
        public Text time;
        public static bool IsGameOver;
        private float timeCount = 0f;
        void Start()
        {
            IsGameOver = false;
            time.text = "0";
        }

        void Update()
        {
            if (IsGameOver)
            {
                // Debug.Log("Game Over!");
                ResetPopUpPrefab.SetActive(true);
                score.text = ((int)timeCount * 100).ToString();
                return;
            }

            if (!IsGameOver)
            {
                timeCount += Time.deltaTime;
                time.text = ((int)timeCount).ToString();
            }
        }

        public void ResetTimeCount()
        {
            timeCount = 0f;
        }
    }
}