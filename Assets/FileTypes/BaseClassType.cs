using System;
using System.Collections.Generic;

[Serializable]
public class FileData
{
    public string type; // "exe", "txt" тощо
    public string fileName;
    // Сюди додавай інші поля (розмір, іконка)
}

[Serializable]
public class FolderData
{
    public string folderName;
    public List<FileData> files = new List<FileData>();
}

[Serializable]
public class DiskSaveData
{
    public char diskName;
    public List<FolderData> folders = new List<FolderData>();
}