using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{   
    public static SceneManager instance;
    private float timeout = 2;
    private bool onTimeout = false;

    private void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }
    }
    public void ToScene(GameObject scene, GameObject newScene, Collision2D other, Vector3 playerPosition) 
    {
        if (onTimeout == false) {
            onTimeout = true;
            scene.SetActive(false);
            newScene.SetActive(true);
            other.gameObject.transform.position = playerPosition;
        }
    }
    private void UpdateTimeout() {
        if (onTimeout) {
            timeout -= 1 * Time.deltaTime;
            if (timeout <= 0) {
                onTimeout = false;
                timeout = 2;
            }
        }

        GameObject UITime = GameObject.Find("Time");
        UITime.GetComponent<Text>().text = timeout.ToString("##.##");

        GameObject UIinTime = GameObject.Find("inTime");
        UIinTime.GetComponent<Text>().text = onTimeout.ToString();
    }

    void Update() {
        UpdateTimeout();
    }
}
