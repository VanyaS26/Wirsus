using System;
using System.Collections.Generic;

[Serializable]
public class BaseFileType
{
    public string type;
    public string fileName;
    public string content;
    
    public BaseFileType(string type, string fileName, string content)
    {
        this.type = type;
        this.fileName = fileName;
        this.content = content;
    }
}
