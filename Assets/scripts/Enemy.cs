using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Animator Sakit;
    void Start()
    {

        Sakit = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Kena()
    {
        Sakit.SetTrigger("swordHitTrigger");
        Sakit.SetInteger("swordHitSelect", 1);
        
    }

    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Kena");
        if (other.tag == "Katana")
        {
            Kena();
            GetComponent<Transform>().position = new Vector3(0, 0, -1);
        }

    }
}
