using UnityEngine;

namespace NoDesignScene
{
    public class Player : MonoBehaviour
    {
        /// <summary>
        /// 毎フレーム呼ばれるメソッド
        /// </summary>
        void Update()
        {
            // ゲームオーバーの時は何もしない、即リターン
            // **ここに処理を書く**

            // 左にx座標1移動
            // Aまたは左キーで移動
            if (-8 < this.gameObject.transform.position.x)
            {
                // **ここに処理を書く**
            }

            // 右にx座標-1移動
            // Dまたは右キーで移動
            if (this.gameObject.transform.position.x < 8)
            {
                // **ここに処理を書く**
            }
        }

        /// <summary>
        /// 何かに衝突した時に呼ばれるメソッド
        /// </summary>
        /// <param name="collision"></param>
        void OnCollisionEnter2D(Collision2D collision)
        {
            // Fallingタグのオブジェクトと衝突した時
            // 1. ゲームオーバーにする
            // 2. プレイヤーを非表示にする
            // 3. 衝突した隕石を非表示にする
            if (collision.gameObject.CompareTag("Falling"))
            {
                // **ここに処理を書く**
            }
        }

        /// <summary>
        /// リセットメソッド
        /// プレイヤーの位置を初期位置に戻す
        /// プレイヤーを表示する
        /// </summary>
        public void Reset()
        {
            this.gameObject.transform.position = new Vector3(0, -2, 0);
            this.gameObject.SetActive(true);
        }
    }
}