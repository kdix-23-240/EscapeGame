using UnityEngine;
using UnityEngine.UI;

namespace AnsSOLIDScene
{
    public class TextManager : MonoBehaviour
    {
        public Text timeText;
        public Text scoreText;
        private float timeCount = 0f;

        private void Start()
        {
            timeText.text = "0";
        }

        private void Update()
        {
            if(GameSystem.IsGameOver)
            {
                scoreText.text = ((int)timeCount * 100).ToString();
                return;
            }

            if (!GameSystem.IsGameOver)
            {
                timeCount += Time.deltaTime;
                timeText.text = ((int)timeCount).ToString();
            }
        }

        public void ResetTimeCount()
        {
            timeCount = 0f;
        }
    }
}