using UnityEngine;
using UnityEngine.UI;

public class UniversialTumblerScr : MonoBehaviour
{
    [SerializeField]int neededPos;
    [SerializeField]string key;
    int pos = 0;
    [SerializeField]string[] textAtPos;
    private Text text;

    [SerializeField]CostScr script;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = textAtPos.Length;
        text = GetComponent<Text>();
        pos = PlayerPrefs.GetInt(key, 0);
        for(int i = 0; i < a; i++)
        {
            if(pos == i)
            {
                text.text = textAtPos[i];
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (script.block == neededPos)
        {
            if (Input.GetKeyUp(KeyCode.KeypadPlus))
            {
                pos++;
                PlayerPrefs.SetInt(key, pos);
                text.text = textAtPos[pos];
            }
            else if (Input.GetKeyUp(KeyCode.KeypadMinus) && pos > 0)
            {
                pos--;
                PlayerPrefs.SetInt(key, pos);
                text.text = textAtPos[pos];
            }
        }

    }
    
}
