using UnityEngine;

namespace AnsNoDesignScene
{
    public class Debugger : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameSystem.IsGameOver = !GameSystem.IsGameOver;
                Debug.Log("Game Over status toggled: " + GameSystem.IsGameOver);
            }
        }
    }
}