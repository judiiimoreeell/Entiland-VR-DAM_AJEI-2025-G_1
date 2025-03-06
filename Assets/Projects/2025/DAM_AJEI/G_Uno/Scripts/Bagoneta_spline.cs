using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
public class Bagoneta_spline : MonoBehaviour
{
    float contador;
    public SplineAnimate spline;
    public SplineContainer newContainer;
    float maxTimer;
    // Start is called before the first frame update
    void Start()
    {
        spline = GetComponent<SplineAnimate>();
        maxTimer = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        if(contador <= maxTimer)
        {
            contador += Time.deltaTime;
        }
        else
        {
            spline.Container = newContainer;
            spline.Duration = 50f;

            spline.NormalizedTime = 0f;
            spline.Play();

            contador = 0;
            maxTimer = 50f;
        }

    }
}
