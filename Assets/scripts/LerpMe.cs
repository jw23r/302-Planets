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
    public float speed = 1;
    public float percent = 0.7f;
    bool isPlayingFoward = true;
    public AnimationCurve curve;
    public float chase;
    Vector3 offset;
    public float animationTime = 2;
    float animationTimeCurrent = 0;
    Vector3 currentEaseTarget;
    float p;
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
      p = curve.Evaluate(percent);
        //find target postion

        if (Rotator.galexyTarget == true)
        {
            offset = new Vector3(-850, 500,0);
            currentEaseTarget = sun.position;
        }
        if (Rotator.mercuryTarget == true)
        {
            offset = new Vector3(-20, 10, 0);
currentEaseTarget = mercury.position;

        }
            if (Rotator.juiptiorTarget == true) {
            offset = new Vector3(-55, 50, 0);
            currentEaseTarget = juiptior.position;
        }

        if (Rotator.marsTarget == true)
        {
            offset = new Vector3(-15, 10, 0);

            currentEaseTarget = mars.position;
        }
        if (Rotator.venusTarget == true)
        {
            offset = new Vector3(-16, 10, 0);

            currentEaseTarget = venus.position;
        }
        if (Rotator.sunTarget == true)
        {
            offset = new Vector3(-15, 10, 0);
            currentEaseTarget = sun.position;
        }
        if (Rotator.saturnTarget == true)
        {
            offset = new Vector3(-30, 20, 0);

            currentEaseTarget = saturn.position;
        }
        if (Rotator.uranusTarget == true)
        {
            offset = new Vector3(-15, 10, 0);

            currentEaseTarget = uranus.position;
        }
        if (Rotator.neptuneTarget == true)
        {
            offset = new Vector3(-15, 10, 0);
            currentEaseTarget = neptune.position;
        }
        if (Rotator.earthTarget == true) {
            
            offset = new Vector3(-10, 10, 0);
            
            currentEaseTarget = earth.position;
            

        }

        //  print(currentEaseTarget);



        Vector3 targetDirection = AnimiMath.Dampen(transform.position, currentEaseTarget, 1);

        // The step size is equal to speed times frame time.
        float singleStep = speed * Time.deltaTime;

        // Rotate the forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
        //ease twoard target
        transform.position = Vector3.MoveTowards(transform.forward,currentEaseTarget + offset, singleStep);
        //transform.position +=()
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(currentEaseTarget, Vector3.one* .1f);
    }
    public void SetPToZero()
    {
        p = 0;
    }

}
