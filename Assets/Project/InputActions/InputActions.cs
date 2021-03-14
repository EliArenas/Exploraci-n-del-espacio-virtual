// GENERATED AUTOMATICALLY FROM 'Assets/Project/InputActions/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Avatar"",
            ""id"": ""293f33f2-749d-48c9-90b3-81dca35c4f60"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1b374c19-e6f9-483d-a444-41958a15f020"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""65450951-dfd1-441c-b6e2-4a710f72fd6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""8faf0802-d3c2-43f0-9c80-d7dc54b227a1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c7a701f1-3a5c-44b9-852c-761d4c2bf176"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""506dc9f7-531d-4b52-9a3d-cc9773c61df0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""63a3a95e-96aa-43b6-b939-a168f608a145"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""56099e09-107f-4a22-a7a2-ed513016e17e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""6d29cf8f-f0ca-4837-8336-64c82d4c8b06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Touch"",
                    ""type"": ""Value"",
                    ""id"": ""f5d5de7c-61fe-4b49-adb8-299723298533"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Tap"",
                    ""type"": ""Button"",
                    ""id"": ""2b6cde2f-ffe1-4b1b-91db-1946bd2b5d12"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""4b63a4e7-a597-4dd3-b2d6-1f0209ace237"",
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
                    ""id"": ""0c5e5854-7e66-4097-b493-8eea43e074e1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3d4759a-ab4f-4b63-b1d2-1884e5158492"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e45d622c-9f8a-4bb7-be6a-63776ff640a9"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ad7e2bf8-c3dc-4e99-a267-b0062ade0669"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""a535235f-127f-4af2-af58-5819a7a3a613"",
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
                    ""id"": ""f42326fd-061f-4b97-a04a-e751f5e7176f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d7eadfe5-ce0e-43d4-a138-caff572a55d1"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""46e7c3be-0602-41f4-b91c-bd3ccf2024b8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e6b72274-a1d9-47d1-9e90-4543bc6510d5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""47671cf4-7473-4ac6-8c5b-63ddbb9b502d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57759caf-b51a-4179-8a0c-a457f421850e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ecceb654-cf75-4fdf-b8ca-e5cfc366df72"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""848bfe1b-7ed1-4622-a0af-5584945a24bc"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d431b80c-9eb7-407e-9fa9-c903951452b6"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.5,y=0.5)"",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""648f0ffd-0d30-4fad-a6aa-ed6478137b05"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32e75226-9009-48ca-8b82-4710c8e4cc35"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24016525-ed98-4d9d-8180-97c153550cd2"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebfad539-3bff-4b34-afe1-806bd2684ec3"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c4c6494-6774-455f-a580-8ff893aa4676"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29f439f1-bdb8-49c2-a791-1a0d0ba2cac3"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5def0d7c-65c1-470c-a55e-23743800ac29"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a8c550b-c07b-4c0f-847f-a44df3f495e0"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b98e41ee-fbb3-4767-881c-b8a697aec1f3"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8bed948-d07b-4c0e-9edd-13b59d5db2ad"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b8a319d-0ea5-44a1-b694-666f31601870"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63b3928b-61fe-439c-9434-dad6f3ee7b94"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1510d01b-25a5-48d2-8051-d62c278e4d62"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""978fb523-68f7-4852-a52a-0e410a3d24a7"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a31026f5-8605-48b1-bd3a-a97b6b35ab21"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""71d9ebfc-9bf9-40a6-a336-d8f1c44ddfd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Select"",
                    ""type"": ""Button"",
                    ""id"": ""a619519e-b430-4f17-a71e-eb278af740f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveCursor"",
                    ""type"": ""Value"",
                    ""id"": ""d8d1d3b9-49c5-4edd-9324-5c9d13e17a3b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""327a5290-3b31-42bc-8d9c-243ea90541ab"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b47019e0-ddb0-44c2-92d6-86248a3e94b4"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6666de59-c33a-41c0-aa5d-c746846011bb"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ddd4098-684f-4f28-a94a-81780de1ff08"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f8cb31d-56fe-48a1-a080-39dbb3a9cdb2"",
                    ""path"": ""<Keyboard>/backspace"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5fe9b45-4bdf-4434-aeda-57a523f62e5f"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""Select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92c6b977-b84a-4eb9-82df-bc422b373cb5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30235b4d-c59a-4ff2-8290-1f6c6da3d588"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""be7d78b2-2f3d-4591-a5f8-e52b3b290193"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4882ca30-3c80-431c-bedd-b25894325105"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e9035855-f50a-4f65-81e5-f4edbbdeae79"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6faa1587-423f-4961-9c63-b31ded529329"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19f05ad2-5e6f-40e1-8a83-3da26dc23ed9"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e207e879-b143-4e0b-a43f-3925ae72ac98"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""770a32da-d4c4-4d6a-bd4b-0e8aedf3adf6"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9022cb7f-6ce0-4955-a9a4-cfadc9f7f7c8"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9d6a02d1-06d1-44d6-9a40-7a81b7070e63"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5bd32843-7f3c-4c34-9b8b-3fe1b551371d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Control Scheme"",
                    ""action"": ""MoveCursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Control Scheme"",
            ""bindingGroup"": ""Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Avatar
        m_Avatar = asset.FindActionMap("Avatar", throwIfNotFound: true);
        m_Avatar_Move = m_Avatar.FindAction("Move", throwIfNotFound: true);
        m_Avatar_Jump = m_Avatar.FindAction("Jump", throwIfNotFound: true);
        m_Avatar_Camera = m_Avatar.FindAction("Camera", throwIfNotFound: true);
        m_Avatar_Crouch = m_Avatar.FindAction("Crouch", throwIfNotFound: true);
        m_Avatar_Run = m_Avatar.FindAction("Run", throwIfNotFound: true);
        m_Avatar_Select = m_Avatar.FindAction("Select", throwIfNotFound: true);
        m_Avatar_Start = m_Avatar.FindAction("Start", throwIfNotFound: true);
        m_Avatar_Action = m_Avatar.FindAction("Action", throwIfNotFound: true);
        m_Avatar_Touch = m_Avatar.FindAction("Touch", throwIfNotFound: true);
        m_Avatar_Tap = m_Avatar.FindAction("Tap", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Start = m_UI.FindAction("Start", throwIfNotFound: true);
        m_UI_Select = m_UI.FindAction("Select", throwIfNotFound: true);
        m_UI_MoveCursor = m_UI.FindAction("MoveCursor", throwIfNotFound: true);
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

    // Avatar
    private readonly InputActionMap m_Avatar;
    private IAvatarActions m_AvatarActionsCallbackInterface;
    private readonly InputAction m_Avatar_Move;
    private readonly InputAction m_Avatar_Jump;
    private readonly InputAction m_Avatar_Camera;
    private readonly InputAction m_Avatar_Crouch;
    private readonly InputAction m_Avatar_Run;
    private readonly InputAction m_Avatar_Select;
    private readonly InputAction m_Avatar_Start;
    private readonly InputAction m_Avatar_Action;
    private readonly InputAction m_Avatar_Touch;
    private readonly InputAction m_Avatar_Tap;
    public struct AvatarActions
    {
        private @InputActions m_Wrapper;
        public AvatarActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Avatar_Move;
        public InputAction @Jump => m_Wrapper.m_Avatar_Jump;
        public InputAction @Camera => m_Wrapper.m_Avatar_Camera;
        public InputAction @Crouch => m_Wrapper.m_Avatar_Crouch;
        public InputAction @Run => m_Wrapper.m_Avatar_Run;
        public InputAction @Select => m_Wrapper.m_Avatar_Select;
        public InputAction @Start => m_Wrapper.m_Avatar_Start;
        public InputAction @Action => m_Wrapper.m_Avatar_Action;
        public InputAction @Touch => m_Wrapper.m_Avatar_Touch;
        public InputAction @Tap => m_Wrapper.m_Avatar_Tap;
        public InputActionMap Get() { return m_Wrapper.m_Avatar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(AvatarActions set) { return set.Get(); }
        public void SetCallbacks(IAvatarActions instance)
        {
            if (m_Wrapper.m_AvatarActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnJump;
                @Camera.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCamera;
                @Crouch.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnCrouch;
                @Run.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnRun;
                @Select.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnSelect;
                @Start.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnStart;
                @Action.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnAction;
                @Touch.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTouch;
                @Tap.started -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTap;
                @Tap.performed -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTap;
                @Tap.canceled -= m_Wrapper.m_AvatarActionsCallbackInterface.OnTap;
            }
            m_Wrapper.m_AvatarActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
                @Tap.started += instance.OnTap;
                @Tap.performed += instance.OnTap;
                @Tap.canceled += instance.OnTap;
            }
        }
    }
    public AvatarActions @Avatar => new AvatarActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Start;
    private readonly InputAction m_UI_Select;
    private readonly InputAction m_UI_MoveCursor;
    public struct UIActions
    {
        private @InputActions m_Wrapper;
        public UIActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_UI_Start;
        public InputAction @Select => m_Wrapper.m_UI_Select;
        public InputAction @MoveCursor => m_Wrapper.m_UI_MoveCursor;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Start.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Start.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStart;
                @Select.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @Select.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSelect;
                @MoveCursor.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCursor;
                @MoveCursor.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMoveCursor;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Start.started += instance.OnStart;
                @Start.performed += instance.OnStart;
                @Start.canceled += instance.OnStart;
                @Select.started += instance.OnSelect;
                @Select.performed += instance.OnSelect;
                @Select.canceled += instance.OnSelect;
                @MoveCursor.started += instance.OnMoveCursor;
                @MoveCursor.performed += instance.OnMoveCursor;
                @MoveCursor.canceled += instance.OnMoveCursor;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_ControlSchemeSchemeIndex = -1;
    public InputControlScheme ControlSchemeScheme
    {
        get
        {
            if (m_ControlSchemeSchemeIndex == -1) m_ControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Control Scheme");
            return asset.controlSchemes[m_ControlSchemeSchemeIndex];
        }
    }
    public interface IAvatarActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnStart(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnTouch(InputAction.CallbackContext context);
        void OnTap(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnStart(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnMoveCursor(InputAction.CallbackContext context);
    }
}
