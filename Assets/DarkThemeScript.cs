using System;
using System.Data.Common;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class DarkThemeScript : MonoBehaviour
{
    [SerializeField] private bool darktheme;
    [SerializeField] private Toggle inputField;
    ChangeThmeDarkOrLightForPanels[] _changeThmeDarkOrLightForPanels;
    ChangeThmeDarkOrLightForTexts[] _changeThmeDarkOrLightForTexts;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        darktheme = Convert.ToBoolean(PlayerPrefs.GetInt("DarkTheme"));
        inputField.isOn = darktheme;
    }

    public void ChangeTheme() {darktheme = inputField.isOn; PlayerPrefs.SetInt("DarkTheme", Convert.ToInt32(darktheme)); A(); B(); }

    private void A()
    {
        _changeThmeDarkOrLightForPanels = FindObjectsByType<ChangeThmeDarkOrLightForPanels>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (var target in _changeThmeDarkOrLightForPanels)
        {
            target.AcceptTheme();
        }
    }

    private void B()
    {
        _changeThmeDarkOrLightForTexts = FindObjectsByType<ChangeThmeDarkOrLightForTexts>(FindObjectsInactive.Include, FindObjectsSortMode.None);

        foreach (var target in _changeThmeDarkOrLightForTexts)
        {
            target.AcceptTheme();
        }
    }
}
