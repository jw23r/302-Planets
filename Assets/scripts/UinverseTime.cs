using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UinverseTime : MonoBehaviour
{
    public bool normal = true;
    public bool fastFoward;
    public bool rewind;
    public static float worldTime;
    int rewindspeed = 1;
    int fastfowardspeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WTime();
       // print(worldTime);
    }

    public void WTime()
    {
       if(normal == true) worldTime += Time.deltaTime;
        if (fastFoward == true) worldTime += (fastfowardspeed * Time.deltaTime);
        if (rewind == true) worldTime -= rewindspeed * Time.deltaTime;
    }
    public void StopTime()
    {
        if (fastfowardspeed > 16) fastfowardspeed = 16;
        normal = false;
        fastFoward = false;
        rewind = false;
        rewindspeed = 1;
        fastfowardspeed = 1;
        
    }
    public void FastFoward()
    {
        normal = false;
        fastFoward = true;
        rewind = false;
        rewindspeed = 1;
        fastfowardspeed += 2;
    }
    public void Normal()
    {
        normal = true;
        fastFoward = false;
        rewind = false;
        rewindspeed = 1;
        fastfowardspeed = 1;
    }
    public void Rewind()
    {
        if (rewindspeed > 16) rewindspeed = 16;
        normal = false;
        fastFoward = false;
        rewind = true;
        fastfowardspeed = 1;
        rewindspeed +=  2;
    }
}
