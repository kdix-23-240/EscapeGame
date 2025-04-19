using UnityEngine;

namespace SOLIDScene
{
    public class PlayerMove : MonoBehaviour, IMovable
    {
        public void Move()
        {
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
    }
}