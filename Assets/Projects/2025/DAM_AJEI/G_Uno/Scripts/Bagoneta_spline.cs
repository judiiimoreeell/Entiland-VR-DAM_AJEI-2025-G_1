using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Splines;
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
        
        if(contador < maxTimer && canCount)
        {
            contador += Time.deltaTime;
        }
        else if (contador > secondMaxTimer && canCount)
        {
            spline.Container = secondContainer;
            spline.NormalizedTime = 0f;
        }
        else if(contador > maxTimer && canCount)
        {


            if (doOnce)
            {
                spline.NormalizedTime = 0f;
                doOnce = false;
                spline.Container = newContainer;
                spline.Duration = 50f;
            }
            

            contador += Time.deltaTime;

        }

        
    }
    public void StartGame()
    {
        spline.Play();
        canCount = true;

    }
}
