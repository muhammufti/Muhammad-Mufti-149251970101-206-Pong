using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Muhammad Mufti 149251970101-206");
    }

    public void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}