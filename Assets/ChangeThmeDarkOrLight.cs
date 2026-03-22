using System;
using UnityEngine;
using UnityEngine.UI;

public class ChangeThmeDarkOrLightForPanels : MonoBehaviour
{
    [SerializeField] bool DarkTheme;
    [SerializeField] Image image;
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
            image.color = new Color(0.2f, 0.2f, 0.2f);
        else
            image.color = new Color(0.84f, 0.84f, 0.84f);

    }


}
