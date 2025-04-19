using UnityEngine;
using UnityEngine.UI;

namespace SOLIDScene
{
    public class TextManager : MonoBehaviour
    {
        public Text timeText;// タイムテキスト
        public Text scoreText;// スコアテキスト
        private float timeCount = 0f;// 経過時間をカウントする変数

        /// <summary>
        /// 実行時に最初に1回だけ呼ばれるメソッド
        /// </summary>
        private void Start()
        {
            timeText.text = "0";// タイムは0から
        }

        /// <summary>
        /// 毎フレーム呼ばれるメソッド
        /// </summary>
        private void Update()
        {
            // ゲームオーバーならスコアを表示
            if(GameSystem.IsGameOver)
            {
                scoreText.text = ((int)timeCount * 100).ToString();
                return;
            }

            // ゲームオーバーじゃないならタイムをカウント
            if (!GameSystem.IsGameOver)
            {
                timeCount += Time.deltaTime;
                timeText.text = ((int)timeCount).ToString();
            }
        }

        /// <summary>
        /// タイムカウントをリセットするメソッド
        /// </summary>
        public void ResetTimeCount()
        {
            timeCount = 0f;
        }
    }
}