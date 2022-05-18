using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SubmitScore : MonoBehaviour
{
    public static SubmitScore Instance;
    public int Score;

    private void Awake()
    {
       

        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadScore();
    }

    [System.Serializable]
    class SaveData
    {
        public int Score;
    }
    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.Score = Score;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Score = data.Score;
        }
    }
}
