using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Game.Inputs
{
    public sealed class InGameInputsHandler : InputsHandlerBase<InGameControls>
    {
        protected override void RegisterHandlers(InGameControls controls)
        {
            controls.Default.PointerPress.performed += HandlePointerPress;
            controls.Default.PointerPosition.performed += HandlePointerPositionChange;
            controls.Default.MenuOpen.performed += HandleMenuOpen;
        }


        private void HandlePointerPress(InputAction.CallbackContext context)
        {
            throw new NotImplementedException();
        }

        private void HandlePointerPositionChange(InputAction.CallbackContext context)
        {
            throw new NotImplementedException();
        }

        private void HandleMenuOpen(InputAction.CallbackContext obj)
        {
            throw new NotImplementedException();
        }
    }
}
