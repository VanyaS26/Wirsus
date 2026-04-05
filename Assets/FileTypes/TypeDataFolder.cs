using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TypeDataFolder : MonoBehaviour 
{
    [SerializeField] string folderName;
    [SerializeField] int filesCount;
    [SerializeField] List<BaseFileType> files = new List<BaseFileType>();
    [SerializeField] private FolderWithoutMono withoutMono = new FolderWithoutMono();


    public void SetName(string name) { folderName = name; UpdateFolder(false); }

    private void Awake()
    {
        Load();
    }

    public void AddFile(BaseFileType file) 
    {
        files.Add(file);
        filesCount = files.Count;
        UpdateFolder(false);
    }

    private void UpdateFolder(bool res)
    {
        if (!res)
        {
        }
        else
        {
        }
        SaveDataToJson();
    }

    public void SaveDataToJson()
    {
        string path = Application.persistentDataPath;
        string fileName = string.Join("_", (folderName + ".json").Split(Path.GetInvalidFileNameChars()));
        path = Path.Combine(path, fileName);
        string obj = JsonUtility.ToJson(withoutMono, true);
        File.WriteAllText(path, obj);
    }

    public void Load()
    {
        string path = Application.persistentDataPath;
        string fileName = string.Join("_", (folderName + ".json").Split(Path.GetInvalidFileNameChars()));
        path = Path.Combine(path, fileName);
        if (File.Exists(path))
        {
            string obj = File.ReadAllText(path);
            withoutMono = JsonUtility.FromJson<FolderWithoutMono>(obj);
            UpdateFolder(true);
        }
    }
}
