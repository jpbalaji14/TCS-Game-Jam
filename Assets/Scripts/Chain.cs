using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float speed = 2f;
    public static bool IsFired;
    // Start is called before the first frame update
    void Start()
    {
        IsFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            IsFired = true;
        }

        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            ResetFire();
        }
    }

    public void ResetFire()
    {
        transform.position = player.position;
        transform.localScale = new Vector3(1f, 0, 1f);
    }
}
