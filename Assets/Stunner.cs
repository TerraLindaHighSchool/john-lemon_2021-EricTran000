using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private CapsuleCollider hitBox;

    bool j_HasStun;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stunner"))
        {

            j_HasStun = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {

        hitBox = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {

        if (j_HasStun && Input.GetKeyDown(KeyCode.R))
        {
            hitBox.enabled = false;
        }
    }
}
