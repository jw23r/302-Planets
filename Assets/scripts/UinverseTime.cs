using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UinverseTime : MonoBehaviour
{
    static public bool normal = true;
    static public bool fastFoward;
    static public bool rewind;
    public static float worldTime;
    static bool stoptime;
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
        if (stoptime == true) worldTime *= 0;
    }
    public void StopTime()
    {
        if (fastfowardspeed > 16) fastfowardspeed = 16;
        normal = false;
        fastFoward = false;
        rewind = false;
        stoptime = true;
        rewindspeed = 1;
        fastfowardspeed = 1;
        
    }
    public void FastFoward()
    {
        normal = false;
        fastFoward = true;
        rewind = false;
        stoptime = false;

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
        stoptime = false;

    }
    public void Rewind()
    {
        if (rewindspeed > 16) rewindspeed = 16;
        normal = false;
        fastFoward = false;
        rewind = true;
        stoptime = false;

        fastfowardspeed = 1;
        rewindspeed +=  2;
    }
}
