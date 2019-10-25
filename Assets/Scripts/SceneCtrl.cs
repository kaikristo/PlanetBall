using UnityEngine;
using UnityEngine.SceneManagement;

namespace Test.Ball
{
    public class SceneCtrl : MonoBehaviour
    {
        public static SceneCtrl instance;
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
        public void LoadScene(Scene scene)
        {
            SceneManager.LoadScene((int)scene);
            if (scene != Scene.Menu)
            {
                if (BallCtrl.instance != null)
                {
                    BallCtrl.instance.gameObject.SetActive(true);
                }
            }
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                int index = SceneManager.GetActiveScene().buildIndex;
                if (index == (int)Scene.Menu)
                {
                    Application.Quit();
                }
                else
                {
                    if (BallCtrl.instance != null)
                    {
                        BallCtrl.instance.gameObject.SetActive(false);
                    }
                    LoadScene(Scene.Menu);
                }
            }



        }

    }
    public enum Scene
    {
        Menu = 0,
        Eath = 1,
        Moon = 2,
        Jupiter = 3
    };
}

