using UnityEngine;

namespace NoDesignScene
{
    public class Player : MonoBehaviour
    {
        void Update()
        {
            if (GameSystem.IsGameOver)
            {
                return;
            }

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
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Falling"))
            {
                // Debug.Log("Player collided with a meteorite!");
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