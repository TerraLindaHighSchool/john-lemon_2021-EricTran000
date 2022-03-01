using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restarter : MonoBehaviour
{
    public GameObject player;

    bool restart;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            restart = true;
        }
    }
    //brings the level to the next level
    private void nextLevel()
    {
        SceneManager.LoadScene("second level");
    }

}
