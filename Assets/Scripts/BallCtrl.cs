using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Ball
{

    public class BallCtrl : MonoBehaviour
    {
        private Rigidbody2D ballRigidBody;

        void Start()
        {
            ballRigidBody = GetComponent<Rigidbody2D>();
        }

    }
}
