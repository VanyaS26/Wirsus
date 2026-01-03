using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainPanelAppScript : MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private AnimationClip clip;
    [SerializeField] private AnimationClip clip2;
    [SerializeField] private Animation animation;
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        animation.clip = clip;
        animation.Play();
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
        animation.clip = clip2;
        animation.Play();
    }

    
}
