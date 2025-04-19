using UnityEngine;

namespace SOLIDScene
{
    public class Player : MonoBehaviour
    {
        private IMovable movable;

        void Start()
        {
            movable = this.gameObject.GetComponent<IMovable>();
        }

        /// <summary>
        /// 1. ゲームオーバーなら即リターン
        /// 2. IMovableインターフェースのMoveメソッドを呼び出す
        /// </summary>
        void Update()
        {
            // **ここに処理を書く**

            // **ここに処理を書く**
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

        public void Reset()
        {
            this.gameObject.transform.position = new Vector3(0, -2, 0);
            this.gameObject.SetActive(true);
        }
    }
}