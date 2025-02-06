using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{   public GameManager gameManager;
    [SerializeField] TextMeshProUGUI timertext;
    [SerializeField]float time=50f;
    float currentTime = 0f;
    public bool isTimerOn = true;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = time;
    }

    private void Update()
    {
        if (isTimerOn)
        {
            currentTime -= 1 * Time.deltaTime;
            timertext.text = currentTime.ToString("0");

            if (currentTime <= 0)
            {
                gameManager.LevelLost();
            }
        }
    }

}
