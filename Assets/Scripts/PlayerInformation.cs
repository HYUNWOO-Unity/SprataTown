using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PlayerInformation : MonoBehaviour
{
    [SerializeField] private InputField playerInputName; // 입력 필드
    [SerializeField] private SceneMovement sceneMove; // 씬 이동 스크립트

    private string playerName = null;

    private void Awake()
    {
        // playerInputName 및 sceneMove가 null인지 체크
        if (playerInputName == null)
        {
            Debug.LogError("playerInputName is not assigned in the inspector!");
        }

        if (sceneMove == null)
        {
            Debug.LogError("sceneMove is not assigned in the inspector!");
        }
    }

    // 플레이어 이름 저장
    public void PlayerInputNameSave()
    {
        // 입력 필드의 텍스트가 null인지 확인
        if (playerInputName == null)
        {
            Debug.LogError("playerInputName is null!");
            return; // early return to prevent NullReferenceException
        }

        // Player Name 2 ~ 10 글자 사이 제한
        if (playerInputName.text.Length > 1 && playerInputName.text.Length < 11)
        {
            string playerName = playerInputName.text;

            // 게임 매니저에 이름 저장
            GameManager.instance.SettingPlayerName(playerName);

            // 씬 이동
            if (sceneMove != null) // sceneMove가 null인지 확인
            {
                sceneMove.GoMainScene();
            }          
        }
        else
        {
            Debug.LogWarning("닉네임은 2자 이상 10자 이하로 입력해야 합니다.");
        }
    }
}
