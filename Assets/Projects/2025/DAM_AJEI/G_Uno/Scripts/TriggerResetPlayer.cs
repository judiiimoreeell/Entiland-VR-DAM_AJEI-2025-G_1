using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{
    public class TriggerResetPlayer : MonoBehaviour
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
            print("Ha entrado");

            if (other.gameObject.CompareTag("Obstacle"))
            {
                print("AAA");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }




    }
}
