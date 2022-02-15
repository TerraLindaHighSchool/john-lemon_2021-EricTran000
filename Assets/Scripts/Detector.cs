using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{
    public bool detected;
    
    public GameObject player;
    [SerializeField] SphereCollider range;


    void pursuit()
    {
        range = GetComponent<SphereCollider>();

    }




    void Update()
    {
        range = GetComponent<SphereCollider>();
        if (detected)
        {
            
            transform.LookAt(player.transform);
            transform.position += transform.forward * 0.75f * Time.deltaTime;
        }
    }

    private void OnTriggerStay(Collider other)
    {

        if(other.gameObject == player)
        {
            detected = true;
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            detected = false;
        }
    }
}
