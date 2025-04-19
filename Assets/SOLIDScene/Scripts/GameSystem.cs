using UnityEngine;

namespace SOLIDScene
{
    public class GameSystem : MonoBehaviour
    {
        public GameObject playerPrefab;// プレイヤープレハブ
        public GameObject ResetPopUpPrefab;// リセットポップアッププレハブ
        public static bool IsGameOver;// ゲームオーバー状態を示すフラグ

        /// <summary>
        /// 実行時に最初に1回だけ呼ばれるメソッド
        /// </summary>
        void Start()
        {
            IsGameOver = false;// ゲームオーバーじゃない
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
                return;
            }
        }
    }
}