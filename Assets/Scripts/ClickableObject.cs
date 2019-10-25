using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Test.Ball
{
    public abstract class ClickableObject : MonoBehaviour
    {

        protected bool isTouched()
        {
#if UNITY_EDITOR || UNITY_STANDALONE

            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hitInfo.collider != null)
                {
                    if (hitInfo.collider.gameObject == this.gameObject)
                    {
                        return true;
                    }
                }
            }
            return false;
#elif UNITY_ANDROID
             for (var i = 0; i < Input.touchCount; i++)
            {
                if (Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);
                    if (hitInfo.collider!= null)
                    {        
                        if (hitInfo.collider.gameObject == this.gameObject)
                        {
                        return true;
                        }
                    }
                }

            }
            return false;
#endif
        }
    }

}