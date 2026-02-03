using UnityEngine;
using UnityEngine.UI;

public class ToggleFillScript : MonoBehaviour
{
    private float r;
    private float g;
    private float b;
    [SerializeField] private Image _toggleImage;
    private Toggle _toggle;
    private void Awake() { 
        r = PlayerPrefs.GetFloat("RedColorValueTheme",1); 
        g = PlayerPrefs.GetFloat("GreenColorValueTheme",1);
        b = PlayerPrefs.GetFloat("BlueColorValueTheme",1); 
        _toggle = gameObject.GetComponent<Toggle>();
        if (_toggle.isOn)
            _toggleImage.color = new Color(r, g, b, 1);
        
    }
    
    public void ToggleChangeValue() { OnToggleValueChanged(_toggle.isOn);}
    
        
    private void OnToggleValueChanged(bool value) {
        if (value)
            _toggleImage.color = new Color(r, g, b, 1);
        else
            _toggleImage.color = new Color(1, 1, 1, 1);
       
    }
    
}
