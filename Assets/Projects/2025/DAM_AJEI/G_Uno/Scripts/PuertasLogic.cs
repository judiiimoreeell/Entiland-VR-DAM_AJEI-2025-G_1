using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{
    public class PuertasLogic : MonoBehaviour
    {
        
        public Transform puerta;
        public float puntuationDoor = 100f;
        public float rotationSpeed = 90f;
        private bool isDoorOpen = false;
        public Collider triggerResetPlayer;

        void Start()
        {
            
        }

        void Update()
        {
            if (GameManager.Instance.puntuación >= puntuationDoor && !isDoorOpen)
            {
                StartCoroutine(OpenDoor());
                isDoorOpen = true;
            }

        }
        IEnumerator OpenDoor()
        {
            float targetRotation = -90f;
            float currentRotation = 0f;
            triggerResetPlayer.enabled = false;
            while (currentRotation > targetRotation)
            {
                puerta.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
                currentRotation -= rotationSpeed * Time.deltaTime;
                yield return null;
            }
        }
    }
}
