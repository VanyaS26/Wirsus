using UnityEngine;
using UnityEngine.UI;

public class SliserColorScript : MonoBehaviour
{
    Slider slider;
    [SerializeField]Image image;

    private void Awake()
    {
        slider = GetComponent<Slider>();
    }

    public void OnValueChanged()
    {
        if (slider != null && slider.value < 2000)
            image.color = new Color(0, 1, 0);
        else if (slider != null && slider.value >= 2000 && slider.value < 4000)
            image.color = new Color(1, 1, 0);
        else if (slider != null && slider.value >= 4000 && slider.value < 5500)
            image.color = new Color(1, 0.5f, 0);
        else
            image.color = new Color(1, 0, 0);
    }
}
