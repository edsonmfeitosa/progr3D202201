using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAviaoController : MonoBehaviour
{
    public GameObject cameraPrimeraPessoa;
    public GameObject cameraTerceiraPessoa;
    public GameObject cameraRetrovisor;
    public AviaoController aviao;
    public KeyCode habilita3Pessoa;
    bool habilita3P = false;
    public KeyCode habilitaRetrovisor;
    bool habilitaRetro = false;
    void Start()
    {
        
    }


    void Update()
    {
        if (aviao.ligado)
        {
            cameraPrimeraPessoa.SetActive(true);
            cameraTerceiraPessoa.SetActive(true);
            cameraRetrovisor.SetActive(true);
        }
        else
        {
            cameraPrimeraPessoa.SetActive(false);
            cameraTerceiraPessoa.SetActive(false);
            cameraRetrovisor.SetActive(false);
        }
        trocaCamera();
        mostraRetrovisor();
    }

    private void mostraRetrovisor()
    {
        if (Input.GetKeyDown(habilitaRetrovisor))
        {
            habilitaRetro = !habilitaRetro;
            if (habilitaRetro)
                cameraRetrovisor.GetComponent<Camera>().depth = 2;
            else
                cameraRetrovisor.GetComponent<Camera>().depth = 0;
        }
    }

    void trocaCamera()
    {
        if (Input.GetKeyDown(habilita3Pessoa))
        {
            habilita3P = !habilita3P;
            if (habilita3P)
            {
                cameraTerceiraPessoa.GetComponent<Camera>().depth = 1;
                cameraPrimeraPessoa.GetComponent<Camera>().depth = 0;
            }
            else
            {
                cameraTerceiraPessoa.GetComponent<Camera>().depth = 0;
                cameraPrimeraPessoa.GetComponent<Camera>().depth = 1;
            }
        }
    }
}
