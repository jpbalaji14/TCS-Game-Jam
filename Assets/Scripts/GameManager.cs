using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Timer timer;
    public PlayerMove player;
    public GameObject levelCompleteGameObject;
    public GameObject winText;
    public GameObject loseText;
    public GameObject nextButton;
    public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Ball") == null)
        {
            LevelComplete();
        }
    }

    void LevelComplete()
    {
        player.canMove = false;
        timer.isTimerOn = false;
        winText.SetActive(true);
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            retryButton.SetActive(true);
        }
        else
        {
        nextButton.SetActive(true);
        }
        levelCompleteGameObject.SetActive(true);

    }
    public void LevelLost()
    {
        player.canMove = false;
        timer.isTimerOn = false;
        GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody>().isKinematic = true;
        loseText.SetActive(true);
        retryButton.SetActive(true);
        levelCompleteGameObject.SetActive(true);

    }
}
