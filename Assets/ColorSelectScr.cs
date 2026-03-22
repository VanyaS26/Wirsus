using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectScr : MonoBehaviour
{
    
    [SerializeField] float _r;
    [SerializeField] float _g;
    [SerializeField] float _b;
    [SerializeField] InputField _red;
    [SerializeField] InputField _green;
    [SerializeField] InputField _blue;
    [SerializeField] Toggle _bois;
    [SerializeField] GameObject Canvas;
    ColorChangeThemeScript[] color;

    private void Awake()
    {
        _bois.isOn = Convert.ToBoolean(PlayerPrefs.GetInt("BIOSTheme"));
        _red.text = Convert.ToString(PlayerPrefs.GetFloat("RedColorValueTheme") * 255f);
        _green.text = Convert.ToString(PlayerPrefs.GetFloat("GreenColorValueTheme") * 255f);
        _blue.text = Convert.ToString(PlayerPrefs.GetFloat("BlueColorValueTheme") * 255f);
     
        

    }

    public void RedChange(InputField inputField) { try { _r = Convert.ToInt32(inputField.text) / 255f; PlayerPrefs.SetFloat("RedColorValueTheme", _r); A(); } catch { } }
    
    public void GreenChange(InputField inputField) { try { _g = Convert.ToInt32(inputField.text) / 255f; PlayerPrefs.SetFloat("GreenColorValueTheme", _g);A(); } catch { } }

    public void BlueChange(InputField inputField) { try { _b = Convert.ToInt32(inputField.text) / 255f; PlayerPrefs.SetFloat("BlueColorValueTheme", _b);A(); } catch { } }

    public void BOISTheme() { PlayerPrefs.SetInt("BIOSTheme", Convert.ToInt32(_bois.isOn)); }



    public void A()
    {
        color = FindObjectsByType<ColorChangeThemeScript>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (var target in color)
        {
            target.AcceptTheme();
        }
    }
}
