using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInformation : MonoBehaviour
{
    [SerializeField] private InputField playerInputName; // �Է� �ʵ�
    [SerializeField] private SceneMovement sceneMove; // �� �̵� ��ũ��Ʈ

    private string playerName = null;

    private void Awake()
    {
        // playerInputName �� sceneMove�� null���� üũ
        if (playerInputName == null)
        {
            Debug.LogError("playerInputName is not assigned in the inspector!");
        }

        if (sceneMove == null)
        {
            Debug.LogError("sceneMove is not assigned in the inspector!");
        }
    }

    // �÷��̾� �̸� ����
    public void PlayerInputNameSave()
    {
        // �Է� �ʵ��� �ؽ�Ʈ�� null���� Ȯ��
        if (playerInputName == null)
        {
            Debug.LogError("playerInputName is null!");
            return; // early return to prevent NullReferenceException
        }

        // Player Name 2 ~ 10 ���� ���� ����
        if (playerInputName.text.Length > 1 && playerInputName.text.Length < 11)
        {
            string playerName = playerInputName.text;

            // ���� �Ŵ����� �̸� ����
            GameManager.instance.SettingPlayerName(playerName);

            // �� �̵�
            if (sceneMove != null) // sceneMove�� null���� Ȯ��
            {
                sceneMove.GoMainScene();
            }          
        }
        else
        {
            Debug.LogWarning("�г����� 2�� �̻� 10�� ���Ϸ� �Է��ؾ� �մϴ�.");
        }
    }
}
