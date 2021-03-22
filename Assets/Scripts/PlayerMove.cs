using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        transform.Translate(MoveX,0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag=="Ball")
        {
            ReloadScene();

        }
    }

    private void ReloadScene()
    {
        int currentscene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentscene);
    }
}
