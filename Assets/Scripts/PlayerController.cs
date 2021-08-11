using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;

    void Start()
    {
        player = Player.instance;
    }
    void FixedUpdate()
    {
        var moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
 
        if (moveInput.y != 0) {
            player.transform.position += moveInput.y * Vector3.up * player.speed/2 * Time.fixedDeltaTime;
        }
    
        if (moveInput.x != 0) {
            player.transform.position += moveInput.x * Vector3.right * player.speed * Time.fixedDeltaTime;
        }
    }
}
