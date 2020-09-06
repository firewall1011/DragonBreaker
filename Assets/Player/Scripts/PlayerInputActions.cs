// GENERATED AUTOMATICALLY FROM 'Assets/Player/Scripts/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player Controls"",
            ""id"": ""7c4dbed1-e02d-476b-978f-09632cb33dee"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b86e8eab-d421-4ebb-a9c3-b161baee0575"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""58a497ec-e809-4318-b9d8-94de1a582fb7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""118559a7-1974-483d-a299-d93720187d0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""508962be-f5cb-4184-b8c7-0df99fec80b6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""4cce718d-93f4-46da-bb4e-eff0046c30b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1dc480d9-2007-41eb-a0e0-3cbb0e3eb7fe"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0cb2469d-3e57-4661-8ab6-23a951c1f150"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abcaca27-cc39-4846-b8e4-1db29445e2ea"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d5e991-4ddb-42db-bddb-a94e97611cee"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d72a287e-52e7-4564-82ed-3e429987f99f"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9f43b5c-b785-4c34-8cb4-a1a370dfe5fa"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cedc22bb-72c0-4df6-bf95-e78f6c8c7766"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""aa07d704-17c6-426e-99b5-184b5f42a269"",
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
                    ""id"": ""f3bc8452-055c-4823-ab43-145cb1d7fb7b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0cf9b050-93c5-46a5-9c92-09a3cd184193"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fcdc545a-7623-4cfe-88bd-0bcb40e8f89d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1528ba01-d66d-428d-a860-ec68d36cac99"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""2391a046-a5c1-44c2-883c-61a5285c345b"",
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
                    ""id"": ""7beda322-7d3e-41ab-bda6-89e53be59910"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c6f1dbe4-2a40-41f9-84f7-c74a89f14cdb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""00362d19-6dda-4461-a4eb-9461c852a6da"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3733a895-88f4-442c-876a-3938a8c5b702"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""39a4934f-5214-485a-baff-1b78bfc496ef"",
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
                    ""id"": ""825c52df-db81-4ccb-8e81-7b32e3839a14"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e88348a4-eb58-45e3-a0ab-6ee142582cf5"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""84b35328-38ff-4fee-b5c8-90295a29cb33"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6f1482d7-debe-4fed-ad02-ce39ee2246ec"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8b6a4755-3809-46fa-b958-03f22902bbf4"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe1ceb41-ddba-47bb-9db8-bb8cb40b6c2b"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7cc2d52-aebc-4c6f-9b80-22590cdd7f61"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4a17e8ef-cc71-41c8-a31f-6916ccd85332"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""23b66691-b777-464e-bcce-6dcb8c93f9b7"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0078581b-49c1-4989-8daf-36d008b9686b"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def2726e-7f80-40fb-84d6-2a2ef4be0151"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef825580-93a5-4971-a95f-956fc9970f10"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1db38908-06f0-402f-a518-131bf29e0fe0"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1;SplitKeyboard_2"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51456f39-c1fc-4db8-8853-71d2b1185335"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""1399dad4-e2bd-4b08-be7d-5ada3f469dd2"",
            ""actions"": [
                {
                    ""name"": ""Join"",
                    ""type"": ""Button"",
                    ""id"": ""079c467d-d160-4bed-b66d-d815ccb9b5a0"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Leave"",
                    ""type"": ""Button"",
                    ""id"": ""f2afb516-7329-4a94-9d84-47a5b860d25a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Exit"",
                    ""type"": ""Button"",
                    ""id"": ""4e5d4117-0f69-4e06-86f8-1a0fe231a818"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""efb5919d-83f1-49ce-96f3-564b6a023d0b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""e2c2a354-f974-4904-ac5b-68c49ea21f3b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b53194ad-3b22-47e0-837e-7e21eb5c4e19"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Leave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5393be5-d537-4877-bcde-4b75fd3d600e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Leave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f1bece0-cde1-4ec0-860f-7cec672364a4"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Leave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce417270-d4cb-46b7-933e-f23d019fe625"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Leave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d736f59-ac43-41f0-91bb-23152f108f65"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e81eb3-9a57-437f-9ada-918cce154d01"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53c11e41-c510-42ba-bb3e-46f4ac3c0002"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17659447-c311-4318-83b4-b6dbbbacf677"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Join"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36688cc7-35f6-400f-931b-f066cbbb48e8"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1;SplitKeyboard_2"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""789bd56c-e53b-45e2-8c97-189569e294ec"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58e43870-9591-46d6-ae8f-5bc3a3a14e9b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1202452c-825b-438c-9646-ccf9f64d8e3c"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55aaf205-a0e2-4948-af8a-c9392e44ab07"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bad8d35-b673-406a-9cd5-e428bfd847dc"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_2"",
                    ""action"": ""Exit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72fb5c1a-2664-4737-a37c-c739ba696fc6"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""SplitKeyboard_1;SplitKeyboard_2"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1fe6b0d-597f-43c9-a37c-f8557b5b8668"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""SplitKeyboard_1"",
            ""bindingGroup"": ""SplitKeyboard_1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""SplitKeyboard_2"",
            ""bindingGroup"": ""SplitKeyboard_2"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player Controls
        m_PlayerControls = asset.FindActionMap("Player Controls", throwIfNotFound: true);
        m_PlayerControls_Move = m_PlayerControls.FindAction("Move", throwIfNotFound: true);
        m_PlayerControls_Jump = m_PlayerControls.FindAction("Jump", throwIfNotFound: true);
        m_PlayerControls_Dash = m_PlayerControls.FindAction("Dash", throwIfNotFound: true);
        m_PlayerControls_Attack = m_PlayerControls.FindAction("Attack", throwIfNotFound: true);
        m_PlayerControls_Pause = m_PlayerControls.FindAction("Pause", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Join = m_UI.FindAction("Join", throwIfNotFound: true);
        m_UI_Leave = m_UI.FindAction("Leave", throwIfNotFound: true);
        m_UI_Exit = m_UI.FindAction("Exit", throwIfNotFound: true);
        m_UI_Pause = m_UI.FindAction("Pause", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
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

    // Player Controls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Move;
    private readonly InputAction m_PlayerControls_Jump;
    private readonly InputAction m_PlayerControls_Dash;
    private readonly InputAction m_PlayerControls_Attack;
    private readonly InputAction m_PlayerControls_Pause;
    public struct PlayerControlsActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerControlsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControls_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerControls_Jump;
        public InputAction @Dash => m_Wrapper.m_PlayerControls_Dash;
        public InputAction @Attack => m_Wrapper.m_PlayerControls_Attack;
        public InputAction @Pause => m_Wrapper.m_PlayerControls_Pause;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @Dash.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @Dash.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @Dash.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDash;
                @Attack.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnAttack;
                @Pause.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPause;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Dash.started += instance.OnDash;
                @Dash.performed += instance.OnDash;
                @Dash.canceled += instance.OnDash;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Join;
    private readonly InputAction m_UI_Leave;
    private readonly InputAction m_UI_Exit;
    private readonly InputAction m_UI_Pause;
    private readonly InputAction m_UI_Start;
    public struct UIActions
    {
        private @PlayerInputActions m_Wrapper;
        public UIActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Join => m_Wrapper.m_UI_Join;
        public InputAction @Leave => m_Wrapper.m_UI_Leave;
        public InputAction @Exit => m_Wrapper.m_UI_Exit;
        public InputAction @Pause => m_Wrapper.m_UI_Pause;
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Join.started -= m_Wrapper.m_UIActionsCallbackInterface.OnJoin;
                @Join.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnJoin;
                @Join.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnJoin;
                @Leave.started -= m_Wrapper.m_UIActionsCallbackInterface.OnLeave;
                @Leave.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnLeave;
                @Leave.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnLeave;
                @Exit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @Exit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @Exit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnExit;
                @Pause.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPause;
                @Start.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Join.started += instance.OnJoin;
                @Join.performed += instance.OnJoin;
                @Join.canceled += instance.OnJoin;
                @Leave.started += instance.OnLeave;
                @Leave.performed += instance.OnLeave;
                @Leave.canceled += instance.OnLeave;
                @Exit.started += instance.OnExit;
                @Exit.performed += instance.OnExit;
                @Exit.canceled += instance.OnExit;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_SplitKeyboard_1SchemeIndex = -1;
    public InputControlScheme SplitKeyboard_1Scheme
    {
        get
        {
            if (m_SplitKeyboard_1SchemeIndex == -1) m_SplitKeyboard_1SchemeIndex = asset.FindControlSchemeIndex("SplitKeyboard_1");
            return asset.controlSchemes[m_SplitKeyboard_1SchemeIndex];
        }
    }
    private int m_SplitKeyboard_2SchemeIndex = -1;
    public InputControlScheme SplitKeyboard_2Scheme
    {
        get
        {
            if (m_SplitKeyboard_2SchemeIndex == -1) m_SplitKeyboard_2SchemeIndex = asset.FindControlSchemeIndex("SplitKeyboard_2");
            return asset.controlSchemes[m_SplitKeyboard_2SchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnJoin(InputAction.CallbackContext context);
        void OnLeave(InputAction.CallbackContext context);
        void OnExit(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
    }
}
