//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/NovoInputSystem/InputSystemManager.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputSystemManager : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemManager"",
    ""maps"": [
        {
            ""name"": ""Jogador"",
            ""id"": ""50d100d3-c413-4fc9-9f7e-ca88a5f02786"",
            ""actions"": [
                {
                    ""name"": ""Movimento"",
                    ""type"": ""Value"",
                    ""id"": ""d8e6517a-7ef2-4852-ba10-89eb3aa08f84"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pular"",
                    ""type"": ""Button"",
                    ""id"": ""a9566205-7052-4b93-8135-64e029029add"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Direcao"",
                    ""id"": ""6fb4ceed-029b-4159-810b-91d073974728"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4ceb4cf-f89f-463e-9d29-30f2d108a4be"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""675f42b7-64d3-4b75-b716-c132ccb86335"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""73c69962-50f4-453f-b1d8-76f365da7cfd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""102371c1-3144-48f8-8f77-3dcb9bae472d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Setas"",
                    ""id"": ""813dfafb-1a91-42f0-bcc3-83d0764ea9b4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""958e23ee-75d7-4704-8143-fd1a2ac20732"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6c2f7645-cf1b-4432-b0f8-aa4f72914d4a"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4b525d99-362c-47b4-bf31-0108b03bb73d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c92966d8-7aa9-402c-b072-b85a8b26c3d4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movimento"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d81f83ea-910b-49fc-a41b-908573e29bf6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pular"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Jogador
        m_Jogador = asset.FindActionMap("Jogador", throwIfNotFound: true);
        m_Jogador_Movimento = m_Jogador.FindAction("Movimento", throwIfNotFound: true);
        m_Jogador_Pular = m_Jogador.FindAction("Pular", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Jogador
    private readonly InputActionMap m_Jogador;
    private IJogadorActions m_JogadorActionsCallbackInterface;
    private readonly InputAction m_Jogador_Movimento;
    private readonly InputAction m_Jogador_Pular;
    public struct JogadorActions
    {
        private @InputSystemManager m_Wrapper;
        public JogadorActions(@InputSystemManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movimento => m_Wrapper.m_Jogador_Movimento;
        public InputAction @Pular => m_Wrapper.m_Jogador_Pular;
        public InputActionMap Get() { return m_Wrapper.m_Jogador; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JogadorActions set) { return set.Get(); }
        public void SetCallbacks(IJogadorActions instance)
        {
            if (m_Wrapper.m_JogadorActionsCallbackInterface != null)
            {
                @Movimento.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Movimento.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnMovimento;
                @Pular.started -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
                @Pular.performed -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
                @Pular.canceled -= m_Wrapper.m_JogadorActionsCallbackInterface.OnPular;
            }
            m_Wrapper.m_JogadorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movimento.started += instance.OnMovimento;
                @Movimento.performed += instance.OnMovimento;
                @Movimento.canceled += instance.OnMovimento;
                @Pular.started += instance.OnPular;
                @Pular.performed += instance.OnPular;
                @Pular.canceled += instance.OnPular;
            }
        }
    }
    public JogadorActions @Jogador => new JogadorActions(this);
    public interface IJogadorActions
    {
        void OnMovimento(InputAction.CallbackContext context);
        void OnPular(InputAction.CallbackContext context);
    }
}