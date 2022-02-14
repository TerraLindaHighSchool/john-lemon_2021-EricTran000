using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool isInRange;
    
    public GameObject player;
    private SphereCollider range;

    
    void pursuit()
    {
        range = GetComponent<SphereCollider>();

    }

    

    
    void Update()
    {
        if(isInRange)
        {
            transform.LookAt(player.transform);
            transform.position += transform.forward * 0.75f * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject == player)
        {
            isInRange = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        isInRange = false;
    }
}
