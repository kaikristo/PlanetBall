using UnityEngine;

namespace Test.Ball
{
    public class PlanetCtrl : MonoBehaviour
    {
        [SerializeField]
        private string planetName;
        [SerializeField]
        private float gravity;
        [SerializeField]
        private Color skyColor;


        private void Awake()
        {
            Physics2D.gravity = new Vector2(0, -gravity);
            Camera.main.backgroundColor = skyColor;
        }
    }
}