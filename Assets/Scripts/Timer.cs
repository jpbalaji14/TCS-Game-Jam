using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text timertext;
    [SerializeField]float time=50f;
    float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = time;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timertext.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            SceneManager.LoadScene("Level Select");
        }
    }

}
