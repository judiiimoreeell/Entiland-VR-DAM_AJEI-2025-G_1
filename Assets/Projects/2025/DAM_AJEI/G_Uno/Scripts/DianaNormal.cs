using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno {

    public class DianaNormal : MonoBehaviour
    {
        public float points;
        bool die;
        Rigidbody body;
        // Start is called before the first frame update
        void Start()
        {
            body = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void Damage()
        {
            if(!die)
            {
                die = true;
                Destroy(gameObject, 1);
                GameManager.Instance.AddPoints(points);
                body.useGravity = true;
                transform.parent = null;

            }
        }
    }
}
