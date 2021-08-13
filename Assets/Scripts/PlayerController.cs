using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Player player;
    protected JoyButton joybutton;
    protected Joystick joystick;
    protected Rigidbody2D playerRigidBody;

    void Start()
    {
        player = Player.instance;
        playerRigidBody = player.GetComponent<Rigidbody2D>();
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<JoyButton>();
    }
    void FixedUpdate()
    {
        Vector2 moveJoystick = new Vector2(joystick.Horizontal * player.speed, joystick.Vertical * player.speed/2);
        playerRigidBody.velocity = moveJoystick * 40 * Time.fixedDeltaTime;
        
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
 
        if (moveInput.y != 0) {
            player.transform.position += moveInput.y * Vector3.up * player.speed/2 * Time.fixedDeltaTime;
        }
    
        if (moveInput.x != 0) {
            player.transform.position += moveInput.x * Vector3.right * player.speed * Time.fixedDeltaTime;
        }
    }
}
