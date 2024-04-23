using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SystemManager : MonoBehaviour
{
    public static SystemManager Instance;

    public string PlayerName;
    public int HighScore;

    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadPlayerData();
    }

    [System.Serializable]
    class SaveData
    {
        public string PlayerName;
        public int HighScore;
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData();

        string json = JsonUtility.ToJson(data);
        
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.PlayerName;
            HighScore = data.HighScore;
        }
    }
}
