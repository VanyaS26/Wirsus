using UnityEngine;

public class SelectOpScript : MonoBehaviour
{
    public GameObject Main;
    public GameObject mainButton;
    public GameObject Achvement;
    public GameObject achvementButton;
    public GameObject Security;
    public GameObject securityButton;
    public GameObject Exit;
    public GameObject exitButton;
    public int block;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        block = 1;
        Selected();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.RightArrow) && block < 4)
        {
            block++;
            Selected();
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow) && block > 1) { 
            block--;
            Selected();
        }
    }

    private void Selected()
    {
        Main.SetActive(false);
        mainButton.SetActive(false);
        Achvement.SetActive(false);
        achvementButton.SetActive(false);
        Exit.SetActive(false);
        exitButton.SetActive(false);
        Security.SetActive(false);
        securityButton.SetActive(false);
        if (block == 1)
        {
            Main.SetActive(true);
            mainButton.SetActive(true);
        }
        else if (block == 2)
        {
            Achvement.SetActive(true);
            achvementButton.SetActive(true);
        }
        else if (block == 3)
        {
            Security.SetActive(true);
            securityButton.SetActive(true);
        }
        else { 
            Exit.SetActive(true);
            exitButton.SetActive(true);
        }
    }
}
