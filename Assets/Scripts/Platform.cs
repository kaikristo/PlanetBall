
using UnityEngine;
namespace Test.Ball
{
    public class Platform : ClickableObject
    {


        private SpriteRenderer spriteRenderer;
        

        void Start()
        {
            spriteRenderer = GetComponent<SpriteRenderer>();

                SetRandomColor();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SetRandomColor();
        }
        private void Update()
        {
            if (isTouched())
            {
                SetRandomColor();
            }

        }

        private void SetRandomColor()
        {
            spriteRenderer.color = Random.ColorHSV();
        }
    }
}
