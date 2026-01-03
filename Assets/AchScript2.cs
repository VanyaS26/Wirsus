using UnityEngine;

public class AChScript2 : MonoBehaviour
{
    public static AChScript2 instance;
    public int block;
    void Start()
    {
        instance = this;
        block = 1;
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            if (block < 3)
            {
                block++;
            }
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            if (block > 1)
            {
                block--;
            }
        }
    }
}
