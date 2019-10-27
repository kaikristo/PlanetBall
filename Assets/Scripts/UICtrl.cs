using UnityEngine;
using UnityEngine.UI;

namespace Test.Ball
{
    public class UICtrl : MonoBehaviour
    {
        [SerializeField]
        Text scoreText;
        private const string ScoreNameText = "Очки :";
        void Start()
        {
            RefreshUI();
        }

        private void RefreshUI()
        {
            scoreText.text = ScoreNameText + GameCtrl.instance.GetScore().ToString();
        }
    }
}