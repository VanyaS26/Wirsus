using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BIOSChangeThemeScr : MonoBehaviour
{
    float _r;
    float _g;
    float _b;
    [SerializeField] Image Image;
    [SerializeField] Text text;

    private void Awake()
    {
        _r = PlayerPrefs.GetFloat("RedColorValueTheme");
        _g = PlayerPrefs.GetFloat("GreenColorValueTheme");
        _b = PlayerPrefs.GetFloat("BlueColorValueTheme");
        if (Convert.ToBoolean(PlayerPrefs.GetInt("BIOSTheme")))
            ChangeThemeToCustom();
        else
            ChangeThemeToStandart();
    }

    private void ChangeThemeToCustom()
    {
        if (Image != null)
            Image.color = new Color(_r, _g, _b, 1f);
        if (text != null)
            text.color = new Color(_r, _g, _b, 1f);
    }

    private void ChangeThemeToStandart()
    {
        if (Image != null)
            Image.color = new Color(0, 0.44f, 1, 1f);
        if (text != null)
            text.color = new Color(0, 0.44f, 1f, 1f);
    }
        
}
