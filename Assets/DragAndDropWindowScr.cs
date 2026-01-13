using Unity.VisualScripting;

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragAndDropWindowScr : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    RectTransform rectTransform;
    Image draggetObj;
    
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        draggetObj = GetComponent<Image>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {

        if (Input.GetKey(KeyCode.Tab))
            draggetObj.raycastTarget = false;
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (Input.GetKey(KeyCode.Tab))
            rectTransform.anchoredPosition += eventData.delta;
    }

   

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Input.GetKey(KeyCode.Tab))
            draggetObj.raycastTarget = true;
    }
}
