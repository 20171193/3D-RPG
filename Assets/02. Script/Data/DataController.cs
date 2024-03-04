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

    public GameData gameData;

    [ContextMenu("Save")]
    public void Save()
    {
        if (!File.Exists(path))
            Directory.CreateDirectory(path);

        string filepath = Path.Combine(path, "Test.txt");
        string json = JsonUtility.ToJson(gameData, true);
        File.WriteAllText(filepath, json);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        string filePath = Path.Combine(Application.dataPath, "Data/Test.txt");
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            gameData = JsonUtility.FromJson<GameData>(json);
        }
        else
            Debug.Log($"File path : {filePath} does not exist");
    }
}
