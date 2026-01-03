using UnityEngine;
using UnityEngine.UI;

public class BMO : MonoBehaviour
{
    int onoff = 0;
    public Text text;
    public ActiveScript script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onoff = PlayerPrefs.GetInt("BMO", 0);
        if (onoff == 0)
        {
            text.text = "Always";
        }
        else if (onoff == 1)
        {
            text.text = "Only F1";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (script.active == true)
        {
            if (Input.GetKeyUp(KeyCode.KeypadPlus))
            {
                onoff = 1;
                PlayerPrefs.SetInt("BMO", onoff);
                text.text = "Only F1";
            }
            else if (Input.GetKeyUp(KeyCode.KeypadMinus))
            {
                onoff = 0;
                PlayerPrefs.SetInt("BMO", onoff);
                text.text = "Always";
            }
        }

    }
}
