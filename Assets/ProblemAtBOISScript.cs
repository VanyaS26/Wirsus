using UnityEngine;
using UnityEngine.SceneManagement;

public class ProblemAtBOISScript : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool reBootNeed;
    void Start()
    {
        panel.SetActive(false);
        int onoff1 = PlayerPrefs.GetInt("SecureBoot", 0);
        int onoff2 = PlayerPrefs.GetInt("SecureBootSmart", 0);
        if (onoff1 == 1 && onoff2 == 1)
        {
            panel.SetActive(true);
            reBootNeed = true;
        }
        else
        {
            reBootNeed = false;
        }
    }
    float time = 2;
  
    void Update()
    {
        if (reBootNeed)
        {
            if (Input.GetKeyUp(KeyCode.KeypadEnter))
            {
                SceneManager.LoadScene(0);
            }
        }
        else 
        { 
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
                SceneManager.LoadScene(3);
            }
        }
    }
}
