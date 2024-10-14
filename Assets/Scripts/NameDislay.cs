using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameDislay : MonoBehaviour
{

    [SerializeField] private Text nameDisplayText; // 닉네임을 표시할 텍스트 UI

    private void Start()
    {
        // GameManager에서 닉네임을 가져와서 표시
        string playerName = GameManager.instance.OutputPlayerName();
        nameDisplayText.text = playerName; // 텍스트 UI에 닉네임 설정
    }
}
