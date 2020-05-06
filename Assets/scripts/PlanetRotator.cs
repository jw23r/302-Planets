using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotator : MonoBehaviour
{
    public Vector3 roatation;
     float angle;
    public float startAngle;
    // Start is called before the first frame update
    void Start()
    {
        angle = startAngle;
    }

    // Update is called once per frame
    void Update()
    {
      
        transform.Rotate(roatation, angle);
    }
}
