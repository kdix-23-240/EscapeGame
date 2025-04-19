using UnityEngine;

namespace AnsSOLIDScene
{
    public class Meteorite : MonoBehaviour
    {
        private float posX;
        private float posY;
        private IMovable moveable;

        void Start()
        {
            posX = this.gameObject.transform.position.x;
            posY = this.gameObject.transform.position.y;

            moveable = this.gameObject.GetComponent<IMovable>();
        }

        void Update()
        {
            if (GameSystem.IsGameOver)
            {
                return;
            }

            Debugger.Log("Meteorite Update called");

            moveable.Move();

            Debugger.Log("Meteorite Move called");
        }

        public void Reset()
        {
            this.gameObject.SetActive(true);
            transform.position = new Vector3(posX, posY, 0);
        }
    }
}