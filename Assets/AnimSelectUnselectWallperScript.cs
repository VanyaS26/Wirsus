
using UnityEngine;

public class AnimSelectUnselectWallperScript : MonoBehaviour
{
    private int wallperID;
    
    [SerializeField] private int wallperIDNeed;
    [SerializeField] private AnimationClip clip;
    [SerializeField] private AnimationClip clipUn;
    [SerializeField] private Animation animation;
    private void Awake() { Anim(true); }

    public void Anim(bool doPlayFirstAnim)
    {
        wallperID = PlayerPrefs.GetInt("WallperID", 0);
        if (wallperID == wallperIDNeed && doPlayFirstAnim)
            SetAnim(clip);
        else 
            SetAnim(clipUn);
    }


    void SetAnim(AnimationClip clip)
    {
        animation.clip = clip;
        animation.Play();
    }
}
