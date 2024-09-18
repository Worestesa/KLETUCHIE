using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // ����������� ������ ��� ������
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
            }
        }
    }

    void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
        Debug.Log("���� ���� ���������� �� �����.");
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        Debug.Log("���� ���� ����� � �����.");
    }
}