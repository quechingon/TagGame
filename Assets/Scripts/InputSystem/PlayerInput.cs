//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/InputSystem/PlayerInput.inputactions
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

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""PreyControls"",
            ""id"": ""dfd79a98-f420-4428-add3-555c3f65a6ae"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""14623f4a-6a42-4dce-9e8d-183396ffb6ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""95774ef6-c3ad-444b-8ea3-24c1878a5722"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""d49a3d4d-7eee-433f-8314-70a746d4fb18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""070de191-ec1b-42e9-ab56-f4e35bc833ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""4cdc3277-ee16-4a89-9346-7f6eec02411c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""0196034f-106f-4a56-a9f3-9d215206ec81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Set Reset"",
                    ""type"": ""Button"",
                    ""id"": ""f3a578ca-3cfe-4192-90ee-d1055cc7bcff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""bcab9862-6af7-424a-85d3-9aae151767b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d699d6dc-95b5-41ec-a542-4828a8f526ff"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cb926788-53bf-4785-9243-f55447d21379"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d5328988-f494-46a9-ab97-ccaf2c89d9e0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8d77167-9dc4-4231-b8fc-7c01874c0caa"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d45c5631-2b61-4ad4-87a1-28f9ea92ab23"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bf450668-8901-484f-bb8f-a0da80035609"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0049113b-ea48-48d7-97c9-d8bba22dc068"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24e5b1d1-b2bf-4da9-ab35-091b4b5251bd"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""da777328-5665-4a32-9af1-4a1d6d589dfd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8a1e206-60ed-4838-af79-5e1f83f69f83"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88bee1a4-3b22-4018-a19e-a8d57dba2bc3"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3bb5ee2-15ad-4ac8-adaf-aa0257122804"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""405c7b55-5b8d-45ba-bbf2-91505c60ba9c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HunterControls"",
            ""id"": ""9b0c46ab-4a2f-403f-8909-a6aaddd4a720"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""161c7a4e-4173-495c-a638-50cf9e7f1f20"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""3ff93736-6751-4a28-9631-f0f7d8453578"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""64923673-cce4-4b3b-9467-4b4e659ec308"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""ba20d036-c1aa-4637-8221-4108ceffa043"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""1d8ce68a-450f-430a-89ee-2d557602a8af"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""88b0d620-49f4-480a-8e05-027f22313e90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Set Reset"",
                    ""type"": ""Button"",
                    ""id"": ""4c98b795-fba6-4045-be99-a344e0cebb3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""a08de8c2-f5be-442d-94b0-ecaca07d0f0c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""d15e70de-dbe1-46fb-ab78-5d514177065a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c05a26a5-3450-4ba2-945b-b1a5c793b5f8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""09eb4d54-0ff2-4045-a86e-f081d08ec002"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc4f5ef6-56da-4c91-8f61-7767c7f00b13"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1a7e0c15-be47-4958-b2ca-393835c71246"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c44367be-29e4-4b97-8af8-28156bfe93b3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c7d12512-3cf4-427c-bfde-08ab48e3bcc2"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3eda8b8-3c1e-4043-9abc-cdda13d0c3e4"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3dc50b7-3f0a-4ae5-9f8c-eefc2afe0722"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8b74c3f-6dcd-43e0-b410-77e80ff4659b"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f5611df-4063-4a39-b9cd-786de7eafa6a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9167e8ab-dbd8-4d3f-9d3f-7a97b17f5edc"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33f56d3e-c16f-4056-a234-2aea20617e69"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Set Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b55c50f-e5f8-4994-ac13-28db2f2c0e23"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad5aa7b0-322d-4c1b-89ea-6e4272f943ca"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PreyControls
        m_PreyControls = asset.FindActionMap("PreyControls", throwIfNotFound: true);
        m_PreyControls_Move = m_PreyControls.FindAction("Move", throwIfNotFound: true);
        m_PreyControls_Jump = m_PreyControls.FindAction("Jump", throwIfNotFound: true);
        m_PreyControls_Sprint = m_PreyControls.FindAction("Sprint", throwIfNotFound: true);
        m_PreyControls_Slide = m_PreyControls.FindAction("Slide", throwIfNotFound: true);
        m_PreyControls_Look = m_PreyControls.FindAction("Look", throwIfNotFound: true);
        m_PreyControls_Reset = m_PreyControls.FindAction("Reset", throwIfNotFound: true);
        m_PreyControls_SetReset = m_PreyControls.FindAction("Set Reset", throwIfNotFound: true);
        m_PreyControls_Dash = m_PreyControls.FindAction("Dash", throwIfNotFound: true);
        // HunterControls
        m_HunterControls = asset.FindActionMap("HunterControls", throwIfNotFound: true);
        m_HunterControls_Move = m_HunterControls.FindAction("Move", throwIfNotFound: true);
        m_HunterControls_Jump = m_HunterControls.FindAction("Jump", throwIfNotFound: true);
        m_HunterControls_Sprint = m_HunterControls.FindAction("Sprint", throwIfNotFound: true);
        m_HunterControls_Slide = m_HunterControls.FindAction("Slide", throwIfNotFound: true);
        m_HunterControls_Look = m_HunterControls.FindAction("Look", throwIfNotFound: true);
        m_HunterControls_Reset = m_HunterControls.FindAction("Reset", throwIfNotFound: true);
        m_HunterControls_SetReset = m_HunterControls.FindAction("Set Reset", throwIfNotFound: true);
        m_HunterControls_Dash = m_HunterControls.FindAction("Dash", throwIfNotFound: true);
        m_HunterControls_Attack = m_HunterControls.FindAction("Attack", throwIfNotFound: true);
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

    // PreyControls
    private readonly InputActionMap m_PreyControls;
    private List<IPreyControlsActions> m_PreyControlsActionsCallbackInterfaces = new List<IPreyControlsActions>();
    private readonly InputAction m_PreyControls_Move;
    private readonly InputAction m_PreyControls_Jump;
    private readonly InputAction m_PreyControls_Sprint;
    private readonly InputAction m_PreyControls_Slide;
    private readonly InputAction m_PreyControls_Look;
    private readonly InputAction m_PreyControls_Reset;
    private readonly InputAction m_PreyControls_SetReset;
    private readonly InputAction m_PreyControls_Dash;
    public struct PreyControlsActions
    {
        private @PlayerInput m_Wrapper;
        public PreyControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PreyControls_Move;
        public InputAction @Jump => m_Wrapper.m_PreyControls_Jump;
        public InputAction @Sprint => m_Wrapper.m_PreyControls_Sprint;
        public InputAction @Slide => m_Wrapper.m_PreyControls_Slide;
        public InputAction @Look => m_Wrapper.m_PreyControls_Look;
        public InputAction @Reset => m_Wrapper.m_PreyControls_Reset;
        public InputAction @SetReset => m_Wrapper.m_PreyControls_SetReset;
        public InputAction @Dash => m_Wrapper.m_PreyControls_Dash;
        public InputActionMap Get() { return m_Wrapper.m_PreyControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PreyControlsActions set) { return set.Get(); }
        public void AddCallbacks(IPreyControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_PreyControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PreyControlsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Slide.started += instance.OnSlide;
            @Slide.performed += instance.OnSlide;
            @Slide.canceled += instance.OnSlide;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
            @SetReset.started += instance.OnSetReset;
            @SetReset.performed += instance.OnSetReset;
            @SetReset.canceled += instance.OnSetReset;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
        }

        private void UnregisterCallbacks(IPreyControlsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Slide.started -= instance.OnSlide;
            @Slide.performed -= instance.OnSlide;
            @Slide.canceled -= instance.OnSlide;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
            @SetReset.started -= instance.OnSetReset;
            @SetReset.performed -= instance.OnSetReset;
            @SetReset.canceled -= instance.OnSetReset;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
        }

        public void RemoveCallbacks(IPreyControlsActions instance)
        {
            if (m_Wrapper.m_PreyControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPreyControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_PreyControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PreyControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PreyControlsActions @PreyControls => new PreyControlsActions(this);

    // HunterControls
    private readonly InputActionMap m_HunterControls;
    private List<IHunterControlsActions> m_HunterControlsActionsCallbackInterfaces = new List<IHunterControlsActions>();
    private readonly InputAction m_HunterControls_Move;
    private readonly InputAction m_HunterControls_Jump;
    private readonly InputAction m_HunterControls_Sprint;
    private readonly InputAction m_HunterControls_Slide;
    private readonly InputAction m_HunterControls_Look;
    private readonly InputAction m_HunterControls_Reset;
    private readonly InputAction m_HunterControls_SetReset;
    private readonly InputAction m_HunterControls_Dash;
    private readonly InputAction m_HunterControls_Attack;
    public struct HunterControlsActions
    {
        private @PlayerInput m_Wrapper;
        public HunterControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HunterControls_Move;
        public InputAction @Jump => m_Wrapper.m_HunterControls_Jump;
        public InputAction @Sprint => m_Wrapper.m_HunterControls_Sprint;
        public InputAction @Slide => m_Wrapper.m_HunterControls_Slide;
        public InputAction @Look => m_Wrapper.m_HunterControls_Look;
        public InputAction @Reset => m_Wrapper.m_HunterControls_Reset;
        public InputAction @SetReset => m_Wrapper.m_HunterControls_SetReset;
        public InputAction @Dash => m_Wrapper.m_HunterControls_Dash;
        public InputAction @Attack => m_Wrapper.m_HunterControls_Attack;
        public InputActionMap Get() { return m_Wrapper.m_HunterControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HunterControlsActions set) { return set.Get(); }
        public void AddCallbacks(IHunterControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_HunterControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HunterControlsActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Slide.started += instance.OnSlide;
            @Slide.performed += instance.OnSlide;
            @Slide.canceled += instance.OnSlide;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
            @SetReset.started += instance.OnSetReset;
            @SetReset.performed += instance.OnSetReset;
            @SetReset.canceled += instance.OnSetReset;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
        }

        private void UnregisterCallbacks(IHunterControlsActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Slide.started -= instance.OnSlide;
            @Slide.performed -= instance.OnSlide;
            @Slide.canceled -= instance.OnSlide;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
            @SetReset.started -= instance.OnSetReset;
            @SetReset.performed -= instance.OnSetReset;
            @SetReset.canceled -= instance.OnSetReset;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
        }

        public void RemoveCallbacks(IHunterControlsActions instance)
        {
            if (m_Wrapper.m_HunterControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHunterControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_HunterControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HunterControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HunterControlsActions @HunterControls => new HunterControlsActions(this);
    public interface IPreyControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnSetReset(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
    }
    public interface IHunterControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnSetReset(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
