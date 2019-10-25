using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Ball
{

    public class BallCtrl : MonoBehaviour
    {
        public static BallCtrl instance;

        [SerializeField]
        float touchSensetivity = 10f;

        private Rigidbody2D ballRigidBody;

        private void Awake()
        {
            if (instance != null)
            {
                if (instance != this)
                {
                    Destroy(this.gameObject);
                }
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
        }
        void Start()
        {
            ballRigidBody = GetComponent<Rigidbody2D>();
        }

        private void FixedUpdate()
        {
#if UNITY_STANDALONE || UNITY_EDITOR

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                pos.z = 0;
                Vector3 delta = pos - transform.position;
                delta.y = 0;
                ballRigidBody.AddForce(delta * touchSensetivity);


            }

#elif UNITY_ANDROID
            if (Input.touchCount > 0)
            {
                Vector3 pos = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
                pos.z = 0;
                Vector3 delta = pos - transform.position;
                delta.y = 0;
                ballRigidBody.AddForce(delta * touchSensetivity);

            }

#endif
        }



    }
}
