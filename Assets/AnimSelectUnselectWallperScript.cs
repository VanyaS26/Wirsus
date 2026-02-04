using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimSelectUnselectWallperScript : MonoBehaviour
{
    private int wallperID;
    InputAction inputAction;
    [SerializeField] private int wallperIDNeed;
    [SerializeField] private AnimationClip clip;
    [SerializeField] private AnimationClip clipUn;
    [SerializeField] private Animation animation;
    private void Awake() { wallperID = PlayerPrefs.GetInt("WallperID", 0); Anim(); }

    public void Anim(bool doPlayFirstAnim)
    {
        if (wallperID == wallperIDNeed && doPlayFirstAnim)
            SetAnim(clip);
        else 
            SetAnim(clipUn);
    }

    void OnEnable()
    {
        inputAction.Enable();
        inputAction.performed += ctx => Anim(false);
    }

    void SetAnim(AnimationClip clip)
    {
        animation.clip = clip;
        animation.Play();
    }
}
