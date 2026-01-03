using UnityEngine;
using UnityEngine.SceneManagement;

public class PreBOISScript : MonoBehaviour
{
    
    void Update()
    {
        int BMO = PlayerPrefs.GetInt("BMO", 0);
        if(BMO == 0)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            if (Input.GetKeyUp(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene(2);
            }
            else if (Input.GetKeyUp(KeyCode.F1)) 
            {
                SceneManager.LoadScene(1);
            }
                
        }

    }
}
