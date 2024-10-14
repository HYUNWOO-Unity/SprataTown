using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameDislay : MonoBehaviour
{

    [SerializeField] private Text nameDisplayText; // �г����� ǥ���� �ؽ�Ʈ UI

    private void Start()
    {
        // GameManager���� �г����� �����ͼ� ǥ��
        string playerName = GameManager.instance.OutputPlayerName();
        nameDisplayText.text = playerName; // �ؽ�Ʈ UI�� �г��� ����
    }
}
