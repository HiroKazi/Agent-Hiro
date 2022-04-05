using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 100;

   
   
    void Start()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
}
