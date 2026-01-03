using UnityEngine;

public class AnimScr : MonoBehaviour
{
    public Animation animation;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)) { 
            animation.Play();
        }
    }
}
