using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Instance
    public static GameManager instance = null;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 GameManager 유지
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion


    // 플레이어 이름
    private string playerName;

    // 플레이어 이름 저장
    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    // 플레이어 이름 불러오기
    public string OutputPlayerName()
    {
        return playerName;
    }
}
