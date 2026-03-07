using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleScpipt : MonoBehaviour
{
    InputField inputField;
    Text text;
    string[] words;

    private void Awake()
    {
        inputField = GetComponent<InputField>();
        text = GetComponentInChildren<Text>();
        inputField.text = string.Empty;
        if (text != null && inputField != null)
            Debug.Log("founded");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
            OnEndEdit();
        if(Input.GetKeyUp(KeyCode.Delete))
            inputField.text = string.Empty;
        
    }

    public void OnEndEdit()
    {

        string raw = inputField.text.Trim();  // ← це прибере \n з кінця (і пробіли з початку/кінця)

        if (string.IsNullOrWhiteSpace(raw))
        {
            inputField.text = string.Empty;
            return;
        }

        words = raw.Split(' ', StringSplitOptions.RemoveEmptyEntries);  // Split з опцією, щоб ігнорувати зайві пробіли

        if (words.Length == 0) return;

        words[0] = words[0].ToLower();  // або string cmd = words[0].ToLower();



        if (words.Length > 0 && words[0] == "color") 
        {
            Color color;
            try { ColorUtility.TryParseHtmlString(words[1], out color); }
            catch { color = Color.white; }
            ChangeColor(color);
        }
        else if(words.Length > 0 && words[0] == "font")
        {
            FontStyle fontStyle;
            try { fontStyle = (FontStyle)Enum.Parse(typeof(FontStyle), words[1]); } catch { fontStyle = FontStyle.Normal; }
            text.fontStyle = fontStyle; inputField.text = string.Empty;
        }
        else if(words.Length > 0 && words[0] == "wifipassword") { ResendWiFiPassword(words[1], words[2]); }
        else if( words.Length > 0 && words[0] == "help") {Debug.Log("help"); Help();}
    }
    
    void ResendWiFiPassword(string firstPassword, string secondPassword) 
    {
        Debug.Log("Wifi");
        if (firstPassword == PlayerPrefs.GetString("PasswordWiFi", "12345678")) { PlayerPrefs.SetString("PasswordWiFi", secondPassword); StartCoroutine(WaitAndPrint(2f, "successfully")); }//resendpass 
        else
            StartCoroutine(WaitAndPrint(2f, "change failed:uncurrent password"));
    }

    void ChangeColor(Color color) {text.color = color; inputField.text = string.Empty; }

    void Help()
    {
        inputField.text =
            "color [color] - change text color\n" +
            "font [font] - change font\n" +
            "wifipassword [currentPassword] [newPassword] - change wifi password\n" +
            "help - print this message\n" +
            "press [Delete] to clear console";
    }

    IEnumerator WaitAndPrint(float seconds,string massage)
    {
        inputField.text = massage;
        yield return new WaitForSeconds(seconds);
        inputField.text = string.Empty;
    }
}
