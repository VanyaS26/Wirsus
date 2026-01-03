using UnityEngine;

public class ActiveScript2 : MonoBehaviour
{

    public int cost;
    public GameObject gameObject5;
    public bool active;

    // Update is called once per frame
    void Update()
    {
        if (cost == AChScript2.instance.block)
        {
            gameObject5.SetActive(true);
            active = true;
        }
        else
        {
            gameObject5.SetActive(false);
            active = false;
        }
    }
}
