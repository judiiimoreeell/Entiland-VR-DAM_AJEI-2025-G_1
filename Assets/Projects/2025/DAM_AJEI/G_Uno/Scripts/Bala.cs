using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{

    public class Bala : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnTriggerEnter(Collider other)
        {
            DianaNormal d = other.gameObject.GetComponent<DianaNormal>();

            if (d != null) {
                d.Damage();
            }
        }

    }
}