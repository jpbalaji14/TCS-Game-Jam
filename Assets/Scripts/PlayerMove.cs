using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] float moveSpeed = 6f;
    public bool canMove=true;

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            float MoveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            transform.Translate(MoveX, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag=="Ball")
        {
            gameManager.LevelLost();

        }
    }

    private void ReloadScene()
    {
        int currentscene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentscene);
    }
}
