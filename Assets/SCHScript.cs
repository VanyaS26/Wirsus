using UnityEngine;
using UnityEngine.UI;

public class SCHScript : MonoBehaviour
{
    int onoff = 0;
    public Text text;
    public ActiveScript script;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onoff = PlayerPrefs.GetInt("SCH", 0);
        if ( onoff == 0)
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
                PlayerPrefs.SetInt("SCH", onoff);
                text.text = "On";
            }
            else if (Input.GetKeyUp(KeyCode.KeypadMinus))
            {
                onoff = 0;
                PlayerPrefs.SetInt("SCH", onoff);
                text.text = "Off";
            }
        }
        
    }
}
