using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenarioController : MonoBehaviour
{

    public Transform agua;
    public Transform jogador;
    public Color corDaAgua;

    void Start()
    {
        
    }

    void Update()
    {
        if (jogador.position.y < agua.position.y)
        {
            //dentro da água
            RenderSettings.fog = true;
            RenderSettings.fogMode = FogMode.Exponential;
            RenderSettings.fogDensity = 0.1f;
            RenderSettings.fogColor = corDaAgua;
        }
        else
        {
            //fora da água
            RenderSettings.fog = false;
        }
    }
}
