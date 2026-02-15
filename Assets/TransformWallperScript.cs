using UnityEngine;
using UnityEngine.UI;

public class TransformWallperScript : MonoBehaviour
{
    [SerializeField] private int idWallper;
    private int wallperIdNeed;
    private Image _imageWallper;
    private Animation _animationWallper;
    [SerializeField]private AnimationClip _clipOn;
    [SerializeField]private AnimationClip _clipOff;
    void Awake()
    {
        wallperIdNeed = PlayerPrefs.GetInt("WallperID", 0);
        _imageWallper = GetComponent<Image>();
        _animationWallper = GetComponent<Animation>();
        TransformWallper();
    }
    public void TransformWallper()
    {
        wallperIdNeed = PlayerPrefs.GetInt("WallperID");
        bool a = CheckWallper();
        if (a) { _animationWallper.clip = _clipOn; _animationWallper.Play(); }
        else { 
            if(_imageWallper.color.a == 1) {_animationWallper.clip = _clipOff; _animationWallper.Play(); }
        }
    }
    bool CheckWallper() { if (wallperIdNeed == idWallper) { return true; } else { return false; } }
}
