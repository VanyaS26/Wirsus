using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDropWindowScr2 : MonoBehaviour, IBeginDragHandler , IEndDragHandler, IDragHandler
{
    public static DragAndDropWindowScr2 instance;
    public bool toMove;
    Image draggetObj;

    private void Awake()
    {
        instance = this;
        Debug.Log("Instance");
        draggetObj = GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        toMove = true;
        Debug.Log("MoveWindowAccept");
        draggetObj.raycastTarget = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        toMove = false;
        Debug.Log("MoveWindowDidable");
        draggetObj.raycastTarget = true;
    }

    public void OnDrag(PointerEventData eventData)
    {
        toMove = true;
    }
}
