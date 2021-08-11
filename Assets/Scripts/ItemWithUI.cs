using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemWithUI : MonoBehaviour
{
    public GameObject UIGameObject;
    public static event UnityAction<GameObject> OnUserAction;
    public static event UnityAction<GameObject> OnClose;
    private bool closest = false;

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Entrou!");
        if (other.gameObject.tag == "Player") {
            closest = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            closest = false;
            if (OnClose != null) {
                OnClose(UIGameObject);
            }
        }
    }

    private void Update() {
        if (closest) {
            if (Input.GetKeyUp(KeyCode.Space)) {
                Debug.Log("Abriu!");
                if (OnUserAction != null) {
                    OnUserAction(UIGameObject);
                }
            }
        }
    }
}
