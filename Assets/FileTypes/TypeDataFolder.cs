using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TypeDataFolder : MonoBehaviour
{
    [SerializeField] string folderName;
    [SerializeField]private List<TypeDataFolder> files = new List<TypeDataFolder>();
    public int filesCount;

    public void SetName(string name) { folderName = name; }

    private void Awake()
    {
        filesCount = files.Count;
    }

    public void AddFolder()
    {
        
       
    }

    public void SaveDataToJson()
    {
       
    }

    public void Load()
    {
        
    }
}
