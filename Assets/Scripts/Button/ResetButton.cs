using UnityEngine;

public class ResetButton : MonoBehaviour
{
    [SerializeField] private GameObject playerPrefab;
    [SerializeField] private GameObject meteoritesPrefab;

    void Start()
    {
        transform.parent.gameObject.SetActive(false);
    }
    public void OnClick()
    {
        playerPrefab.GetComponent<Player>().Reset();
        for(int i = 0; i < meteoritesPrefab.transform.childCount; i++)
        {
            meteoritesPrefab.transform.GetChild(i).GetComponent<Meteorite>().Reset();
        }
        GameSystem.IsGameOver = false;
        transform.parent.gameObject.SetActive(false);
    }
}