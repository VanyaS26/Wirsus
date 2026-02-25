using UnityEngine;
using UnityEngine.UI;

public class SetResScr : MonoBehaviour
{
    private CanvasScaler scaler;

    private void Awake()
    {
        scaler = GetComponent<CanvasScaler>();
        int x = PlayerPrefs.GetInt("ResX",1920);
        int y = PlayerPrefs.GetInt("ResY",1080);
        scaler.referenceResolution = new Vector2 (x, y);
    }
    private void FixedUpdate()
    {
        int x = PlayerPrefs.GetInt("ResX", 1920);
        int y = PlayerPrefs.GetInt("ResY", 1080);
        scaler.referenceResolution = new Vector2(x, y);
    }

}
