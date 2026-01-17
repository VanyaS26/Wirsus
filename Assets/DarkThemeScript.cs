using UnityEngine;
using System;
using UnityEngine.UI;
using System.Data.Common;

public class DarkThemeScript : MonoBehaviour
{
    [SerializeField] private bool darktheme;
    [SerializeField] private Toggle inputField;
    public ChangeThmeDarkOrLightForPanels[] changeThmeDarkOrLightForPanels;
    public ChangeThmeDarkOrLightForTexts[] changeThmeDarkOrLightForTexts;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        darktheme = Convert.ToBoolean(PlayerPrefs.GetInt("DarkTheme"));
        inputField.isOn = darktheme;
    }

    public void ChangeTheme() {darktheme = inputField.isOn; PlayerPrefs.SetInt("DarkTheme", Convert.ToInt32(darktheme)); A(); B(); }

    private void A()
    {
        int i = 0;

        while (i < changeThmeDarkOrLightForPanels.Length) { changeThmeDarkOrLightForPanels[i].AcceptTheme(); i++; }
    }

    private void B()
    {
        int i = 0;

        while (i < changeThmeDarkOrLightForTexts.Length) { changeThmeDarkOrLightForTexts[i].AcceptTheme(); i++; }
    }
}
