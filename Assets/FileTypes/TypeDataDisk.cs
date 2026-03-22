using UnityEngine;
using System.Collections.Generic;
using System.IO;
using Unity.Mathematics;

public class TypeDataDisk : MonoBehaviour
{
    [SerializeField]char diskName;
    [SerializeField]private List<TypeDataFolder> folders = new List<TypeDataFolder>();
    public int foldersCount;

    public void SetName(char name) {  diskName = name; }

    private void Awake()
    {
        foldersCount = folders.Count;
        Load();
        SaveDataToJson();
    }

    public void AddFolder(TypeDataFolder folder) 
    {
        folders.Add(folder);
        foldersCount = folders.Count;
        SaveDataToJson();
    }

    public void SaveDataToJson()
    {
        string jsonContent = JsonUtility.ToJson(this,true);
        string path = Path.Combine(Application.persistentDataPath, diskName + ".json");
        File.WriteAllText(path, jsonContent);
        Debug.Log("״כÿץ המ פאיכף: " + Application.persistentDataPath);
    }

    public void Load()
    {
        string path = Path.Combine(Application.persistentDataPath, diskName + ".json");
        if (File.Exists(path)) 
        { 
            string content = File.ReadAllText(path);
            JsonUtility.FromJsonOverwrite(content, this);
            foldersCount = folders.Count;
            Debug.Log("A file is loaded!");
        }
        else { Debug.Log("A file is not loaded,file dont exist,maybe this is first start"); }
    }

}
