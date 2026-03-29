using UnityEngine;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System;


public class TypeDataDisk : MonoBehaviour
{
    [SerializeField]char diskName;
    [SerializeField]private List<TypeDataFolder> folders = new List<TypeDataFolder>();
    public int foldersCount;

    private JsonSerializerSettings _settings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Auto,
        Formatting = Formatting.Indented,
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
    };

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
       
    }

    public void Load()
    {
        

    }
}
