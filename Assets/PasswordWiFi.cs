using UnityEngine;
using UnityEngine.UI;

public class PasswordWiFi : MonoBehaviour
{
    InputField inputField;
    

    private void Start()
    {
        inputField = GetComponent<InputField>();
        inputField.text = PlayerPrefs.GetString("PasswordWiFi", "12345678");
        
    }

    public void OnValueChanged()
    {
        PlayerPrefs.SetString("PasswordWiFi", inputField.text);
    }
}
