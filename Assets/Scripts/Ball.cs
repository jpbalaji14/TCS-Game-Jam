using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    
    [SerializeField] Vector3 startForce;
    [SerializeField] GameObject nextball;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);
    }

    public void BallSplit()
    {
        if(nextball != null)        
        {
            GameObject ball1 = Instantiate(nextball, rb.position, Quaternion.identity); 
            GameObject ball2 = Instantiate(nextball, rb.position, Quaternion.identity);

            ball1.GetComponent<Ball>().startForce=new Vector3(2f,5f,0f);
            ball2.GetComponent<Ball>().startForce = new Vector3(-2f,5f, 0);
        }
       
         Destroy(gameObject);

    }

}
