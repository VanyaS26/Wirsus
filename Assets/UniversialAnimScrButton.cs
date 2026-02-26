using System.Collections;
using UnityEngine;

public class UniversialAnimScrButton : MonoBehaviour
{
    [SerializeField] private Animation animation;
    [SerializeField] private AnimationClip animationClip;
    [SerializeField] private AnimationClip clipRev;
    bool a = false;
    public void Play()
    {
        if (!a) { animation.gameObject.SetActive(true); animation.clip = animationClip; animation.Play(); a = true; }
        else {animation.clip = clipRev; animation.Play(); a = false; StartCoroutine(enumerator()); }
    }

    IEnumerator enumerator()
    {
        yield return new WaitForSeconds(0.3f);
        animation.gameObject.SetActive(false);
    }
}
