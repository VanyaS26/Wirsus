using UnityEngine;

public class ShotDownScript : MonoBehaviour
{
    public void AcceptShotDown()
    {
        Application.Quit();
        Debug.Log("function complete");
    }
}
