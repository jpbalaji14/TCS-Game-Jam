using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChainCollision : MonoBehaviour
{   
    void OnTriggerEnter(Collider other)
    {

      Chain.IsFired = false;

        if (other.tag == "Ball")
        {
            other.GetComponent<Ball>().BallSplit();    
        }
        
    }
}
