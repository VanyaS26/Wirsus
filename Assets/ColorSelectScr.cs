using System;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelectScr : MonoBehaviour
{
    [SerializeField] float _r;
    [SerializeField] float _g;
    [SerializeField] float _b;
    
    void Start()
    {
        
    }

    public void RedChange(InputField inputField) { try { _r = Convert.ToInt32(inputField.text); } catch { } }
    
    public void GreenChange(InputField inputField) { try { _g = Convert.ToInt32(inputField.text); } catch { } }

    public void BlueChange(InputField inputField) { try { _b = Convert.ToInt32(inputField.text); } catch { } }

    public void SelectAndChangeColor(int color) 
    {
        PlayerPrefs.SetInt("_colorTheme", color);
        if (color == 0)
        {
            
            
            
        }
    }
    
        
    




}
