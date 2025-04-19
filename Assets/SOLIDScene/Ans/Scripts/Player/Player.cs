using UnityEngine;

namespace AnsSOLIDScene
{
    public class Player : MonoBehaviour
    {
        private IMovable movable;

        void Start()
        {
            movable = this.gameObject.GetComponent<IMovable>();
        }

        void Update()
        {
            if (GameSystem.IsGameOver)
            {
                return;
            }

            movable.Move();
        }
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Falling"))
            {
                GameSystem.IsGameOver = true;
                this.gameObject.SetActive(false);
                collision.gameObject.SetActive(false);
            }
        }

        public void Reset()
        {
            this.gameObject.transform.position = new Vector3(0, -2, 0);
            this.gameObject.SetActive(true);
        }
    }
}