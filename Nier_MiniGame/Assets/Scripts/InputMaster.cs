// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""45ef3926-6338-43f0-9546-79ea7a6684d3"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fd76674c-b1e6-436b-bd5b-c005e8cee43b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""433e0947-2fa5-4c03-9f33-779bec6dd5cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right_Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c26436ed-e3f9-46e9-995e-c248ecf0522f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stop_Right_Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""60e101cf-fbc1-4d2c-981b-9e850e9f19e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Left_Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8a549c1e-2f42-4aba-a642-e7e099bd9edd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Stop_Left_Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""272994ba-0a27-4298-857a-cf1c02bd7c46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""8bfaa80d-12ef-4cc8-b0d9-ceee5513c126"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""06e7589b-06b4-461a-85fc-2929ff3d017d"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e95a6d8b-905a-4fcf-95fd-edfffa6b9650"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""599d9a83-91ff-47e6-acb7-19a86034f8a1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""71973217-572a-454c-9ed3-215b7fbb66ed"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""291eb416-e796-4444-9a58-5fdc2e1a2650"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41de2814-f1f6-490e-9480-27f48a3f6a53"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""21b94efe-59e5-4aa4-8417-91ba385380d4"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Hold(duration=1E-06,pressPoint=1E-07)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right_Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e264a17-6899-4c36-9537-be50cb3816cd"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left_Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a8a03d9-8b28-4cfc-a50e-04c575deaa66"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf448f5f-d20b-4a1a-b4db-2178a58b9aa6"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""559e4ffb-8cbc-4481-a3f3-095e17310f1a"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop_Right_Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e7ec271-3e00-45f7-a4f3-9f5db365c782"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stop_Left_Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_Right_Shoot = m_Player.FindAction("Right_Shoot", throwIfNotFound: true);
        m_Player_Stop_Right_Shoot = m_Player.FindAction("Stop_Right_Shoot", throwIfNotFound: true);
        m_Player_Left_Shoot = m_Player.FindAction("Left_Shoot", throwIfNotFound: true);
        m_Player_Stop_Left_Shoot = m_Player.FindAction("Stop_Left_Shoot", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_Right_Shoot;
    private readonly InputAction m_Player_Stop_Right_Shoot;
    private readonly InputAction m_Player_Left_Shoot;
    private readonly InputAction m_Player_Stop_Left_Shoot;
    private readonly InputAction m_Player_Menu;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @Right_Shoot => m_Wrapper.m_Player_Right_Shoot;
        public InputAction @Stop_Right_Shoot => m_Wrapper.m_Player_Stop_Right_Shoot;
        public InputAction @Left_Shoot => m_Wrapper.m_Player_Left_Shoot;
        public InputAction @Stop_Left_Shoot => m_Wrapper.m_Player_Stop_Left_Shoot;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Right_Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Shoot;
                @Right_Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Shoot;
                @Right_Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRight_Shoot;
                @Stop_Right_Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Right_Shoot;
                @Stop_Right_Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Right_Shoot;
                @Stop_Right_Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Right_Shoot;
                @Left_Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Shoot;
                @Left_Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Shoot;
                @Left_Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeft_Shoot;
                @Stop_Left_Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Left_Shoot;
                @Stop_Left_Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Left_Shoot;
                @Stop_Left_Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStop_Left_Shoot;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Right_Shoot.started += instance.OnRight_Shoot;
                @Right_Shoot.performed += instance.OnRight_Shoot;
                @Right_Shoot.canceled += instance.OnRight_Shoot;
                @Stop_Right_Shoot.started += instance.OnStop_Right_Shoot;
                @Stop_Right_Shoot.performed += instance.OnStop_Right_Shoot;
                @Stop_Right_Shoot.canceled += instance.OnStop_Right_Shoot;
                @Left_Shoot.started += instance.OnLeft_Shoot;
                @Left_Shoot.performed += instance.OnLeft_Shoot;
                @Left_Shoot.canceled += instance.OnLeft_Shoot;
                @Stop_Left_Shoot.started += instance.OnStop_Left_Shoot;
                @Stop_Left_Shoot.performed += instance.OnStop_Left_Shoot;
                @Stop_Left_Shoot.canceled += instance.OnStop_Left_Shoot;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnRight_Shoot(InputAction.CallbackContext context);
        void OnStop_Right_Shoot(InputAction.CallbackContext context);
        void OnLeft_Shoot(InputAction.CallbackContext context);
        void OnStop_Left_Shoot(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
