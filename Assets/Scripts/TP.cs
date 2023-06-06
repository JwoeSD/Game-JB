using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TP : MonoBehaviour
{
    private GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    void OnCollisionEnter2D(Collision2D Colider)
    {

        if (Colider.gameObject.name == "Charachter")
        {
            SceneManager.LoadScene("EndScreen");
        }
    }
}