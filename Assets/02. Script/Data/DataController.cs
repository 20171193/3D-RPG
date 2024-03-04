using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataController : MonoBehaviour
{
#if UNITY_EDITOR
    private string path => $"{Application.dataPath}/Data";
#else
    private string path => $"{Application.persistentDataPath}/Data"
#endif

    [ContextMenu("Save")]
    public void Save()
    {
        if (!File.Exists(path))
            Directory.CreateDirectory(path);

        string filepath = Path.Combine(Application.persistentDataPath, "Data/Test.txt");
        File.WriteAllText(filepath, "Saved Data");
    }

    [ContextMenu("Load")]
    public void Load()
    {
        string filePath = Path.Combine(Application.dataPath, "Data/Test.txt");
        if (File.Exists(filePath))
            File.ReadAllText(filePath);
        else
            Debug.Log($"File path : {filePath} does not exist");
    }
}
