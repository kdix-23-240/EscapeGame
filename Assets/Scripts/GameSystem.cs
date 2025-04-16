using UnityEngine;
using UnityEngine.UI;

public class GameSystem : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject ResetButtonPrefab;
    [SerializeField] private Text score;
    [SerializeField] private Text time;
    public static bool IsGameOver;
    private float timeCount = 0f;
    void Start()
    {
        IsGameOver = false;
        time.text = "0";
    }

    void Update()
    {
        if (IsGameOver)
        {
            Debug.Log("Game Over!");
            ResetButtonPrefab.SetActive(true);
            score.text = ((int)timeCount * 100000).ToString();
            return;
        }

        if (!IsGameOver)
        {
            timeCount += Time.deltaTime;
            time.text = ((int)timeCount).ToString();
        }
    }

    public void ResetTimeCount()
    {
        timeCount = 0f;
    }
}