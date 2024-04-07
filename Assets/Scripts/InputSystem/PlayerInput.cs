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
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HunterControls"",
            ""id"": ""0c4b8e2b-9fcd-4dc0-9788-c4a47887fe1e"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""05d3dd15-afb6-42c3-9f66-cbeca145e587"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""a7397ec0-9bf2-424b-85ad-21d31849237f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""676c086e-5e9a-4124-852d-0ffe31803e91"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Slide"",
                    ""type"": ""Button"",
                    ""id"": ""c7c4131a-918f-4914-957b-3ce1f0298377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""85201a4c-bf2e-47ee-9bf7-efc7f8fa285b"",
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
                    ""id"": ""4248113f-dbc0-4650-b00f-aeef2bd70cd2"",
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
                    ""id"": ""e6dd0ec6-879b-4f3c-ab5f-34bd69a8c103"",
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
                    ""id"": ""cf93b67f-efe9-4921-857f-8b8631f25855"",
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
                    ""id"": ""52fae577-9e23-42f4-ba6d-055675cd9c06"",
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
                    ""id"": ""a495ea1f-f1bd-4e9f-afe2-c61a6cb11c53"",
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
                    ""id"": ""fdd18fd3-0ae2-4fa6-9ce6-79c3fe47ecf3"",
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
                    ""id"": ""a2ff3286-d7c6-404e-9ec7-ecb31eb3c2cd"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Slide"",
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
        // HunterControls
        m_HunterControls = asset.FindActionMap("HunterControls", throwIfNotFound: true);
        m_HunterControls_Move = m_HunterControls.FindAction("Move", throwIfNotFound: true);
        m_HunterControls_Jump = m_HunterControls.FindAction("Jump", throwIfNotFound: true);
        m_HunterControls_Sprint = m_HunterControls.FindAction("Sprint", throwIfNotFound: true);
        m_HunterControls_Slide = m_HunterControls.FindAction("Slide", throwIfNotFound: true);
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
    public struct HunterControlsActions
    {
        private @PlayerInput m_Wrapper;
        public HunterControlsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HunterControls_Move;
        public InputAction @Jump => m_Wrapper.m_HunterControls_Jump;
        public InputAction @Sprint => m_Wrapper.m_HunterControls_Sprint;
        public InputAction @Slide => m_Wrapper.m_HunterControls_Slide;
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
    }
    public interface IHunterControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnSlide(InputAction.CallbackContext context);
    }
}
