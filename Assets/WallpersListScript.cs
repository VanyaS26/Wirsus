using UnityEngine;

public class WallpersListScript : MonoBehaviour
{
    [SerializeField]private AnimSelectUnselectWallperScript[] animSelectUnselectWallperScripts;
    [SerializeField]private TransformWallperScript[] transformWallperScripts;
    public void OnClickOnWallper(int wallperID) 
    {
        PlayerPrefs.SetInt("WallperID", wallperID);
        for (int i = 0; i < animSelectUnselectWallperScripts.Length; i++) 
            animSelectUnselectWallperScripts[i].Anim(true);
        
        for (int i = 0; i < transformWallperScripts.Length; i++)
            transformWallperScripts[i].TransformWallper();
    }
}
