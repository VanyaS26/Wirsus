using UnityEngine;
using UnityEngine.EventSystems;

public class AnimScriptHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animation animation;
    [SerializeField]private AnimationClip clip;
    [SerializeField]private AnimationClip clipRev;

    public void OnPointerEnter(PointerEventData eventData)
    {
        animation.clip = clip;
        animation.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animation.clip = clipRev;
        animation.Play();
    }

    private void Awake() {animation = GetComponent<Animation>();}
        
    
}
