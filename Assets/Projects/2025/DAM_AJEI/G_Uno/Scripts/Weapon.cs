using EntilandVR.DosCinco.DAM_AJEI.G_Uno;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{
    public class Weapon : MonoBehaviour
    {
        public Rigidbody body;

        public Transform barrelTip;
        public float hitPower = 1;
        public float recoilPower = 1;
        public float range = 100;
        public LayerMask layer;

        public AudioClip shootSound;
        public float shootVolume = 1f;

        public GameObject bala;

        public Transform shootPoint;

        public float shootPower = 1000;
        private void Start()
        {
            if (body == null && GetComponent<Rigidbody>() != null)
                body = GetComponent<Rigidbody>();
        }

        public void Shoot()
        {
            //Play the audio sound
            if (shootSound)
                AudioSource.PlayClipAtPoint(shootSound, transform.position, shootVolume);

            RaycastHit hit;
            if (Physics.Raycast(barrelTip.position, barrelTip.forward, out hit, range, layer))
            {
                //var hitBody = hit.transform.GetComponent<Rigidbody>();
                //if (hitBody != null)
                {
                    //Debug.DrawRay(barrelTip.position, (hit.point - barrelTip.position), Color.green, 5);
                    //hitBody.GetComponent<Smash>()?.DoSmash();
                    //hitBody.AddForceAtPosition((hit.point - barrelTip.position).normalized * hitPower * 10, hit.point, ForceMode.Impulse);

                }
                DianaNormal d = hit.collider.gameObject.GetComponent<DianaNormal>();

                if (d)
                {
                    //d.Damage();



                }
            }
            else
                Debug.DrawRay(barrelTip.position, barrelTip.forward * range, Color.red, 1);



            GameObject balaInstance = Instantiate(bala, shootPoint.position, shootPoint.rotation);
            balaInstance.GetComponent<Rigidbody>().AddForce(balaInstance.transform.forward * shootPower);
            Destroy(balaInstance, 5);
            body.AddForce(-barrelTip.transform.up * recoilPower * 5, ForceMode.Impulse);
        }
    }

}