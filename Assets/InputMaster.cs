// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

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
            ""id"": ""512dcec4-e58e-4d3a-8604-ca3cd702d3c5"",
            ""actions"": [
                {
                    ""name"": ""PullPlunger"",
                    ""type"": ""Button"",
                    ""id"": ""90f54d0b-d9fc-43a2-ad30-4e0340e8d80d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""6ae2bac5-186c-44b4-895d-c764f841d15f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftFlipper"",
                    ""type"": ""Button"",
                    ""id"": ""2acbdfe0-8472-491f-8563-f0d9508216da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0aebd139-4277-49f2-a15b-9108bf8a5f6d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PullPlunger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a2c439-9824-41cb-9110-109ce5b443b6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightFlipper"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f06d00d7-32ee-4123-b6cb-7f5df5f61b08"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftFlipper"",
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
        m_Player_PullPlunger = m_Player.FindAction("PullPlunger", throwIfNotFound: true);
        m_Player_RightFlipper = m_Player.FindAction("RightFlipper", throwIfNotFound: true);
        m_Player_LeftFlipper = m_Player.FindAction("LeftFlipper", throwIfNotFound: true);
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
    private readonly InputAction m_Player_PullPlunger;
    private readonly InputAction m_Player_RightFlipper;
    private readonly InputAction m_Player_LeftFlipper;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @PullPlunger => m_Wrapper.m_Player_PullPlunger;
        public InputAction @RightFlipper => m_Wrapper.m_Player_RightFlipper;
        public InputAction @LeftFlipper => m_Wrapper.m_Player_LeftFlipper;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @PullPlunger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullPlunger;
                @PullPlunger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullPlunger;
                @PullPlunger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPullPlunger;
                @RightFlipper.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightFlipper;
                @RightFlipper.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightFlipper;
                @RightFlipper.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRightFlipper;
                @LeftFlipper.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftFlipper;
                @LeftFlipper.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftFlipper;
                @LeftFlipper.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLeftFlipper;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PullPlunger.started += instance.OnPullPlunger;
                @PullPlunger.performed += instance.OnPullPlunger;
                @PullPlunger.canceled += instance.OnPullPlunger;
                @RightFlipper.started += instance.OnRightFlipper;
                @RightFlipper.performed += instance.OnRightFlipper;
                @RightFlipper.canceled += instance.OnRightFlipper;
                @LeftFlipper.started += instance.OnLeftFlipper;
                @LeftFlipper.performed += instance.OnLeftFlipper;
                @LeftFlipper.canceled += instance.OnLeftFlipper;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnPullPlunger(InputAction.CallbackContext context);
        void OnRightFlipper(InputAction.CallbackContext context);
        void OnLeftFlipper(InputAction.CallbackContext context);
    }
}
