using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneMovement : MonoBehaviour
{
    public void GoMainScene()
    {
        SceneManager.LoadScene("MainScene"); // 여기에 실제 이동할 씬 이름을 적습니다.
    }
}

