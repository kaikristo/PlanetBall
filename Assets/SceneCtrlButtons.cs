using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Ball
{
    public class SceneCtrlButtons : MonoBehaviour
    {

        public void GoToTheEath()
        {
            SceneCtrl.instance.LoadScene(Scene.Eath);
        }
        public void GoToTheMoon()
        {
            SceneCtrl.instance.LoadScene(Scene.Moon);
        }
        public void GoToTheJupiter()
        {
            SceneCtrl.instance.LoadScene(Scene.Jupiter);
        }
    }
}
