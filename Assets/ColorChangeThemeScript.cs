using System;

using UnityEngine;
using UnityEngine.UI;
using static ColorSelectScr;

public class ColorChangeThemeScript : MonoBehaviour
{
    [SerializeField] public float _r;
    [SerializeField] private float _g;
    [SerializeField] private float _b;
    [SerializeField]private float _a;
    [SerializeField] private Image _image;
    [SerializeField] private bool _infoForApp;
    [SerializeField] private Text text;
    private void Awake()
    {
        if (_infoForApp)
            _a = 0.98f;
        else
            _a = 1f;

        ChangeTheme();

    }
    public void AcceptTheme()
    {
       ChangeTheme();
    }

    private void ChangeTheme()
    {
        _r = PlayerPrefs.GetFloat("RedColorValueTheme");
        _g = PlayerPrefs.GetFloat("GreenColorValueTheme");
        _b = PlayerPrefs.GetFloat("BlueColorValueTheme");
        if (_image != null)
        {
            if (_r != null && _g != null && _b != null)
                _image.color = new Color(_r, _g, _b, _a);
        }
        if (text != null) 
        {
            if (_r != null && _g != null && _b != null)
                text.color = new Color(_r, _g, _b, _a);
        }
    }
}
