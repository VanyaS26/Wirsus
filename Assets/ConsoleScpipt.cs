
using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleScpipt : MonoBehaviour
{
    [SerializeField] UAC UAC;
    InputField inputField;
    Text text;
    string[] words;
    [SerializeField] ColorSelectScr scr;
    [SerializeField] AppActivate Games;
    [SerializeField] AppActivate Settings;
    [SerializeField] AppActivate Secure;
    bool _isAndim;
    

    private void Awake()
    {
        inputField = GetComponent<InputField>();
        text = GetComponentInChildren<Text>();
        ClearConsole();
        if (text != null && inputField != null)
            Debug.Log("founded");
        
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
            OnEndEdit();
        if (Input.GetKeyUp(KeyCode.Delete))
            ClearConsole();
        
    }

    public void OnEndEdit()
    {

        string raw = inputField.text.Trim();  // ← це прибере \n з кінця (і пробіли з початку/кінця)

        if (string.IsNullOrWhiteSpace(raw))
        {
            Debug.Log("this is fucking big problem");

            ClearConsole();
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
            text.fontStyle = fontStyle; ClearConsole();
        }
        else if (words.Length > 0 && words[0] == "wifipassword") { ResendWiFiPassword(words[1], words[2]); }
        else if (words.Length > 0 && words[0] == "help") {Debug.Log("help"); Help();}
        else if (words.Length > 0 && words[0] == "colortheme") { if (words[1] != "check") { try { Debug.Log("colorth"); int r = Convert.ToInt32(words[1]); int g = Convert.ToInt32(words[2]); int b = Convert.ToInt32(words[3]); ColorThemeChange(r, g, b); } catch { } } else { CheckColorTheme(); } }
        else if (words.Length > 0 && words[0] == "openapp") { string app = words[1]; OpenApp(app); }
        else if (words.Length > 0 && words[0] == "closeapp") { string app = words[1]; CloseApp(app); }
        else if (words.Length > 0 && words[0] == "print") { Print(); }
        else if (words.Length > 0 && words[0] == "offmachine") { if (_isAndim) { Application.Quit(); } else { StartCoroutine(WaitAndPrint(2f,"restart as administrator")); } }
        else if (words.Length > 0 && words[0] == "runuac") { RunUAC(); }
        else { ClearConsole(); }
    }

    async void RunUAC()
    {
        _isAndim = await UAC.StartUAC(this);
        WaitAndPrint(2f, "permission: " + Convert.ToString(_isAndim));
        ClearConsole();
    }
    void Print()
    {
        ClearConsole();
        for (int i = 1; i < words.Length; i++)
        {
            inputField.text = inputField.text + " " + words[i];
        }
    }
    void CloseApp(string app)
    {
        if(app == "games") { Games.CloseApp(); }
        else if (app == "settings") { Settings.CloseApp(); }
        else if (app == "secure") { Secure.CloseApp(); }
        else { StartCoroutine(WaitAndPrint(2f, "unkniwn app")); }
    }
    void OpenApp(string app)
    {
        if(app == "games") { OpenAppInScript(Games); }
        else if(app == "settings") { OpenAppInScript(Settings); }
        else if(app == "secure") { OpenAppInScript(Secure); }
        else { StartCoroutine(WaitAndPrint(2f, "unknown app")); }
    }

    void OpenAppInScript(AppActivate appActivate)
    {
        appActivate.OpenApp();
    }

    void CheckColorTheme()
    {
        float r = PlayerPrefs.GetFloat("RedColorValueTheme") * 255f;
        float g = PlayerPrefs.GetFloat("GreenColorValueTheme") * 255f;
        float b = PlayerPrefs.GetFloat("BlueColorValueTheme") * 255f;
        Debug.Log("color of theme:" + r + " " + b + " " + g);
        StartCoroutine(WaitAndPrint(2f,"color:" + r + " " + b + " " + g));
    }

    void ColorThemeChange(float r,float g,float b)
    {
        ClearConsole(); Debug.Log(r + " " + b + " " + g);
        PlayerPrefs.SetFloat("RedColorValueTheme", r / 255f);PlayerPrefs.SetFloat("GreenColorValueTheme", g / 255f);PlayerPrefs.SetFloat("BlueColorValueTheme", b / 255f);
        scr.A();
    }

    void ClearConsole() { inputField.text = string.Empty; }
    
    void ResendWiFiPassword(string firstPassword, string secondPassword) 
    {
        Debug.Log("Wifi");
        if (firstPassword == PlayerPrefs.GetString("PasswordWiFi", "12345678")) { PlayerPrefs.SetString("PasswordWiFi", secondPassword); StartCoroutine(WaitAndPrint(2f, "successfully")); }//resendpass 
        else
            StartCoroutine(WaitAndPrint(2f, "change failed:uncurrent password"));
    }

    void ChangeColor(Color color) {text.color = color; ClearConsole(); }

    void Help()
    {
        inputField.text =
            "color [color] - change text color\n" +
            "font [font] - change font\n" +
            "wifipassword [currentPassword] [newPassword] - change wifi password\n" +
            "help - print this message\n" +
            "colortheme [r] [g] [b] - change theme color\n" +
            "openapp [App name] - open anything app\n" +
            "closeapp [App name] - close anything app\n" +
            "print [massange] - print anything\n" +
            "offmachine - off your pc(if you have administrator permisions)\n" + 
            "press [Delete] to clear console";
    }

    IEnumerator WaitAndPrint(float seconds,string massage)
    {
        Debug.Log("Coroutine are worked");
        inputField.text = massage;
        yield return new WaitForSeconds(seconds);
        ClearConsole();
        Debug.Log("Coruatine was stopped");
    }
}
