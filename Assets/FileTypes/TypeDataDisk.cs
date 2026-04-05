using UnityEngine;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System;


public class TypeDataDisk : MonoBehaviour
{
    private DiskWithoutMono withoutMono = new DiskWithoutMono();
    [SerializeField]char diskName;
    [SerializeField]private List<FolderWithoutMono> folders = new List<FolderWithoutMono>();
    public int foldersCount;

    private JsonSerializerSettings _settings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Auto,
        Formatting = Formatting.Indented,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    };

    public void SetName(char name) {  diskName = name; UpdateDisk(false); }

    private void Awake()
    {
        foldersCount = folders.Count;
        Load();
    }

    public void AddFolder(FolderWithoutMono folder) 
    {
        folders.Add(folder);
        foldersCount = folders.Count;
        UpdateDisk(false);
    }

    private void UpdateDisk(bool res)
    {
        if (!res)
        {
            withoutMono.foldersCount = foldersCount;
            withoutMono.list = folders;
            withoutMono.nameDisk = diskName;
        }
        else
        {
            diskName = withoutMono.nameDisk;
            folders = withoutMono.list;
            foldersCount = withoutMono.foldersCount;
        }
        SaveDataToJson();
    }

    public void SaveDataToJson()
    {
        PlayerPrefs.SetString("diskName", Convert.ToString(diskName));
        string path = Application.persistentDataPath;
        string fileName = string.Join("_", (diskName.ToString() + ".json").Split(Path.GetInvalidFileNameChars()));
        path = Path.Combine(path, fileName);
        string obj = JsonConvert.SerializeObject(withoutMono, _settings);
        File.WriteAllText(path,obj);
        Debug.Log("Save to" + path);
    }

    public void Load()
    {
        diskName = Convert.ToChar(PlayerPrefs.GetString("diskName","D"));
        string path = Application.persistentDataPath;
        string fileName = string.Join("_", (diskName.ToString() + ".json").Split(Path.GetInvalidFileNameChars()));
        path = Path.Combine(path, fileName);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            withoutMono = JsonConvert.DeserializeObject<DiskWithoutMono>(json);
            if(withoutMono == null)
            {
                withoutMono = new DiskWithoutMono();
            }
            UpdateDisk(true);
        }
    }
}
