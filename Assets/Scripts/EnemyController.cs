using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    Transform player;
    [SerializeField]
    float agroRange;
    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position, player.position);
 
        if(distToPlayer < agroRange) 
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }



    }
    private void ChasePlayer()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
            transform.localScale = new Vector2(-1, 1);

        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            transform.localScale = new Vector2(1, 1);

        }
    }

    private void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
}



