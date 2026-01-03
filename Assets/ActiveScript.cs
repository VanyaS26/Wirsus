using UnityEngine;

public class ActiveScript : MonoBehaviour
{

    public int cost;
    public GameObject gameObject5;
    public bool active;

    // Update is called once per frame
    void Update()
    {
        if (cost == AChScript.instance.block)
        {
            gameObject5.SetActive(true);
            active = true;
        }
        else { 
            gameObject5.SetActive(false);
            active = false;
        }
    }
}
