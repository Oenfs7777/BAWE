using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // Start Scene
    public void StartButton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void TestButton()
    {
        SceneManager.LoadScene("TestSkillScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    // Skill Scene
    public void SkillTestButton()
    {
        SceneManager.LoadScene("TestMainScene");
    }

    // Battle Scene
    public void RestartButton()
    {
        SceneManager.LoadScene("Start");
    }
}