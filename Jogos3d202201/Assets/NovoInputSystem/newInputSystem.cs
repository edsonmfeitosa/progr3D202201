using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

public class newInputSystem : MonoBehaviour
{
    public Vector2 valorInput;
    public float valorPulo;
    InputSystemManager entrada;

    private void Awake()
    {
        entrada = new InputSystemManager();
    }
    private void OnEnable()
    {
        entrada.Enable();
    }
    private void OnDisable()
    {
        entrada.Disable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        //exemplo de utilização do obj do novo Input System
        //entrada.Jogador.Pular.ReadValue<float>();
    }
    public void mover(CallbackContext context)
    {
        //Debug.Log("apertou a tecla: "+context.control.displayName);
        valorInput = context.ReadValue<Vector2>();
        if (context.started)
        {
            Debug.Log("Started: " + context.control.displayName);
        }
        if (context.performed)
        {
            Debug.Log("Performed: " + context.control.displayName);
        }
        if (context.canceled)
        {
            Debug.Log("Canceled: " + context.control.displayName);
        }
    }
    public void pulo(CallbackContext context)
    {
        Debug.Log("pulou");
        valorPulo = context.ReadValue<float>();
    }
}
