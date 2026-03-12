using UnityEngine;

public class InstanceChange : MonoBehaviour
{
    public ColorSelectScr scr;
    public static ColorSelectScr instance;

    private void Awake()
    {
        instance = scr;
    }
}
