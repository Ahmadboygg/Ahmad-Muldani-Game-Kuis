using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[CreateAssetMenu(menuName = "Create Player Progress", fileName = "New Player Progress")]
public class PlayerProgress : ScriptableObject
{
    [System.Serializable]
    public struct MainData
    {
        public int coin;
        public Dictionary<string, int> levelProgress;
    }
    [SerializeField] private string _fileName = "New Data.txt";
    public MainData dataProgress = new MainData();

    public void SaveData()
    {

        dataProgress.coin = 100;
        if (dataProgress.levelProgress == null)
        {
            dataProgress.levelProgress = new();
            dataProgress.levelProgress.Add("level pack 1 ", 3);
            dataProgress.levelProgress.Add("level pack 3 ", 5);
        }
        var directory = Application.dataPath + "/Temp";
        var path = directory + "/" + _fileName;

        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
            Debug.Log($"Directoy has created {directory}");
        }

        if (!File.Exists(path))
        {
            File.Create(path).Dispose();
            Debug.Log($"File Created {path}");
        }

        var fileStream = File.Open(path, FileMode.Open);
        var formatter = new BinaryFormatter();
        fileStream.Flush();
        formatter.Serialize(fileStream, dataProgress);
        fileStream.Dispose();
        
        Debug.Log($"{_fileName} berhasil di simpan");

    }

    public bool LoadData()
    {
        var directory = Application.dataPath + "/Temp";
        var path = directory + "/" + _fileName;

        try
        {
            var fileStream = File.Open(path, FileMode.Open);
            var formatter = new BinaryFormatter();

            dataProgress = (MainData)formatter.Deserialize(fileStream);
            fileStream.Dispose();
            Debug.Log($"{dataProgress.coin}, {dataProgress.levelProgress.Count}");
            return true;
        }
        catch (Exception e)
        {
            Debug.Log($"Error: Terjadi kesalahan saat memuat progress \n {e.Message}");
            return false;
        }
    }
}
