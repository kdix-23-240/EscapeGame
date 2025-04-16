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
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Meteorite"))
        {
            Debug.Log("Player collided with a meteorite!");
        }
    }
}