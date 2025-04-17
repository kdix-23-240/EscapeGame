using UnityEngine;

namespace SOLIDScene
{
    public class StraightFall : MonoBehaviour, IMovable
    {
        public float speed = 5f; // Speed of the meteorite
        public float destroyHeight = -10f; // Height at which the meteorite will be destroyed
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
