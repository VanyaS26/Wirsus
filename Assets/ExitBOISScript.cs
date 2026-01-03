using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitBOISScript : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene(2);
        }
    }
}
