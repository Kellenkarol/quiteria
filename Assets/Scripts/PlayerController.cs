using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;

    void Start()
    {
        
    }
    void FixedUpdate()
    {
        var moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
 
        if (moveInput.y != 0) {
            transform.position += moveInput.y * Vector3.up * speed/2 * Time.fixedDeltaTime;
        }
    
        if (moveInput.x != 0) {
            transform.position += moveInput.x * Vector3.right * speed * Time.fixedDeltaTime;
        }
    }
}
