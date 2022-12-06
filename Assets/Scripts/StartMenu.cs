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

    // Battle Scene
    public void Scene01()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void Scene02()
    {
        SceneManager.LoadScene("Scene02");
    }
    public void Scene03()
    {
        SceneManager.LoadScene("Scene03");
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