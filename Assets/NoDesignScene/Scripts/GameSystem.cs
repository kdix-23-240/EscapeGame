using UnityEngine;
using UnityEngine.UI;

namespace NoDesignScene
{
    public class GameSystem : MonoBehaviour
    {
        public GameObject playerPrefab;// プレイヤープレハブ
        public GameObject ResetPopUpPrefab;// リセットポップアッププレハブ
        public Text score;// スコア表示用テキスト
        public Text time;// タイム表示用テキスト
        public static bool IsGameOver;// ゲームオーバー状態を示すフラグ
        private float timeCount = 0f;// 経過時間をカウントする変数

        /// <summary>
        /// 実行時に最初に1回だけ呼ばれるメソッド
        /// </summary>
        void Start()
        {
            IsGameOver = false;// ゲームオーバーじゃない
            time.text = "0";// タイムは0から
        }

        /// <summary>
        /// 毎フレーム呼ばれるメソッド
        /// </summary>
        void Update()
        {
            // ゲームオーバーならリザルト画面を表示
            if (IsGameOver)
            {
                ResetPopUpPrefab.SetActive(true);
                score.text = ((int)timeCount * 100).ToString();
                return;
            }

            // ゲームオーバーじゃないならタイムをカウント
            if (!IsGameOver)
            {
                timeCount += Time.deltaTime;
                time.text = ((int)timeCount).ToString();
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