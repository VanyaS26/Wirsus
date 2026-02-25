using UnityEngine;

public class UniversialAnimScrButton : MonoBehaviour
{
    [SerializeField] private Animation animation;
    [SerializeField] private AnimationClip animationClip;
    [SerializeField] private AnimationClip clipRev;
    bool a = false;
    public void Play()
    {
        if (!a) { animation.clip = animationClip; animation.Play(); a = true; }
        else { animation.clip = clipRev; animation.Play(); a = false; }
    }

    
}
