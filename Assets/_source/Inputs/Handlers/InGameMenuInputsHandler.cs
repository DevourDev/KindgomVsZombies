using System;
using UnityEngine.InputSystem;

namespace Game.Inputs
{
    public sealed class InGameMenuInputsHandler : InputsHandlerBase<InGameMenuControls>
    {
        protected override void RegisterHandlers(InGameMenuControls controls)
        {
            controls.Default.MenuClose.performed += HandleMenuClose;
        }

        private void HandleMenuClose(InputAction.CallbackContext context)
        {
            throw new NotImplementedException();
        }
    }
}
