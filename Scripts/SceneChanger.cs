using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public float volume;
    public Slider volumeSlider;
    public void MenuScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:0);
    }

    public void MassScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:1);
    }

    public void FrictionScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:2);
    }

    public void InstructionScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:3);
    }

    public void CoMScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:4);
    }

    public void CoEScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:5);
    }

    public void SettingsScene()
    {
        SceneManager.LoadScene(sceneBuildIndex:6);
    }
}
