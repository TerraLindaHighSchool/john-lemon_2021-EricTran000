using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    
    bool hasKey;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //gives the player a key and if they do allows them to open doors
    void OnTriggerEnter(Collider other)
    {

        if (!hasKey && other.gameObject.CompareTag("Key"))
        {

                other.gameObject.SetActive(false);
                hasKey = true;
                
        }


        if (hasKey && (other.gameObject.CompareTag("Door")))
{
            other.gameObject.SetActive(false);
            hasKey = false;
        }
    }
}

