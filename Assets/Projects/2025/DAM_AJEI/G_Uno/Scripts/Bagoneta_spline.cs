using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
public class Bagoneta_spline : MonoBehaviour
{
    float contador;
    public SplineAnimate spline;
    public SplineContainer newContainer;
    // Start is called before the first frame update
    void Start()
    {
        spline = GetComponent<SplineAnimate>();
    }

    // Update is called once per frame
    void Update()
    {
        if(contador <= 20)
        {
            contador += Time.deltaTime;
        }
        else
        {
            spline.Container = newContainer;

            spline.NormalizedTime = 0f;
            spline.Play();

            contador = 0;
        }

    }
}
