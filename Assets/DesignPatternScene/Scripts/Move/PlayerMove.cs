using UnityEngine;

namespace DesignPatternScene
{
    public class PlayerMove : MonoBehaviour, IMovable
    {
        public void Move()
        {
            if (-8 < this.gameObject.transform.position.x)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
                {
                    this.gameObject.transform.position += new Vector3(-2, 0, 0);
                }
            }

            if (this.gameObject.transform.position.x < 8)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
                {
                    this.gameObject.transform.position += new Vector3(2, 0, 0);
                }
            }
        }
    }
}