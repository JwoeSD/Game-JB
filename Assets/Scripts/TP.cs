using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class TP : MonoBehaviour
{
    private GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemy")
        {
           player.transform.position = new Vector3(-9.7f, 1.9f, 0f);
        }
    }
}