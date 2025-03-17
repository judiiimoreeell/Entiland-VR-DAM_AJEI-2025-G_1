using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{


    public class GameManager : MonoBehaviour
    {
    
        public static GameManager Instance {  get; private set; }
        public GameObject dianaRota;
        [SerializeField] TMP_Text PuntuacionVagoneta;

        // Start is called before the first frame update

        public float puntuación = 0;
        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        
        }
        public void AddPoints(float points)
        {
            puntuación += points;
            if(PuntuacionVagoneta != null)
            {
                PuntuacionVagoneta.text = puntuación.ToString();

            }
        }
        public void SubstractPoints(float points)
        {
            puntuación -= points;
            PuntuacionVagoneta.text = puntuación.ToString();
        }
    }
}
