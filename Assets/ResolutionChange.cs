using UnityEngine;

public class ResolutionChange : MonoBehaviour
{
    public void SetResolutionX(int resolutionX) { PlayerPrefs.SetInt("ResX", resolutionX); }

    public void SetResolutionY(int resolutionY) { PlayerPrefs.SetInt("ResY", resolutionY); }
}
