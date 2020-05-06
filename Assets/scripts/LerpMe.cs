using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMe : MonoBehaviour
{

    // Start is called before the first frame update
    public Transform galxay;
    public Transform earthMoon1;
    public Transform earthMoon2;
    public Transform earthMoon3;
    public Transform mecuryMoon;
    public Transform juiptiorMoon1;
    public Transform juiptiorMoon2;
    public Transform juiptiorMoon3;
    public Transform marsMoon;
    public Transform mercury;
    public Transform juiptior;
    public Transform venus;
    public Transform mars;
    public Transform earth;
    public Transform sun;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;

    public float percent = 0.7f;
    bool isPlayingFoward = true;
    public AnimationCurve curve;
    public float chase;
    public float animationTime = 2;
    float animationTimeCurrent = 0;
    Vector3 currentEaseTarget;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
       /* if (isPlayingFoward)
        {
animationTimeCurrent += Time.deltaTime;
            if (animationTimeCurrent > animationTime) isPlayingFoward = false;
        }
        else
        {
            animationTimeCurrent -= Time.deltaTime;
            if (animationTimeCurrent < 0) isPlayingFoward = true;
        }
       
        percent = animationTimeCurrent / animationTime;*/
        Calcposition();
      
    }
    void OnVailidate()
        {
        Calcposition();
    }
    /// <summary>
     /// this function calculates the final postion
     /// of this object between two sperate locations
     /// </summary>
    void Calcposition()
    {
        
        // transform.position = AnimiMath.Lerp(postionA.position, postionB.position, percent);
       float p = curve.Evaluate(percent);
        //find target postion
      if(Rotator.earthMoon1Target == true)  currentEaseTarget = AnimiMath.Lerp(galxay.position, earthMoon1.position, p);
        if (Rotator.galexyTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, galxay.position, p);
        if (Rotator.earthMoon2Target == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, earthMoon2.position, p);
        if (Rotator.earthMoon3Target == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, earthMoon3.position, p);
        if (Rotator.mecuryMoonTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, mecuryMoon.position, p);
        if (Rotator.mercuryTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, mercury.position, p);
        if (Rotator.juiptiorMoon1Target == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, juiptiorMoon1.position, p);
        if (Rotator.juiptiorMoon2Target == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, juiptiorMoon2.position, p);
        if (Rotator.juiptiorMoon3Target == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, juiptiorMoon3.position, p);
        if (Rotator.juiptiorTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, juiptior.position, p);
        if (Rotator.marsMoonTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, marsMoon.position, p);
        if (Rotator.marsTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, mars.position, p);
        if (Rotator.venusTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, venus.position, p);
        if (Rotator.sunTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, sun.position, p);
        if (Rotator.saturnTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, saturn.position, p);
        if (Rotator.uranusTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, uranus.position, p);
        if (Rotator.neptuneTarget == true) currentEaseTarget = AnimiMath.Lerp(galxay.position, neptune.position, p);

        


        //ease twoard target
        transform.position = AnimiMath.Dampen(transform.position,currentEaseTarget, .005f);
        //transform.position +=()
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(currentEaseTarget, Vector3.one* .1f);
    }
}
