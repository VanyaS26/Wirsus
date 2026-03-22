using UnityEngine;

[CreateAssetMenu(fileName = "TypeDataFolder", menuName = "Scriptable Objects/TypeDataFolder")]
public class TypeDataFolder : ScriptableObject
{
    public string folderName;
    public object[] data;
    public bool needUAC;
}
