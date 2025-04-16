using UnityEngine;

public class GameSystem : MonoBehaviour
{
    public static bool IsGameOver;
    void Start()
    {
        IsGameOver = false;
    }

    void Update()
    {
        if (IsGameOver)
        {
            Debug.Log("Game Over!");
        }
    }
}