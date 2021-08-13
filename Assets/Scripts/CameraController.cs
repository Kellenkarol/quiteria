using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Player player;
    private Vector2 offset;
    public float horizontalOffset;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;

    void Start()
    {
        player = Player.instance;
    }

    public void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(player.transform.position.x + horizontalOffset, minX, maxX), 
            Mathf.Clamp(player.transform.position.y, minY, maxY),
            transform.position.z
        );
    }
}
