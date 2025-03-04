//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/PlayerInput.inputactions
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
            ""name"": ""Movement"",
            ""id"": ""eabde8a3-7662-4d65-b5d1-e085a8ab55a4"",
            ""actions"": [
                {
                    ""name"": ""PlayerMovements"",
                    ""type"": ""Value"",
                    ""id"": ""d1182dff-5c88-48c8-8a08-eddf263678d4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""1b7ccff8-7652-48c5-8cc9-48f9cd12d6e1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f3e2855-2cbc-467a-976d-e5e1eb445cfa"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""df439dfe-40d6-4aaa-a708-2ee821ff4715"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0a38733b-859d-4f25-a613-fa33f48e4469"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""71f74ccb-24c5-469b-8353-5babaf94c906"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""598e9303-7e5a-491b-a256-0ed9ef124be1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d73ee9b-6e56-40d5-bf8c-e73333942d59"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2c960b20-718b-49c0-a073-1f2d7feea9c7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e2ed5a65-144d-403f-83a4-8f182619ab58"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2c3df1f0-a163-438c-8288-16e6f3f4b512"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""PlayerMovements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""MainActionBar"",
            ""id"": ""4848c470-52e9-411f-815c-b4d29a75406a"",
            ""actions"": [
                {
                    ""name"": ""Bucket"",
                    ""type"": ""Button"",
                    ""id"": ""d75c50af-0452-4a87-a517-360da7f8d4a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Tree"",
                    ""type"": ""Button"",
                    ""id"": ""6345d4c5-6400-4c42-b486-d608e6ea2dcf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""House"",
                    ""type"": ""Button"",
                    ""id"": ""a71cef92-25d6-4ef1-9909-073309cf166e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Factory"",
                    ""type"": ""Button"",
                    ""id"": ""68904f4c-8d17-43ae-bd39-27f7e06b0a2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseRightClick"",
                    ""type"": ""Button"",
                    ""id"": ""e2cfc9a2-17e5-4674-a43c-0833fde78c61"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8fffe07d-6d07-4e79-895d-3e911d2011c5"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Bucket"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b33b065-df66-4f0e-8848-1317724d2269"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Tree"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc44db4e-06ba-4274-814e-2c11f059b1a2"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""House"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea4f3084-e808-4b84-97f4-d382dc006f5c"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Factory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69f4881c-740b-4bd2-8862-7832f624cdad"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TreeTypes"",
            ""id"": ""30d6b118-7f40-4adc-beb7-28be34d55ecb"",
            ""actions"": [
                {
                    ""name"": ""Birch"",
                    ""type"": ""Button"",
                    ""id"": ""bec303db-690f-4ef3-b317-c1ef56ee0887"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fir"",
                    ""type"": ""Button"",
                    ""id"": ""1aa8bbdf-40eb-4187-a59f-002572137195"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Oak"",
                    ""type"": ""Button"",
                    ""id"": ""246489dc-7679-4586-a690-d6ca0e9ada5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseRightClick"",
                    ""type"": ""Button"",
                    ""id"": ""da3d0dba-1aa7-4b83-8b95-eb279d79ee12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c15cb859-0460-4ecb-84c3-8bc075d0cf94"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Fir"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb1c6d85-bba8-4d64-9ef3-720816a881d3"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Oak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cadc8b9-1fa6-4ffd-bb16-2705f4be203a"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f469b41-e7d1-4c34-a4d9-be306dea674e"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Birch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""81a2b714-daec-4d39-ae0e-d73f8ab03414"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""bc9d001f-5866-4ab1-8759-96c081fe90d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""ac366870-7c21-4ccb-866c-764879e83d99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""4ae35c79-08f2-4813-bde7-f70ad385111b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e9491f69-2c9b-4e19-a6fe-deeaad4715cf"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0a34188-b847-4287-9550-79522f27baa3"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Hold(duration=2)"",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e61ecc78-b21a-49c6-a42a-48dce97659c3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Construction"",
            ""id"": ""c80ad3e0-245b-4177-942a-5cfb0eed43bd"",
            ""actions"": [
                {
                    ""name"": ""MouseLeftClick"",
                    ""type"": ""Button"",
                    ""id"": ""84ca5d47-3acf-44b1-af02-830882adc108"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a0e27145-8d9c-4c40-a7b6-a9fcdf8cab3c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""New control scheme"",
                    ""action"": ""MouseLeftClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""New control scheme"",
            ""bindingGroup"": ""New control scheme"",
            ""devices"": []
        }
    ]
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_PlayerMovements = m_Movement.FindAction("PlayerMovements", throwIfNotFound: true);
        // MainActionBar
        m_MainActionBar = asset.FindActionMap("MainActionBar", throwIfNotFound: true);
        m_MainActionBar_Bucket = m_MainActionBar.FindAction("Bucket", throwIfNotFound: true);
        m_MainActionBar_Tree = m_MainActionBar.FindAction("Tree", throwIfNotFound: true);
        m_MainActionBar_House = m_MainActionBar.FindAction("House", throwIfNotFound: true);
        m_MainActionBar_Factory = m_MainActionBar.FindAction("Factory", throwIfNotFound: true);
        m_MainActionBar_MouseRightClick = m_MainActionBar.FindAction("MouseRightClick", throwIfNotFound: true);
        // TreeTypes
        m_TreeTypes = asset.FindActionMap("TreeTypes", throwIfNotFound: true);
        m_TreeTypes_Birch = m_TreeTypes.FindAction("Birch", throwIfNotFound: true);
        m_TreeTypes_Fir = m_TreeTypes.FindAction("Fir", throwIfNotFound: true);
        m_TreeTypes_Oak = m_TreeTypes.FindAction("Oak", throwIfNotFound: true);
        m_TreeTypes_MouseRightClick = m_TreeTypes.FindAction("MouseRightClick", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_Interact = m_Interaction.FindAction("Interact", throwIfNotFound: true);
        m_Interaction_Reset = m_Interaction.FindAction("Reset", throwIfNotFound: true);
        m_Interaction_Pause = m_Interaction.FindAction("Pause", throwIfNotFound: true);
        // Construction
        m_Construction = asset.FindActionMap("Construction", throwIfNotFound: true);
        m_Construction_MouseLeftClick = m_Construction.FindAction("MouseLeftClick", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private List<IMovementActions> m_MovementActionsCallbackInterfaces = new List<IMovementActions>();
    private readonly InputAction m_Movement_PlayerMovements;
    public struct MovementActions
    {
        private @PlayerInput m_Wrapper;
        public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerMovements => m_Wrapper.m_Movement_PlayerMovements;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void AddCallbacks(IMovementActions instance)
        {
            if (instance == null || m_Wrapper.m_MovementActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MovementActionsCallbackInterfaces.Add(instance);
            @PlayerMovements.started += instance.OnPlayerMovements;
            @PlayerMovements.performed += instance.OnPlayerMovements;
            @PlayerMovements.canceled += instance.OnPlayerMovements;
        }

        private void UnregisterCallbacks(IMovementActions instance)
        {
            @PlayerMovements.started -= instance.OnPlayerMovements;
            @PlayerMovements.performed -= instance.OnPlayerMovements;
            @PlayerMovements.canceled -= instance.OnPlayerMovements;
        }

        public void RemoveCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMovementActions instance)
        {
            foreach (var item in m_Wrapper.m_MovementActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MovementActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // MainActionBar
    private readonly InputActionMap m_MainActionBar;
    private List<IMainActionBarActions> m_MainActionBarActionsCallbackInterfaces = new List<IMainActionBarActions>();
    private readonly InputAction m_MainActionBar_Bucket;
    private readonly InputAction m_MainActionBar_Tree;
    private readonly InputAction m_MainActionBar_House;
    private readonly InputAction m_MainActionBar_Factory;
    private readonly InputAction m_MainActionBar_MouseRightClick;
    public struct MainActionBarActions
    {
        private @PlayerInput m_Wrapper;
        public MainActionBarActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bucket => m_Wrapper.m_MainActionBar_Bucket;
        public InputAction @Tree => m_Wrapper.m_MainActionBar_Tree;
        public InputAction @House => m_Wrapper.m_MainActionBar_House;
        public InputAction @Factory => m_Wrapper.m_MainActionBar_Factory;
        public InputAction @MouseRightClick => m_Wrapper.m_MainActionBar_MouseRightClick;
        public InputActionMap Get() { return m_Wrapper.m_MainActionBar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActionBarActions set) { return set.Get(); }
        public void AddCallbacks(IMainActionBarActions instance)
        {
            if (instance == null || m_Wrapper.m_MainActionBarActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainActionBarActionsCallbackInterfaces.Add(instance);
            @Bucket.started += instance.OnBucket;
            @Bucket.performed += instance.OnBucket;
            @Bucket.canceled += instance.OnBucket;
            @Tree.started += instance.OnTree;
            @Tree.performed += instance.OnTree;
            @Tree.canceled += instance.OnTree;
            @House.started += instance.OnHouse;
            @House.performed += instance.OnHouse;
            @House.canceled += instance.OnHouse;
            @Factory.started += instance.OnFactory;
            @Factory.performed += instance.OnFactory;
            @Factory.canceled += instance.OnFactory;
            @MouseRightClick.started += instance.OnMouseRightClick;
            @MouseRightClick.performed += instance.OnMouseRightClick;
            @MouseRightClick.canceled += instance.OnMouseRightClick;
        }

        private void UnregisterCallbacks(IMainActionBarActions instance)
        {
            @Bucket.started -= instance.OnBucket;
            @Bucket.performed -= instance.OnBucket;
            @Bucket.canceled -= instance.OnBucket;
            @Tree.started -= instance.OnTree;
            @Tree.performed -= instance.OnTree;
            @Tree.canceled -= instance.OnTree;
            @House.started -= instance.OnHouse;
            @House.performed -= instance.OnHouse;
            @House.canceled -= instance.OnHouse;
            @Factory.started -= instance.OnFactory;
            @Factory.performed -= instance.OnFactory;
            @Factory.canceled -= instance.OnFactory;
            @MouseRightClick.started -= instance.OnMouseRightClick;
            @MouseRightClick.performed -= instance.OnMouseRightClick;
            @MouseRightClick.canceled -= instance.OnMouseRightClick;
        }

        public void RemoveCallbacks(IMainActionBarActions instance)
        {
            if (m_Wrapper.m_MainActionBarActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainActionBarActions instance)
        {
            foreach (var item in m_Wrapper.m_MainActionBarActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainActionBarActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainActionBarActions @MainActionBar => new MainActionBarActions(this);

    // TreeTypes
    private readonly InputActionMap m_TreeTypes;
    private List<ITreeTypesActions> m_TreeTypesActionsCallbackInterfaces = new List<ITreeTypesActions>();
    private readonly InputAction m_TreeTypes_Birch;
    private readonly InputAction m_TreeTypes_Fir;
    private readonly InputAction m_TreeTypes_Oak;
    private readonly InputAction m_TreeTypes_MouseRightClick;
    public struct TreeTypesActions
    {
        private @PlayerInput m_Wrapper;
        public TreeTypesActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Birch => m_Wrapper.m_TreeTypes_Birch;
        public InputAction @Fir => m_Wrapper.m_TreeTypes_Fir;
        public InputAction @Oak => m_Wrapper.m_TreeTypes_Oak;
        public InputAction @MouseRightClick => m_Wrapper.m_TreeTypes_MouseRightClick;
        public InputActionMap Get() { return m_Wrapper.m_TreeTypes; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TreeTypesActions set) { return set.Get(); }
        public void AddCallbacks(ITreeTypesActions instance)
        {
            if (instance == null || m_Wrapper.m_TreeTypesActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TreeTypesActionsCallbackInterfaces.Add(instance);
            @Birch.started += instance.OnBirch;
            @Birch.performed += instance.OnBirch;
            @Birch.canceled += instance.OnBirch;
            @Fir.started += instance.OnFir;
            @Fir.performed += instance.OnFir;
            @Fir.canceled += instance.OnFir;
            @Oak.started += instance.OnOak;
            @Oak.performed += instance.OnOak;
            @Oak.canceled += instance.OnOak;
            @MouseRightClick.started += instance.OnMouseRightClick;
            @MouseRightClick.performed += instance.OnMouseRightClick;
            @MouseRightClick.canceled += instance.OnMouseRightClick;
        }

        private void UnregisterCallbacks(ITreeTypesActions instance)
        {
            @Birch.started -= instance.OnBirch;
            @Birch.performed -= instance.OnBirch;
            @Birch.canceled -= instance.OnBirch;
            @Fir.started -= instance.OnFir;
            @Fir.performed -= instance.OnFir;
            @Fir.canceled -= instance.OnFir;
            @Oak.started -= instance.OnOak;
            @Oak.performed -= instance.OnOak;
            @Oak.canceled -= instance.OnOak;
            @MouseRightClick.started -= instance.OnMouseRightClick;
            @MouseRightClick.performed -= instance.OnMouseRightClick;
            @MouseRightClick.canceled -= instance.OnMouseRightClick;
        }

        public void RemoveCallbacks(ITreeTypesActions instance)
        {
            if (m_Wrapper.m_TreeTypesActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITreeTypesActions instance)
        {
            foreach (var item in m_Wrapper.m_TreeTypesActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TreeTypesActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TreeTypesActions @TreeTypes => new TreeTypesActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private List<IInteractionActions> m_InteractionActionsCallbackInterfaces = new List<IInteractionActions>();
    private readonly InputAction m_Interaction_Interact;
    private readonly InputAction m_Interaction_Reset;
    private readonly InputAction m_Interaction_Pause;
    public struct InteractionActions
    {
        private @PlayerInput m_Wrapper;
        public InteractionActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interact => m_Wrapper.m_Interaction_Interact;
        public InputAction @Reset => m_Wrapper.m_Interaction_Reset;
        public InputAction @Pause => m_Wrapper.m_Interaction_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void AddCallbacks(IInteractionActions instance)
        {
            if (instance == null || m_Wrapper.m_InteractionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Add(instance);
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(IInteractionActions instance)
        {
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInteractionActions instance)
        {
            foreach (var item in m_Wrapper.m_InteractionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InteractionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);

    // Construction
    private readonly InputActionMap m_Construction;
    private List<IConstructionActions> m_ConstructionActionsCallbackInterfaces = new List<IConstructionActions>();
    private readonly InputAction m_Construction_MouseLeftClick;
    public struct ConstructionActions
    {
        private @PlayerInput m_Wrapper;
        public ConstructionActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLeftClick => m_Wrapper.m_Construction_MouseLeftClick;
        public InputActionMap Get() { return m_Wrapper.m_Construction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ConstructionActions set) { return set.Get(); }
        public void AddCallbacks(IConstructionActions instance)
        {
            if (instance == null || m_Wrapper.m_ConstructionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ConstructionActionsCallbackInterfaces.Add(instance);
            @MouseLeftClick.started += instance.OnMouseLeftClick;
            @MouseLeftClick.performed += instance.OnMouseLeftClick;
            @MouseLeftClick.canceled += instance.OnMouseLeftClick;
        }

        private void UnregisterCallbacks(IConstructionActions instance)
        {
            @MouseLeftClick.started -= instance.OnMouseLeftClick;
            @MouseLeftClick.performed -= instance.OnMouseLeftClick;
            @MouseLeftClick.canceled -= instance.OnMouseLeftClick;
        }

        public void RemoveCallbacks(IConstructionActions instance)
        {
            if (m_Wrapper.m_ConstructionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IConstructionActions instance)
        {
            foreach (var item in m_Wrapper.m_ConstructionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ConstructionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ConstructionActions @Construction => new ConstructionActions(this);
    private int m_NewcontrolschemeSchemeIndex = -1;
    public InputControlScheme NewcontrolschemeScheme
    {
        get
        {
            if (m_NewcontrolschemeSchemeIndex == -1) m_NewcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("New control scheme");
            return asset.controlSchemes[m_NewcontrolschemeSchemeIndex];
        }
    }
    public interface IMovementActions
    {
        void OnPlayerMovements(InputAction.CallbackContext context);
    }
    public interface IMainActionBarActions
    {
        void OnBucket(InputAction.CallbackContext context);
        void OnTree(InputAction.CallbackContext context);
        void OnHouse(InputAction.CallbackContext context);
        void OnFactory(InputAction.CallbackContext context);
        void OnMouseRightClick(InputAction.CallbackContext context);
    }
    public interface ITreeTypesActions
    {
        void OnBirch(InputAction.CallbackContext context);
        void OnFir(InputAction.CallbackContext context);
        void OnOak(InputAction.CallbackContext context);
        void OnMouseRightClick(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnInteract(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IConstructionActions
    {
        void OnMouseLeftClick(InputAction.CallbackContext context);
    }
}
