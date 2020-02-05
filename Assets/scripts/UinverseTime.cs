using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UinverseTime : MonoBehaviour
{
    public bool normal = true;
    public bool fastFoward;
    public bool rewind;
    public static float worldTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WTime();
        print(worldTime);
    }

    public void WTime()
    {
       if(normal == true) worldTime += Time.deltaTime;
        if (fastFoward == true) worldTime += (2 * Time.deltaTime);
        if (rewind == true) worldTime -= Time.deltaTime;
    }
    public void StopTime()
    {
        normal = false;
        fastFoward = false;
        rewind = false;
    }
    public void FastFoward()
    {
        normal = false;
        fastFoward = true;
        rewind = false;
    }
    public void Normal()
    {
        normal = true;
        fastFoward = false;
        rewind = false;
    }
    public void Rewind()
    {
        normal = false;
        fastFoward = false;
        rewind = true;
    }
}
