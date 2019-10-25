using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Test.Ball
{
    public class BouncingObject : ClickableObject
    {
        public PhysicsMaterial2D physicMaterial;

        private void Awake()
        {
            GetComponent<BoxCollider2D>().sharedMaterial = physicMaterial;
        }

    }
}
