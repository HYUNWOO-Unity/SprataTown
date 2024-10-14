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
            DontDestroyOnLoad(gameObject); // �� ��ȯ �� GameManager ����
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion


    // �÷��̾� �̸�
    private string playerName;

    // �÷��̾� �̸� ����
    public void SettingPlayerName(string name)
    {
        playerName = name;
    }

    // �÷��̾� �̸� �ҷ�����
    public string OutputPlayerName()
    {
        return playerName;
    }
}
