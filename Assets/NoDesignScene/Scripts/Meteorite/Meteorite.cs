using UnityEngine;

namespace NoDesignScene
{
    public class Meteorite : MonoBehaviour
    {
        private float posX;// 隕石オブジェクトのX座標
        private float posY; // 隕石オブジェクトのY座標
        public float speed = 5f; // 落下スピード
        public float destroyHeight = -10f; // 隕石が消えるY座標

        /// <summary>
        /// 実行時に最初に1回だけ呼ばれるメソッド
        /// </summary>
        void Start()
        {
            posX = this.gameObject.transform.position.x;
            posY = this.gameObject.transform.position.y;
        }

        /// <summary>
        /// 毎フレーム呼ばれるメソッド
        /// </summary>
        void Update()
        {
            // ゲームオーバーの時は何もしない、即リターン
            if (GameSystem.IsGameOver)
            {
                return;
            }
            transform.Translate(Vector3.down * speed * Time.deltaTime);

            // 隕石が消えるY座標を下回ったら、隕石を非表示にする
            if (transform.position.y < destroyHeight)
            {
                this.gameObject.SetActive(false);
            }
        }

        /// <summary>
        /// リセットメソッド
        /// 隕石を元の位置に戻して表示する
        /// </summary>
        public void Reset()
        {
            this.gameObject.SetActive(true);
            transform.position = new Vector3(posX, posY, 0);
        }
    }
}