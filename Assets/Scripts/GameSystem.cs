using UnityEngine;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject ResetButtonPrefab;
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
            ResetButtonPrefab.SetActive(true);
        }
    }
}