//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Settings/InputSystem/InputActions.inputactions
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

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""b3aed01f-3f2d-4dca-91cb-6dab0e709786"",
            ""actions"": [
                {
                    ""name"": ""Axis"",
                    ""type"": ""Value"",
                    ""id"": ""d9cf3c93-9ec9-475c-bea6-25d8573b03c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""de902546-f03a-4ca2-8a25-67e6866b6a53"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""012c8529-2384-436f-9e2d-d07fba1b3444"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bag"",
                    ""type"": ""Button"",
                    ""id"": ""59ab661b-0805-4069-891c-8adc311d788b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""e2a3387d-c2b2-4029-a025-9251b20a21c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""11684124-1710-41cb-b964-8ec667c2d5fd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Instruction"",
                    ""type"": ""Button"",
                    ""id"": ""5898db7c-ad7c-4fdb-8293-baf1126fb1da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""52a3d9b2-8499-4c1b-ba28-3d1fa01cb39a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""22d51939-d43e-4f6f-80f0-3b1fe96b83c7"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""057cebf5-7c63-4fbb-888f-554628e425e1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bbc9fd9b-5447-453a-9543-bcaf1526fcfc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4d3b17c1-2496-45da-8029-3d8ca41a2d4c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8289861a-ff92-4cb8-8594-f0b983483fd5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4da6644d-3e4f-4617-8645-21a03d6f5605"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""376133cf-a305-4716-b6c7-44907f28b427"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""63ad12b2-2c1b-4633-b5ab-67dc39fc17c5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2c68af79-f3c3-4139-b904-a38322f976cd"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e45e4905-4475-489a-8afb-88d1853b5dbb"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Axis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""72ff84c4-ca5f-4b5a-b5ac-bacd109a1f46"",
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
                    ""id"": ""7dee55b6-af9b-4ce7-868c-a6fb69d563c1"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0064742-db99-4cc4-bea8-d6eef79fb330"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""362997b6-aa20-4167-a231-812f88b1a7c5"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5cf4ff3c-2f60-407e-a974-7c6a24fe1b8f"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bag"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aad75042-0b81-4b08-9c1f-7c8a81a6749d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14feee14-e0f4-46cb-b683-6ce0b3e11c8b"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f35f8530-2ded-4d32-95c4-128800dbd5f6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0021aad-e6f6-4476-9ad4-d5efdb62c191"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Instruction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d247d1-aebb-4c00-85bb-fe47f87dcbc3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Bag"",
            ""id"": ""18559b11-da74-4aaf-9ce7-9c601d1da9c1"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Value"",
                    ""id"": ""3f4519c7-5887-412c-ab4b-df46f9773c47"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""7865a53d-2000-4729-8554-1bd09b438319"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2f337f38-e6ed-4222-a272-32643243e382"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfbe6114-eac4-4ee9-91af-e532f2665c92"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4324a514-e0a2-4eaf-9a62-e0d46d73c602"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Instruction"",
            ""id"": ""2bee0b7f-6b48-40e1-8046-44a182891e5f"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""6d263632-28ca-4865-aa0f-72c6712dec13"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fbe9b804-186a-4811-9922-1f2d5677aa65"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea75b79c-54b4-4313-b256-246dc299c9c7"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Axis = m_Gameplay.FindAction("Axis", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
        m_Gameplay_Bag = m_Gameplay.FindAction("Bag", throwIfNotFound: true);
        m_Gameplay_Skill1 = m_Gameplay.FindAction("Skill1", throwIfNotFound: true);
        m_Gameplay_Item = m_Gameplay.FindAction("Item", throwIfNotFound: true);
        m_Gameplay_Instruction = m_Gameplay.FindAction("Instruction", throwIfNotFound: true);
        m_Gameplay_Exit = m_Gameplay.FindAction("Exit", throwIfNotFound: true);
        // Bag
        m_Bag = asset.FindActionMap("Bag", throwIfNotFound: true);
        m_Bag_Click = m_Bag.FindAction("Click", throwIfNotFound: true);
        m_Bag_Close = m_Bag.FindAction("Close", throwIfNotFound: true);
        // Instruction
        m_Instruction = asset.FindActionMap("Instruction", throwIfNotFound: true);
        m_Instruction_Close = m_Instruction.FindAction("Close", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_Axis;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_Attack;
    private readonly InputAction m_Gameplay_Bag;
    private readonly InputAction m_Gameplay_Skill1;
    private readonly InputAction m_Gameplay_Item;
    private readonly InputAction m_Gameplay_Instruction;
    private readonly InputAction m_Gameplay_Exit;
    public struct GameplayActions
    {
        private @InputActions m_Wrapper;
        public GameplayActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Axis => m_Wrapper.m_Gameplay_Axis;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
        public InputAction @Bag => m_Wrapper.m_Gameplay_Bag;
        public InputAction @Skill1 => m_Wrapper.m_Gameplay_Skill1;
        public InputAction @Item => m_Wrapper.m_Gameplay_Item;
        public InputAction @Instruction => m_Wrapper.m_Gameplay_Instruction;
        public InputAction @Exit => m_Wrapper.m_Gameplay_Exit;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @Axis.started += instance.OnAxis;
            @Axis.performed += instance.OnAxis;
            @Axis.canceled += instance.OnAxis;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @Bag.started += instance.OnBag;
            @Bag.performed += instance.OnBag;
            @Bag.canceled += instance.OnBag;
            @Skill1.started += instance.OnSkill1;
            @Skill1.performed += instance.OnSkill1;
            @Skill1.canceled += instance.OnSkill1;
            @Item.started += instance.OnItem;
            @Item.performed += instance.OnItem;
            @Item.canceled += instance.OnItem;
            @Instruction.started += instance.OnInstruction;
            @Instruction.performed += instance.OnInstruction;
            @Instruction.canceled += instance.OnInstruction;
            @Exit.started += instance.OnExit;
            @Exit.performed += instance.OnExit;
            @Exit.canceled += instance.OnExit;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @Axis.started -= instance.OnAxis;
            @Axis.performed -= instance.OnAxis;
            @Axis.canceled -= instance.OnAxis;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @Bag.started -= instance.OnBag;
            @Bag.performed -= instance.OnBag;
            @Bag.canceled -= instance.OnBag;
            @Skill1.started -= instance.OnSkill1;
            @Skill1.performed -= instance.OnSkill1;
            @Skill1.canceled -= instance.OnSkill1;
            @Item.started -= instance.OnItem;
            @Item.performed -= instance.OnItem;
            @Item.canceled -= instance.OnItem;
            @Instruction.started -= instance.OnInstruction;
            @Instruction.performed -= instance.OnInstruction;
            @Instruction.canceled -= instance.OnInstruction;
            @Exit.started -= instance.OnExit;
            @Exit.performed -= instance.OnExit;
            @Exit.canceled -= instance.OnExit;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // Bag
    private readonly InputActionMap m_Bag;
    private List<IBagActions> m_BagActionsCallbackInterfaces = new List<IBagActions>();
    private readonly InputAction m_Bag_Click;
    private readonly InputAction m_Bag_Close;
    public struct BagActions
    {
        private @InputActions m_Wrapper;
        public BagActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_Bag_Click;
        public InputAction @Close => m_Wrapper.m_Bag_Close;
        public InputActionMap Get() { return m_Wrapper.m_Bag; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BagActions set) { return set.Get(); }
        public void AddCallbacks(IBagActions instance)
        {
            if (instance == null || m_Wrapper.m_BagActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_BagActionsCallbackInterfaces.Add(instance);
            @Click.started += instance.OnClick;
            @Click.performed += instance.OnClick;
            @Click.canceled += instance.OnClick;
            @Close.started += instance.OnClose;
            @Close.performed += instance.OnClose;
            @Close.canceled += instance.OnClose;
        }

        private void UnregisterCallbacks(IBagActions instance)
        {
            @Click.started -= instance.OnClick;
            @Click.performed -= instance.OnClick;
            @Click.canceled -= instance.OnClick;
            @Close.started -= instance.OnClose;
            @Close.performed -= instance.OnClose;
            @Close.canceled -= instance.OnClose;
        }

        public void RemoveCallbacks(IBagActions instance)
        {
            if (m_Wrapper.m_BagActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IBagActions instance)
        {
            foreach (var item in m_Wrapper.m_BagActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_BagActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public BagActions @Bag => new BagActions(this);

    // Instruction
    private readonly InputActionMap m_Instruction;
    private List<IInstructionActions> m_InstructionActionsCallbackInterfaces = new List<IInstructionActions>();
    private readonly InputAction m_Instruction_Close;
    public struct InstructionActions
    {
        private @InputActions m_Wrapper;
        public InstructionActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Close => m_Wrapper.m_Instruction_Close;
        public InputActionMap Get() { return m_Wrapper.m_Instruction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InstructionActions set) { return set.Get(); }
        public void AddCallbacks(IInstructionActions instance)
        {
            if (instance == null || m_Wrapper.m_InstructionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_InstructionActionsCallbackInterfaces.Add(instance);
            @Close.started += instance.OnClose;
            @Close.performed += instance.OnClose;
            @Close.canceled += instance.OnClose;
        }

        private void UnregisterCallbacks(IInstructionActions instance)
        {
            @Close.started -= instance.OnClose;
            @Close.performed -= instance.OnClose;
            @Close.canceled -= instance.OnClose;
        }

        public void RemoveCallbacks(IInstructionActions instance)
        {
            if (m_Wrapper.m_InstructionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IInstructionActions instance)
        {
            foreach (var item in m_Wrapper.m_InstructionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_InstructionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public InstructionActions @Instruction => new InstructionActions(this);
    public interface IGameplayActions
    {
        void OnAxis(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnBag(InputAction.CallbackContext context);
        void OnSkill1(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnInstruction(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
    }
    public interface IBagActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnClose(InputAction.CallbackContext context);
    }
    public interface IInstructionActions
    {
        void OnClose(InputAction.CallbackContext context);
    }
}