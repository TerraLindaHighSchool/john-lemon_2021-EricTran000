using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSection : MonoBehaviour
{
    bool newSection;

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            newSection = true;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Loads the next level if the player touches the gameobject
    void Update()
    {
       if(newSection)
        {
            SceneManager.LoadScene("second level");
        }
    }
}
