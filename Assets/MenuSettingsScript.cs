using UnityEngine;

public class MenuSettingsScript : MonoBehaviour
{
    [SerializeField] private Animation _animationAtB;
    [SerializeField] private Animation _animationAtP;
    [SerializeField] private AnimationClip _clipAtB;
    [SerializeField] private AnimationClip _clipRevAtB;
    [SerializeField] private AnimationClip _clipRevAtP;
    [SerializeField] private AnimationClip _clipAtP;
    private bool a = true;
    private bool b = true;

    void Awake()
    {
        
    }

    public void OnClicked()
    {
        if (a) { _animationAtB.clip = _clipAtB; _animationAtB.Play(); a = false; }
        else { _animationAtB.clip = _clipRevAtB; _animationAtB.Play();a = true; }

        if (b) { _animationAtP.clip = _clipAtP; _animationAtP.Play(); b = false; }
        else { _animationAtP.clip = _clipRevAtP; _animationAtP.Play(); b = true; }
    }
}
