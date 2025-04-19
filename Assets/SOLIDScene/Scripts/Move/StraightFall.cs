using UnityEngine;

namespace SOLIDScene
{
    public class StraightFall : MonoBehaviour, IMovable
    {
        public float speed = 5f; // 落下スピード
        public float destroyHeight = -10f; // 消去する高さ
        public void Move()
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (transform.position.y < destroyHeight)
            {
                this.gameObject.SetActive(false);
            }
        }
    }
}
