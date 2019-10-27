using UnityEngine;
namespace Test.Ball
{
    public class GameCtrl : MonoBehaviour
    {
        public static GameCtrl instance;

        private int score = 0;

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

        public int GetScore()
        {
            return score;
        }

        public void AddScore(int value)
        {
            score += value;
        }
    }
}