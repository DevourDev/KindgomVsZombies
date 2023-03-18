//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.0
//     from Assets/_source/Inputs/Controls/InGameMenuControls.inputactions
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

namespace Game.Inputs
{
    public partial class @InGameMenuControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @InGameMenuControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""InGameMenuControls"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""5a88c9a7-9f2c-4ca6-b814-924235e54238"",
            ""actions"": [
                {
                    ""name"": ""MenuClose"",
                    ""type"": ""Button"",
                    ""id"": ""54a2a11d-0736-4b1f-ad98-b1422b21b8b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed5e87e5-f2ef-4ba2-a63c-93a98278a71b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuClose"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Default
            m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
            m_Default_MenuClose = m_Default.FindAction("MenuClose", throwIfNotFound: true);
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

        // Default
        private readonly InputActionMap m_Default;
        private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
        private readonly InputAction m_Default_MenuClose;
        public struct DefaultActions
        {
            private @InGameMenuControls m_Wrapper;
            public DefaultActions(@InGameMenuControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @MenuClose => m_Wrapper.m_Default_MenuClose;
            public InputActionMap Get() { return m_Wrapper.m_Default; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
            public void AddCallbacks(IDefaultActions instance)
            {
                if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
                @MenuClose.started += instance.OnMenuClose;
                @MenuClose.performed += instance.OnMenuClose;
                @MenuClose.canceled += instance.OnMenuClose;
            }

            private void UnregisterCallbacks(IDefaultActions instance)
            {
                @MenuClose.started -= instance.OnMenuClose;
                @MenuClose.performed -= instance.OnMenuClose;
                @MenuClose.canceled -= instance.OnMenuClose;
            }

            public void RemoveCallbacks(IDefaultActions instance)
            {
                if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IDefaultActions instance)
            {
                foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public DefaultActions @Default => new DefaultActions(this);
        public interface IDefaultActions
        {
            void OnMenuClose(InputAction.CallbackContext context);
        }
    }
}
