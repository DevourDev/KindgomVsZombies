using Game.Core;
using UnityEngine;
using UnityEngine.EventSystems;
#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Game.Assets.Ui
{
    public sealed class CellOnScene : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
    {
        private GridManager _parent;
        private Cell _internalCell;


#if UNITY_EDITOR
        private void OnDrawGizmos()
        {
            if (_internalCell == null)
                return;

            Handles.color = Color.cyan;
            Handles.Label(transform.position, _internalCell.Coords.ToString());
        }
#endif

        internal void Init(GridManager parent, Cell internalCell)
        {
            _parent = parent;
            _internalCell = internalCell;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            Debug.Log("Down");
        }


        public void OnPointerEnter(PointerEventData eventData)
        {
            Debug.Log("Enter");
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Debug.Log("Exit");
        }


    }
}
