using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
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
    public Transform galexy ;
    public Transform saturn;
    public Transform uranus;
    public Transform neptune;


    public RawImage mercuryFact;
    public RawImage venusFact;
    public RawImage earthFact;
    public RawImage marsFact;
    public RawImage jupiterFact;
    public RawImage saturnFact;
    public RawImage uranusFact;
    public RawImage neptuneFact;





    public static bool saturnTarget;
    public static bool uranusTarget;
    public static bool neptuneTarget;
    public static bool earthMoon1Target;
    public static bool earthMoon2Target;
    public static bool earthMoon3Target;
    public static bool mecuryMoonTarget;
    public static bool juiptiorMoon1Target;
    public static bool juiptiorMoon2Target;
    public static bool juiptiorMoon3Target;
    public static bool marsMoonTarget;
    public static bool mercuryTarget;
    public static bool juiptiorTarget;
    public static bool venusTarget;
    public static bool marsTarget;
    public static bool earthTarget;
    public static bool sunTarget;
    public static bool galexyTarget = true;
    float yaw = 0;
    // Update is called once per frame
    void Update()
    {
      //  CurrentCameraTarget();
    }

    
    
    public void EarthTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget= false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = true;
        sunTarget = false;
        galexyTarget = false;
    }
   
    
  
  
  
    public void MercuryTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = true;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void JuiptiorTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = true;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void VenusTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = true;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }

    public void MarsTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = true;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }

    public void GalexyTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = true;
    }
    public void SaturnTarget()
    {
        saturnTarget = true;
        uranusTarget = false;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void UranusTarget()
    {
        saturnTarget = false;
        uranusTarget = true;
        neptuneTarget = false;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    public void NeptuneTarget()
    {
        saturnTarget = false;
        uranusTarget = false;
        neptuneTarget = true;
        earthMoon1Target = false;
        earthMoon2Target = false;
        earthMoon3Target = false;
        mecuryMoonTarget = false;
        juiptiorMoon1Target = false;
        juiptiorMoon2Target = false;
        juiptiorMoon3Target = false;
        marsMoonTarget = false;
        mercuryTarget = false;
        juiptiorTarget = false;
        venusTarget = false;
        marsTarget = false;
        earthTarget = false;
        sunTarget = false;
        galexyTarget = false;
    }
    private void CurrentCameraTarget()
    {
        
        if (earthTarget == true)
        {
            Vector3 vectorToTarget = earth.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptior == true)
        {
            Vector3 vectorToTarget = juiptior.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (juiptiorTarget == true)
        {
            Vector3 vectorToTarget = juiptior.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        
        if (mercuryTarget == true)
        {
            Vector3 vectorToTarget = mercury.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (marsMoonTarget == true)
        {
            Vector3 vectorToTarget = marsMoon.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (marsTarget == true)
        {
            Vector3 vectorToTarget = mars.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }

        if (venusTarget == true)
        {
            Vector3 vectorToTarget = venus.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }

       
        if (galexyTarget == true)
        {
            Vector3 vectorToTarget = galexy.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (saturnTarget == true)
        {
            Vector3 vectorToTarget = saturn.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (uranusTarget == true)
        {
            Vector3 vectorToTarget = uranus.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
        if (neptuneTarget == true)
        {
            Vector3 vectorToTarget = neptune.position - transform.position;
            yaw = Mathf.Atan2(vectorToTarget.x, vectorToTarget.z);
            Quaternion desiredRotation = Quaternion.LookRotation(vectorToTarget);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRotation, 90 * Time.deltaTime);
            // Quaternion.FromToRotation()
        }
    }
}
