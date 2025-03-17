using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCenter : MonoBehaviour
{
     public GameData gameData;
    public PlayerData playerData;
    public LevelData levelData;

    public void SaveData()
    {
        ES3.Save("LevelData", levelData);
        ES3.Save("PlayerData", playerData);
        ES3.Save("GameData", gameData);
    }
  
    public void LoadData()
    {
        if(ES3.KeyExists("LevelData"))
            levelData = ES3.Load("LevelData") as LevelData;

        if (ES3.KeyExists("GameData"))
            gameData = ES3.Load("GameData") as GameData;

        if (ES3.KeyExists("PlayerData"))
            playerData = ES3.Load("PlayerData") as PlayerData;
    }
}
