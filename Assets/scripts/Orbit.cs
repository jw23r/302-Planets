using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]
public class Orbit : MonoBehaviour
{
    public float unCoplaner;
    public Transform orbitCenter;
    public LineRenderer orbitPath;
    [Range(0, 1000)] public float radius = 6;
    [Range(4, 48)] public int resolution = 8;
    public float planetSpeed = 1;
    public bool planet = true;
    
    // Start is called before the first frame update
    void Start()
    {
        orbitPath = GetComponent<LineRenderer>();
        orbitPath.loop = true;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = FindOrbitPoint(planetSpeed* UinverseTime.worldTime, radius, unCoplaner);
        transform.position = pos;
        UpdatePoints();
    }
    private Vector3 FindOrbitPoint(float angle, float mag, float magUnCoplaner)
    {
       
        Vector3 pos = (orbitCenter == null) ? Vector3.zero : orbitCenter.position;
        if (planet)
        {
            pos.x += Mathf.Cos(angle) * mag;
            pos.z += Mathf.Sin(angle) * mag;
        }
        else
        {
            pos.x += Mathf.Cos(angle) * magUnCoplaner;
            pos.z += Mathf.Sin(angle) * mag;
        }
        return pos;
    }
    void UpdatePoints()
    {
        
        Vector3[] points = new Vector3[resolution];
        for (int i = 0; i < points.Length; i++)
        {
            //calculate x,y,andz
            float p = i / (float)points.Length;
            float radians = p * Mathf.PI * 2;
            points[i] = FindOrbitPoint(radians, radius,unCoplaner);
        }
        orbitPath.positionCount = resolution;
        orbitPath.SetPositions(points);

    }

 
}