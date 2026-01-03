using UnityEngine;
using UnityEngine.UI;

public class BAScript : MonoBehaviour
{
    int onoff = 0;
    public Text text;
    public ActiveScript2 script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onoff = PlayerPrefs.GetInt("BA", 0);
        if (onoff == 0)
        {
            text.text = "Off";
        }
        else if (onoff == 1)
        {
            text.text = "On";
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
                PlayerPrefs.SetInt("BA", onoff);
                text.text = "On";
            }
            else if (Input.GetKeyUp(KeyCode.KeypadMinus))
            {
                onoff = 0;
                PlayerPrefs.SetInt("BA", onoff);
                text.text = "Off";
            }
        }

    }
}