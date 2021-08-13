using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatController : MonoBehaviour
{
    public float speed = 10;
    private string direction = "d";
    private Player player;

    private void Start() 
    {
        transform.position = new Vector3(transform.position.x, -4.6f, transform.position.z);
        player = Player.instance;
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "Player") {
            player.TakeDamage(10);
        }
    }
    void Update()
    {
        if (direction == "u") {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            if (transform.position.y >= -4.5) direction = "d";
        } else if (direction == "d") {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            if (transform.position.y <= -9) direction = "u";
        }
    }
}
