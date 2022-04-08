using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiraController : MonoBehaviour
{
    [Header("Laser")]
    public GameObject MiraLaser;
    public KeyCode habilitaLaser;
    bool laserHabilitado = false;
    [Header("Luneta")]
    public KeyCode habilitaLuneta;
    bool lunetaHabilitada = false;
    public Camera CameraLuneta;
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
        if (Input.GetKeyDown(habilitaLuneta))
        {
            lunetaHabilitada = !lunetaHabilitada;
            if (lunetaHabilitada)
            {
                CameraLuneta.depth = 1;
            }
            else
            {
                CameraLuneta.depth = 0;
            }
        }
    }
}
