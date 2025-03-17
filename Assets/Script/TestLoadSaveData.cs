using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TestLoadSaveData : MonoBehaviour
{
    public DataCenter dataCenter;

    [Header("----InputField----")]
    public InputField playerName;
    public InputField gameName;
    public InputField levelName;

    [Header("----Text----")]
    public Text playerNameText;
    public Text gameNameText;
    public Text levelNameText;
    void Awake()
    {
        LoadData();
    }

    void OnApplicationQuit()
    {

        dataCenter.SaveData();
    }

    public void LoadData()
    {
        dataCenter.LoadData();
        playerNameText.text = dataCenter.playerData.playerName;
        gameNameText.text = dataCenter.gameData.gameName;
        levelNameText.text = dataCenter.levelData.levelName;


    }
    public void SaveData()
    {

        dataCenter.playerData.playerName = playerName.text;
        dataCenter.gameData.gameName = gameName.text;
        dataCenter.levelData.levelName = levelName.text;
        dataCenter.SaveData();
    }

}
