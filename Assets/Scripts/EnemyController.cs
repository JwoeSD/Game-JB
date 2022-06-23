using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float minimumDistance;



    

    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    private void Update()


    {
        float dist = Vector2.Distance(target.position, transform.position);
        if (Vector2.Distance(transform.position, target.position) > minimumDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

}


