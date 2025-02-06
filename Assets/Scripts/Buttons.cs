using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public int currentSceneIndex;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void level()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void Retry()
    {
        SceneManager.LoadScene(currentSceneIndex);
    } 
    public void NextScene()
    {
        if (currentSceneIndex > 2 && currentSceneIndex <= 5)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
        }

    }
    public void play()
    {
        SceneManager.LoadScene("Game");
    }
    public void play2()
    {
        SceneManager.LoadScene("Game2");
    }
    public void play3()
    {
        SceneManager.LoadScene("Game3");
    }
    public void play4()
    {
        SceneManager.LoadScene("Game4");
    }
    public void controls()
    {
        SceneManager.LoadScene("Controls");
    }
    public void backmenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void exit()
    {
        Application.Quit();
    }
}
