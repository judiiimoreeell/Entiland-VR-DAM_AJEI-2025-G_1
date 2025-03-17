using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;


namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{



    public class Bagoneta_spline : MonoBehaviour
    {
        float contador;
        public SplineAnimate spline;
        public SplineContainer newContainer;
        public SplineContainer secondContainer;
        float maxTimer;
        float secondMaxTimer;
        bool canCount = false;
        bool doOnce = true;
        // Start is called before the first frame update
        void Start()
        {
            spline = GetComponent<SplineAnimate>();
            maxTimer = 40f;
            secondMaxTimer = 90f;

        }

        // Update is called once per frame
        void Update()
        {




        }
        public void StartGame()
        {
            spline.Play();
            canCount = true;
            AudioManager.Instance.VagonetaSound.Play();

        }
    }
}