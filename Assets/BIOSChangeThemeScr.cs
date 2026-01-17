using System;
using UnityEngine;
using UnityEngine.UI;

public class BIOSChangeThemeScr : MonoBehaviour
{
    float _r;
    float _g;
    float _b;
    [SerializeField]Image Image;

    private void Awake()
    {
        _r = PlayerPrefs.GetFloat("RedColorValueTheme");
        _g = PlayerPrefs.GetFloat("GreenColorValueTheme");
        _b = PlayerPrefs.GetFloat("BlueColorValueTheme");
        if (Convert.ToBoolean(PlayerPrefs.GetInt("BIOSTheme")))
            Image.color = new Color(_r, _g, _b, 1f);
        else
            Image.color = new Color(0f, 0.44f, 1f, 1f);
    }
}
