using UnityEngine;

public class Meteorite : MonoBehaviour
{
    public float speed = 5f; // Speed of the meteorite
    public float destroyHeight = -10f; // Height at which the meteorite will be destroyed

    void Update()
    {
        if (GameSystem.IsGameOver)
        {
            return;
        }

        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }
    }
}