using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{

    public void level()
    {
        SceneManager.LoadScene("Level Select");
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
