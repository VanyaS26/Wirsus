using UnityEngine;

public class AChScript : MonoBehaviour
{
    public static AChScript instance;
    public int block;
    void Start()
    {
        instance = this;
        block = 1;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow)) { 
            if(block < 2)
            {
                block++;
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow)) { 
            if(block > 1)
            {
                block--;
            }
        }
    }
}
