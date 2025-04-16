using UnityEngine;

public class Player : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
        if (GameSystem.IsGameOver)
        {
            return;
        }

        if (-8 < this.gameObject.transform.position.x)
        {
            if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                this.gameObject.transform.position += new Vector3(-2, 0, 0);
            }
        }

        if (this.gameObject.transform.position.x < 8)
        {
            if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                this.gameObject.transform.position += new Vector3(2, 0, 0);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteorite"))
        {
            Debug.Log("Player collided with a meteorite!");
            // GameSystem.IsGameOver = true;
            // this.gameObject.SetActive(false);
            Destroy(collision.gameObject);
        }
    }

    // public void Reset()
    // {
    //     this.gameObject.transform.position = new Vector3(0, -4, 0);
    //     this.gameObject.SetActive(true);
    // }
}