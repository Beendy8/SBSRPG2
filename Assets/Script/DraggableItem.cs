using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    Vector3 _startPosition;
    public void OnBeginDrag(PointerEventData eventData)
    {
        _startPosition = transform.position;
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = _startPosition;
        Debug.Log("End Drag");
    }
}
