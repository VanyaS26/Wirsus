using UnityEngine;

[CreateAssetMenu(fileName = "TypeDataDisk", menuName = "Scriptable Objects/TypeDataDisk")]
public class TypeDataDisk : ScriptableObject
{
    public char diskName;
    public TypeDataFolder[] data;
}
