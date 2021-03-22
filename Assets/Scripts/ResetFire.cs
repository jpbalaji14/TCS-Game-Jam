using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFire : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag =="TopWall")
        {
            other.GetComponent<Chain>().ResetFire();
        }
    }
}
