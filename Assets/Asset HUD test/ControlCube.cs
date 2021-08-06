using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    /*public float velocidade;
    float axisY;
    float axisX;*/

    Vector2 speedX;
    Vector2 speedY;
    float axisY;
    float axisX;
    public float MaxSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 dir = new Vector2(Input.GetAxis("Horizontal") * MaxSpeed, Input.GetAxis("Vertical") * MaxSpeed);

        // if(dir != Vector2.zero)
        // {
        //     transform.forward = Vector2.Normalize(dir);
        // }
        
        /*axisY = Input.GetAxis("Vertical") * velocidadeY
        #axisY = Input.GetAxis("Horizontal") * velocidadeX*/
        
    }

    void FixedUpdate()
    {

        // axisX = Input.GetAxis ("Horizontal");
        // axisY = Input.GetAxis ("Vertical");

        // speedX = new Vector2 (axisX * MaxSpeed, GetComponent<Rigidbody2D>().velocity.y);
        // speedY = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, axisY * MaxSpeed);

        // GetComponent<Rigidbody2D>().velocity = speedX;
        // GetComponent<Rigidbody2D>().velocity = speedY;

        //transform.localPosition = new Vector3(rotation, translation, -82);
    }
}
