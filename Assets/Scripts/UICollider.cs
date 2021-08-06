using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICollider : MonoBehaviour
{
    public GameObject UIGameObject;
    private bool uiOpened = false;
    private bool closest = false;

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            closest = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            closest = false;
            UIGameObject.SetActive(false);
        }
    }

    private void Update() {
        if (closest) {
            if (Input.GetKeyUp(KeyCode.Space)) {
                UIGameObject.SetActive(!uiOpened);
                uiOpened = !uiOpened;
            }
        }
    }
}
