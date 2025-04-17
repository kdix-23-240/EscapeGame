using UnityEngine;

namespace SOLIDScene
{
    public class Meteorite : MonoBehaviour
    {
        private float posX;
        private float posY;
        public IMovable moveable;

        void Start()
        {

            posX = this.gameObject.transform.position.x;
            posY = this.gameObject.transform.position.y;
        }

        void Update()
        {
            if (GameSystem.IsGameOver)
            {
                return;
            }

            moveable.Move();
        }

        public void Reset()
        {
            this.gameObject.SetActive(true);
            transform.position = new Vector3(posX, posY, 0);
        }
    }
}