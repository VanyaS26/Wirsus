using UnityEngine;
using UnityEngine.UI;

public class NightLightScr : MonoBehaviour
{
    private Image image;

    private void Awake() {  image = GetComponent<Image>(); }
    
    public void A(Toggle toggle) { image.enabled = toggle.isOn; }
}
