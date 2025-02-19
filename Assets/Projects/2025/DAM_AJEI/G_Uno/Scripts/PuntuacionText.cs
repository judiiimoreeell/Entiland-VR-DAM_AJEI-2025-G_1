using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EntilandVR.DosCinco.DAM_AJEI.G_Uno
{

    
    public class PuntuacionText : MonoBehaviour
    {
        [SerializeField]  TMP_Text text;
        // Start is called before the first frame update
        void Start()
        {
            text = GetComponent<TMP_Text>();
            
        }

        // Update is called once per frame
        void Update()
        {
            text.text = GameManager.Instance.puntuación.ToString();
        }
    }
}