using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miraLaser : MonoBehaviour
{
    public float distancia;
    LineRenderer laser;
    void Start()
    {
        laser = GetComponent<LineRenderer>();
    }

    void Update()
    {
        laser.SetPosition(0, transform.position);
        laser.SetPosition(1, transform.position + transform.forward * distancia);
    }
}
