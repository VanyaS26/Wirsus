using UnityEngine;
using UnityEngine.UI;

public class SecureBootScript : MonoBehaviour
{
    int onoff = 0;
    public Text text;
    public ActiveScript2 script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onoff = PlayerPrefs.GetInt("SecureBoot", 0);
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
                PlayerPrefs.SetInt("SecureBoot", onoff);
                text.text = "On";
            }
            else if (Input.GetKeyUp(KeyCode.KeypadMinus))
            {
                onoff = 0;
                PlayerPrefs.SetInt("SecureBoot", onoff);
                text.text = "Off";
            }
        }

    }
}