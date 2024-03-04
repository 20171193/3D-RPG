using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataController : MonoBehaviour
{
    [ContextMenu("Save")]
    public void Save()
    {
        string path = Path.Combine(Application.dataPath, "Test.txt");
        File.WriteAllText(path, "Saved Data");
    }

    [ContextMenu("Load")]
    public void Load()
    {
        string path = Path.Combine(Application.dataPath, "Test.txt");
        File.ReadAllText(path);
    }
}
