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
    public void TeachButton()
    {
        SceneManager.LoadScene("Teach");
    }
    public void TestButton()
    {
        SceneManager.LoadScene("TestSkillScene");
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    // Go To Battle Scene
    public void Scene01()
    {
        SceneManager.LoadScene("Scene01");
    }
    public void Scene02()
    {
        SceneManager.LoadScene("Scene03");
    }
    public void Scene03()
    {
        SceneManager.LoadScene("Scene03");
    }

    // Go To Skill Scene
    public void SkillScene01()
    {
        SceneManager.LoadScene("SkillScene01");
    }
    public void SkillScene02()
    {
        SceneManager.LoadScene("SkillScene03");
    }
    public void SkillScene03()
    {
        SceneManager.LoadScene("SkillScene03");
    }

    // Test Scene
    public void SkillTestButton()
    {
        SceneManager.LoadScene("TestMainScene");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Start");
    }
}