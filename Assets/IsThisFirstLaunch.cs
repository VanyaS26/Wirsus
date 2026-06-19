using UnityEditor.XR;
using UnityEngine;

public class IsThisFirstLaunch : MonoBehaviour
{
     public bool? isFirstLaunch{get; private set;}
     public static IsThisFirstLaunch isThisFirstLaunch;

    void Awake()
    {
        isThisFirstLaunch = this;
        if (!PlayerPrefs.HasKey("FirstLaunch"))
        {
            isFirstLaunch = true;   
            PlayerPrefs.SetInt("FirstLaunch",0);
            PlayerPrefs.Save();
        }
        else
        {
            isFirstLaunch = false;
        }
        if(isFirstLaunch == null)
        {
            Debug.Log("No 14");
        }
    }
}
