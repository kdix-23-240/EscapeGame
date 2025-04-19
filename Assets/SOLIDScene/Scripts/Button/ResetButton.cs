using UnityEngine;

namespace SOLIDScene
{
    /// <summary>
    /// リセットボタンのクラス
    /// このクラスは特に何もしない
    /// </summary>
    public class ResetButton : MonoBehaviour
    {
        public GameObject playerPrefab;
        public GameObject meteoritesPrefab;

        void Start()
        {
            transform.parent.gameObject.SetActive(false);
        }
        public void OnClick()
        {
            playerPrefab.GetComponent<Player>().Reset();
            for (int i = 0; i < meteoritesPrefab.transform.childCount; i++)
            {
                meteoritesPrefab.transform.GetChild(i).GetComponent<Meteorite>().Reset();
            }
            GameSystem.IsGameOver = false;
            transform.parent.gameObject.SetActive(false);
            FindFirstObjectByType<TextManager>().ResetTimeCount();
        }
    }
}