using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Ball
{
    public class PlanetCtrl : MonoBehaviour
    {
        [SerializeField]
        string planetName;
        [SerializeField]
        float gravity;
        [SerializeField]
        Color skyColor;


        private void Awake()
        {
            Physics2D.gravity = new Vector2(0, -gravity);
            Camera.main.backgroundColor = skyColor;
        }
    }
}