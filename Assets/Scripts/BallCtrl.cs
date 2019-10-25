using UnityEngine;

namespace Test.Ball
{

    public class BallCtrl : MonoBehaviour
    {
        public static BallCtrl instance;

        [SerializeField]
        private float touchSensetivity = 10f;

        private Rigidbody2D ballRigidBody;
        private Vector3 velocity;
        private void Awake()
        {
            ballRigidBody = GetComponent<Rigidbody2D>();
            velocity = Vector3.zero;

            if (instance != null)
            {
                if (instance != this)
                {
                    Destroy(this.gameObject);
                    return;
                }
            }
            else
            {
                instance = this;
                DontDestroyOnLoad(this);
            }

        }
        private void OnEnable()
        {
            Debug.Log("enable");
            ballRigidBody.velocity = velocity;
            Debug.Log(velocity);
        }
        private void OnDisable()
        {
            Debug.Log("disable");
            velocity = ballRigidBody.velocity;
            Debug.Log(velocity);
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
                if (Input.touches[0].phase == TouchPhase.Began)
                {
                    Vector3 pos = Camera.main.ScreenToWorldPoint(Input.touches[0].position);
                    pos.z = 0;
                    Vector3 delta = pos - transform.position;
                    delta.y = 0;
                    ballRigidBody.AddForce(delta * touchSensetivity);
                }
            }

#endif
        }



    }
}
