using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player instance;
    public Slider healthBar;
    public float speed;
    public int health;

    void Awake(){
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
        } else {
            instance = this;
        }
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }

    private void Update() {
        healthBar.value = health;
    }
}
