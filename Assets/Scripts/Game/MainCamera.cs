using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour

{

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);

    }
}
//gameobject vermeld de Player en zou via de unity zelf aangepast kunnen worden vanwegen de public class//
//void start zorgt ervoor dat een functie na het opstarten van een game wordt aangepast//
//void update zorgt ervoor dat door geheel de loop van de game een functie wordt aangepast//
    