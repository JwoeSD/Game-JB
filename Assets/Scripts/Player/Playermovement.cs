using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{

    public float MovementSpeed = 5;
    public float JumpForce = 5;  
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()

    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += MovementSpeed * Time.deltaTime * new Vector3(movement, 0, 0);

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)

            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);

    }



}
//rigidbody zorgt ervoor dat het object physica heeft//
//var movement zorgt ervoor dat de speler bepaalde acties/bewegingen kan gebruikt worden//
//input.getbuttondown zorgt ervoor dat het functie "jump" wordt uitgevoerd door middel van een knop/toets//

    
