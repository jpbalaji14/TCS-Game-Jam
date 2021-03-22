using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ball")
        {
           
            rb.AddForce(speed, ForceMode.Impulse);
        }
    }

}
