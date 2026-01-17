using System;
using UnityEngine;
using UnityEngine.UI;

public class ChangeThmeDarkOrLightForTexts : MonoBehaviour
{
    [SerializeField] bool DarkTheme;
    [SerializeField] Text image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        ChangeColor();
    }

    public void AcceptTheme() { ChangeColor(); }

    private void ChangeColor()
    {
        DarkTheme = Convert.ToBoolean(PlayerPrefs.GetInt("DarkTheme"));
        if (DarkTheme)
            image.color = new Color(1f, 1f, 1f, 1f);
        else
            image.color = new Color(0f, 0f, 0f, 1f);

    }
}
