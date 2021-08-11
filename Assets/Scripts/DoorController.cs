using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject thisScene;
    public GameObject nextScene;
    public Vector3 playerPosition;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            SceneManager.instance.ToScene(thisScene, nextScene, other, playerPosition);
        }
    }
}
