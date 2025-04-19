using UnityEngine;

namespace SOLIDScene
{
    public class Meteorite : MonoBehaviour
    {
        private float posX;
        private float posY;
        private IMovable moveable;

        void Start()
        {
            posX = this.gameObject.transform.position.x;
            posY = this.gameObject.transform.position.y;

            moveable = this.gameObject.GetComponent<IMovable>();
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

        public void Reset()
        {
            this.gameObject.SetActive(true);
            transform.position = new Vector3(posX, posY, 0);
        }
    }
}