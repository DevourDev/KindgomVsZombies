using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Inputs
{
    public abstract class InputsHandlerBase<TControls> : MonoBehaviour
        where TControls : class, IDisposable, IInputActionCollection, new()
    {
        private TControls _controls;


        protected virtual void Awake()
        {
            InitControls();
        }

        protected virtual void OnDestroy()
        {
            DisposeControls();
        }


        protected virtual void OnEnable()
        {
            EnableControls();
        }

        protected virtual void OnDisable()
        {
            DisableControls();
        }


        private void InitControls()
        {
            if (_controls != null)
                DisposeControls();

            _controls = new();
            RegisterHandlers(_controls);
        }

        private void DisposeControls()
        {
            if (_controls == null)
                return;

            _controls.Dispose();
            _controls = null;
        }


        private void EnableControls()
        {
            if (_controls == null)
                InitControls();

            _controls.Enable();
        }

        private void DisableControls()
        {
            if (_controls == null)
                return;

            _controls.Disable();
        }


        protected abstract void RegisterHandlers(TControls controls);
    }
}
