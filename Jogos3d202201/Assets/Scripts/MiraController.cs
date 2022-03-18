using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraController : MonoBehaviour
{
    [Header("Laser")]
    public GameObject MiraLaser;
    public KeyCode habilitaLaser;
    bool laserHabilitado = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(habilitaLaser))
        {
            laserHabilitado = !laserHabilitado;
            if (laserHabilitado)
            {
                MiraLaser.SetActive(true);
                //MiraLaser.activeSelf ----> maneira de ver se o gameObject está ativo
            }
            else
            {
                MiraLaser.SetActive(false);
            }
        }
    }
}
