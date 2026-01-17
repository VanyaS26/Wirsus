using System;

using UnityEngine;
using UnityEngine.UI;

public class ColorChangeThemeScript : MonoBehaviour
{
    [SerializeField] public float _r;
    [SerializeField] private float _g;
    [SerializeField] private float _b;
    [SerializeField]private float _a;
    [SerializeField] private Image _image;
    [SerializeField] private bool _infoForApp;
    private void Awake()
    {
        if (_infoForApp)
            _a = 0.98f;
        else
            _a = 1f;

        _r = PlayerPrefs.GetFloat("RedColorValueTheme");
        _g = PlayerPrefs.GetFloat("GreenColorValueTheme");
        _b = PlayerPrefs.GetFloat("BlueColorValueTheme");
        if (_r != null && _g != null && _b != null)
            _image.color = new Color(_r, _g, _b, _a);

    }
    public void AcceptTheme()
    {
        _r = PlayerPrefs.GetFloat("RedColorValueTheme");
        _g = PlayerPrefs.GetFloat("GreenColorValueTheme");
        _b = PlayerPrefs.GetFloat("BlueColorValueTheme");
        if (_r != null && _g != null && _b != null)
            _image.color = new Color(_r, _g, _b, _a);
        Debug.Log("На цьому об'єкті успішно змінений колір");
    }
}
