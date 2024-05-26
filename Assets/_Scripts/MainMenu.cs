using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Material skyMaterial1;
    public Material skyMaterial2;
    public Material skyMaterial3;
    private static Material previousSkybox;
    
    public void PlayGame()
    {
        previousSkybox = RenderSettings.skybox;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        RenderSettings.skybox = previousSkybox;
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChooseSkybox1()
    {
        RenderSettings.skybox = skyMaterial1;
    }

    public void ChooseSkybox2()
    {
        RenderSettings.skybox = skyMaterial2;
    }

    public void ChooseSkybox3()
    {
        RenderSettings.skybox = skyMaterial3;
    }
}
