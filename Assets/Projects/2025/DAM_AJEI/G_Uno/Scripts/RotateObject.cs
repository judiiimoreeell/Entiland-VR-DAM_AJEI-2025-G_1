using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{
    public class RotateObject : MonoBehaviour
    {
        public Vector3 rotation;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void FixedUpdate()
        {
            transform.Rotate(rotation * Time.fixedDeltaTime);
        }
    }
}