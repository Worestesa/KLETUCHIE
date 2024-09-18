using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Используйте нужную вам кнопку
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
        Debug.Log("Игра была поставлена на паузу.");
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
        Debug.Log("Игра была снята с паузы.");
    }
}